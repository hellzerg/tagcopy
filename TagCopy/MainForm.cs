using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using TagLib;
using System.Net;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System.Reflection;

namespace TagCopy
{
    public partial class MainForm : Form
    {
        readonly string _latestVersionLink = "https://raw.githubusercontent.com/hellzerg/tagcopy/master/version.txt";

        const string ERROR_LOG = @"\TagCopy.errors";

        //const string LASTFM_API_KEY = "433243b12925fbb0e6095eed036087a3";
        //const string LASTFM_URL = "http://ws.audioscrobbler.com/2.0/?method=track.getInfo&api_key=";

        //const string SPOTIFY_URL = "https://shadowconf.eu:54548/artwork/";
        const string DISCOGS_URL = "https://shadowconf.eu:54548/discogs/";

        string MP3Prototype = string.Empty;
        string FLACToEdit = string.Empty;

        TagLib.File flacTrack;
        TagLib.File mp3Track;

        OpenFileDialog dialog;

        WebClient client;

        BatchOpsForm batchOpsForm;
        AboutForm aboutForm;

        const string MP3_EXTENSION = ".mp3";
        const string FLAC_EXTENSION = ".flac";
        const string ERRORS_EXTENSION = ".errors";
        const string JPG_EXTENSION = ".jpg";
        const string JPG_EXTENSION_2 = ".jpeg";
        const string BMP_EXTENSION = ".bmp";
        const string PNG_EXTENSION = ".png";

        string TEMP_PATH = Path.GetTempPath() + @"\TagCopy";

        string tempImageFile = string.Empty;
        string[] imageUrls;

        List<byte[]> imageBytesList;
        List<string> imageFiles;

        public MainForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            batchOpsForm = new BatchOpsForm();
            aboutForm = new AboutForm();

            imageBytesList = new List<byte[]>();
            imageFiles = new List<string>();

            InitTagLig();
            InitWebClient();
            InitDialog();
            InitTemp();
        }

        private string NewVersionMessage(string latestVersion)
        {
            return string.Format("There is a new version available!\n\nLatest version: {0}\nCurrent version: {1}\n\nDo you want to download it now?", latestVersion, Program.GetCurrentVersionToString());
        }

        private string NewDownloadLink(string latestVersion)
        {
            return string.Format("https://github.com/hellzerg/tagcopy/releases/download/{0}/TagCopy.exe", latestVersion);
        }

        private void CheckForUpdate()
        {
            string latestVersion = string.Empty;

            try
            {
                latestVersion = client.DownloadString(_latestVersionLink);
            }
            catch (Exception ex)
            {
                //LogError(ex, "CheckForUpdate.Init");
            }

            if (!string.IsNullOrEmpty(latestVersion))
            {
                if (float.Parse(latestVersion) > Program.GetCurrentVersion())
                {
                    if (MessageBox.Show(NewVersionMessage(latestVersion), "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // PATCHING PROCESS
                        try
                        {
                            Assembly currentAssembly = Assembly.GetEntryAssembly();

                            if (currentAssembly == null)
                            {
                                currentAssembly = Assembly.GetCallingAssembly();
                            }

                            string appFolder = Path.GetDirectoryName(currentAssembly.Location);
                            string appName = Path.GetFileNameWithoutExtension(currentAssembly.Location);
                            string appExtension = Path.GetExtension(currentAssembly.Location);

                            string archiveFile = Path.Combine(appFolder, appName + "_old" + appExtension);
                            string appFile = Path.Combine(appFolder, appName + appExtension);
                            string tempFile = Path.Combine(appFolder, appName + "_tmp" + appExtension);

                            // DOWNLOAD NEW VERSION
                            client.DownloadFile(NewDownloadLink(latestVersion), tempFile);

                            // DELETE PREVIOUS BACK-UP
                            if (System.IO.File.Exists(archiveFile))
                            {
                                System.IO.File.Delete(archiveFile);
                            }

                            // MAKE BACK-UP
                            System.IO.File.Move(appFile, archiveFile);

                            // PATCH
                            System.IO.File.Move(tempFile, appFile);

                            Application.Restart();
                        }
                        catch (Exception ex)
                        {
                            LogError(ex, "CheckForUpdate.Patch");
                        }
                    }
                }
                //else if (float.Parse(latestVersion) == Program.GetCurrentVersion())
                //{
                //    MessageBox.Show(_noNewVersionMessage, "No update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show(_betaVersionMessage, "No update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }

        private void InitTemp()
        {
            if (!Directory.Exists(TEMP_PATH)) Directory.CreateDirectory(TEMP_PATH);
        }

        private void CleanTemp()
        {
            if (Directory.Exists(TEMP_PATH))
            {
                foreach (string f in Directory.GetFiles(TEMP_PATH))
                {
                    if (f.EndsWith(ERRORS_EXTENSION)) continue;

                    System.IO.File.Delete(f);
                }
            }
        }

        private void LogError(Exception err, string comment)
        {
            System.IO.File.AppendAllText(TEMP_PATH + ERROR_LOG, Environment.NewLine + Environment.NewLine + "[FUNCTION] " + comment + Environment.NewLine + err.Message + Environment.NewLine + err.StackTrace);
        }

        private void InitDialog()
        {
            dialog = new OpenFileDialog();

            dialog.Multiselect = false;
            dialog.Filter = "ΕΙΚΟΝΕΣ | *.bmp;*.jpg;*.jpeg;*.png";
            dialog.Title = "Επιλέξτε εικόνα...";
        }

        private void InitWebClient()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private void InitTagLig()
        {
            TagLib.Id3v2.Tag.DefaultVersion = 3;
            TagLib.Id3v2.Tag.DefaultEncoding = StringType.UTF8;
            TagLib.Id3v2.Tag.ForceDefaultVersion = true;
            TagLib.Id3v2.Tag.ForceDefaultEncoding = true;
        }

        private void GetArtworkFromDiscogs(string term)
        {
            imageBytesList.Clear();

            string LINK = string.Format("{0}{1}", DISCOGS_URL, term);
            string test = client.DownloadString(LINK);

            imageUrls = test.Split('|');

            foreach (string s in imageUrls)
            {
                imageBytesList.Add(client.DownloadData(s));
            }

            //return imageBytesList;

            //return null;

            //using (MemoryStream ms = new MemoryStream())
            //{
            //    stream.CopyTo(ms);
            //    return ms.ToArray();
            //}

            //using (Stream stream = client.OpenRead(imageUrl))
            //{
                
            //}
        }

        //private byte[] GetArtworkFromLastFM(string artist, string track)
        //{
        //    string LINK = string.Format("{0}{1}&artist={2}&track={3}&format=json", LASTFM_URL, LASTFM_API_KEY, artist, track);
        //    APIResult r = JsonConvert.DeserializeObject<APIResult>(client.DownloadString(LINK));

        //    if (r != null)
        //    {
        //        if (r.Track != null)
        //        {
        //            if (r.Track.Album != null)
        //            {
        //                return client.DownloadData(r.Track.Album.Image[3].Text.ToString());
        //            }
        //        }
        //    } 

        //    return null;
        //}

        //private byte[] GetArtworkFromSpotify(string artist, string album)
        //{
        //    string LINK = string.Format("{0}{1}/{2}", SPOTIFY_URL, artist, album);
        //    string imageUrl = client.DownloadString(LINK);

        //    using (Stream stream = client.OpenRead(imageUrl))
        //    {
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            stream.CopyTo(ms);
        //            return ms.ToArray();
        //        }
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            showInfo("Σύρετε αρχεία MP3/FLAC...", true);
            this.Text = "TagCopy " + Program.GetCurrentVersionToString();

            CheckForUpdate();
            CleanTemp();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                if (files.Length > 2)
                {
                    ShowError("Μπορείτε να σύρετε μέχρι 2 αρχεία (MP3 && FLAC)");
                    return;
                }

                if (files.Length == 2)
                {
                    if (files[0].ToLowerInvariant().EndsWith(FLAC_EXTENSION) && files[1].ToLowerInvariant().EndsWith(MP3_EXTENSION))
                    {
                        flacTrack = TagLib.File.Create(files[0]);
                        FLACToEdit = files[0];
                        txtFlac.Text = Path.GetFileNameWithoutExtension(FLACToEdit);

                        mp3Track = TagLib.File.Create(files[1]);
                        MP3Prototype = files[1];
                        txtMp3.Text = Path.GetFileNameWithoutExtension(MP3Prototype);

                        ShowMP3Tags();
                        btnSearch.PerformClick();

                        return;
                    }
                    else if (files[1].ToLowerInvariant().EndsWith(FLAC_EXTENSION) && files[0].ToLowerInvariant().EndsWith(MP3_EXTENSION))
                    {
                        flacTrack = TagLib.File.Create(files[1]);
                        FLACToEdit = files[1];
                        txtFlac.Text = Path.GetFileNameWithoutExtension(FLACToEdit);

                        mp3Track = TagLib.File.Create(files[0]);
                        MP3Prototype = files[0];
                        txtMp3.Text = Path.GetFileNameWithoutExtension(MP3Prototype);

                        ShowMP3Tags();
                        btnSearch.PerformClick();

                        return;
                    }
                    else
                    {
                        ShowError("Μη έγκυρα αρχεία");
                        return;
                    }
                }

                string file = files[0];

                if (file.ToLowerInvariant().EndsWith(FLAC_EXTENSION))
                {
                    flacTrack = TagLib.File.Create(file);
                    FLACToEdit = file;
                    txtFlac.Text = Path.GetFileNameWithoutExtension(FLACToEdit);
                }
                else if (file.ToLowerInvariant().EndsWith(MP3_EXTENSION))
                {
                    mp3Track = TagLib.File.Create(file);
                    MP3Prototype = file;
                    txtMp3.Text = Path.GetFileNameWithoutExtension(MP3Prototype);

                    ShowMP3Tags();
                    btnSearch.PerformClick();
                }
                else if (file.ToLowerInvariant().EndsWith(JPG_EXTENSION) ||
                    file.ToLowerInvariant().EndsWith(JPG_EXTENSION_2) ||
                    file.ToLowerInvariant().EndsWith(PNG_EXTENSION) ||
                    file.ToLowerInvariant().EndsWith(BMP_EXTENSION))
                {
                    picArt.Image = new Bitmap(file);
                    tempImageFile = file;

                    return;
                }
                else
                {
                    ShowError("Μη έγκυρο αρχείο");
                }
            }
            catch (Exception err)
            {
                LogError(err, "DragDrop");
                ShowError("Μη έγκυρο αρχείο");
            }
        }

        private void LoadImageBytesToUI(byte[] image)
        {
            tempImageFile = Path.Combine(TEMP_PATH, Guid.NewGuid().ToString());
            System.IO.File.WriteAllBytes(tempImageFile, image);
            imageFiles.Add(tempImageFile);
        }

        private void ShowArtwork(string image)
        {
            picArt.Image = new Bitmap(image);
        }

        private void ShowMP3Tags()
        {
            if (mp3Track != null)
            {
                txtArtist.Clear();
                txtContrib.Clear();
                txtGenre.Clear();
                txtComments.Clear();

                foreach (var p in mp3Track.Tag.Pictures)
                {
                    LoadImageBytesToUI(p.Data.Data);
                    break;
                }

                foreach (string x in mp3Track.Tag.AlbumArtists)
                {
                    txtArtist.Text += x + ", ";
                }
                foreach (string x in mp3Track.Tag.Performers)
                {
                    txtContrib.Text += x + ", ";
                }
                foreach (string x in mp3Track.Tag.Genres)
                {
                    txtGenre.Text += x + ", ";
                }

                if (!string.IsNullOrEmpty(txtArtist.Text))
                {
                    txtArtist.Text = txtArtist.Text.Substring(0, txtArtist.TextLength - 2);
                }

                if (!string.IsNullOrEmpty(txtContrib.Text))
                {
                    txtContrib.Text = txtContrib.Text.Substring(0, txtContrib.TextLength - 2);
                }

                if (!string.IsNullOrEmpty(txtGenre.Text))
                {
                    txtGenre.Text = txtGenre.Text.Substring(0, txtGenre.TextLength - 2);
                }

                txtComments.Text = mp3Track.Tag.Comment;

                btnSearch.Visible = true;
                btnManual.Visible = true;
                picArt.Visible = true;
                panelTags.Visible = true;
            }
        }

        private void ShowError(string message)
        {
            messageBar.Message.Text = message;

            messageBar.ErrorImage.Visible = true;
            messageBar.InfoImage.Visible = false;
            messageBar.OkImage.Visible = false;

            messageBar.HideButton.Visible = true;
            messageBar.Visible = true;
        }

        private void ShowMessage(string message)
        {
            messageBar.Message.Text = message;

            messageBar.InfoImage.Visible = false;
            messageBar.ErrorImage.Visible = false;
            messageBar.OkImage.Visible = true;

            messageBar.HideButton.Visible = true;
            messageBar.Visible = true;
        }

        private void showInfo(string message, bool firstTime = false)
        {
            messageBar.Message.Text = message;

            messageBar.InfoImage.Visible = true;
            messageBar.ErrorImage.Visible = false;
            messageBar.OkImage.Visible = false;

            if (!firstTime)
            {
                messageBar.HideButton.Visible = true;
            }

            messageBar.Visible = true;
        }

        private void CopyTags()
        {
            flacTrack.Tag.AlbumArtists = mp3Track.Tag.AlbumArtists;
            flacTrack.Tag.Performers = mp3Track.Tag.Performers;
            flacTrack.Tag.Comment = mp3Track.Tag.Comment;
            flacTrack.Tag.Genres = mp3Track.Tag.Genres;

            if (picArt.Image == null)
            {
                if (mp3Track.Tag.Pictures.Length > 0)
                {
                    flacTrack.Tag.Pictures = mp3Track.Tag.Pictures;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(imageList.SelectedItem.ToString()))
                {
                    if (System.IO.File.Exists(imageList.SelectedItem.ToString()))
                    {
                        TagLib.Id3v2.AttachmentFrame picture = new TagLib.Id3v2.AttachmentFrame
                        {
                            Type = PictureType.FrontCover,
                            Description = "Cover",
                            MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg,
                            Data = System.IO.File.ReadAllBytes(imageList.SelectedItem.ToString()),
                            TextEncoding = StringType.Latin1
                        };

                        flacTrack.Tag.Pictures = new IPicture[1] { picture };
                    }
                }
            }

            // Rating-related code, buggy in FLAC

            //Tag flacTag = flacTrack.GetTag(TagTypes.Id3v2);
            //Tag mp3Tag = mp3Track.GetTag(TagTypes.Id3v2);

            //TagLib.Id3v2.PopularimeterFrame flacRating = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)flacTag, "foobar2000", true);
            //TagLib.Id3v2.PopularimeterFrame mp3Rating = TagLib.Id3v2.PopularimeterFrame.Get((TagLib.Id3v2.Tag)mp3Tag, "foobar2000", true);

            //flacRating.Rating = mp3Rating.Rating;

            flacTrack.Save();

            Microsoft.VisualBasic.FileSystem.Rename(flacTrack.FileAbstraction.Name, Path.Combine(Path.GetDirectoryName(flacTrack.FileAbstraction.Name), Path.GetFileName(mp3Track.FileAbstraction.Name).Replace(MP3_EXTENSION, FLAC_EXTENSION)));

            tempImageFile = string.Empty;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (mp3Track == null || flacTrack == null)
            {
                showInfo("Σύρετε αρχεία MP3/FLAC...");
                return;
            }

            try
            {
                RenderWorking();
                CopyTags();
                ShowMessage("Η αντιγραφή ολοκληρώθηκε");
            }
            catch (Exception err)
            {
                LogError(err, "CopyButton.Click");
                ShowError("Κάποιο σφάλμα προέκυψε");
            }
            finally
            {
                RenderFinished();
            }
        }

        private void RenderWorking()
        {
            btnSearch.Enabled = false;
            btnManual.Enabled = false;
            btnCopy.Enabled = false;
        }

        private void RenderFinished()
        {
            btnSearch.Enabled = true;
            btnManual.Enabled = true;
            btnCopy.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RenderWorking();

            //bool lastFMFoundWithArtist = false;
            //bool lastFMFoundWithContrib = false;
            //bool spotifyFound = false;
            bool discogsFoundContrib = false;
            //bool discogsFoundOriginal = false;

            //byte[] imageData;

            imageFiles.Clear();
            imageList.Items.Clear();

            try
            {
                GetArtworkFromDiscogs(mp3Track.Tag.FirstPerformer + " " + mp3Track.Tag.Title);

                foreach (byte[] bytes in imageBytesList)
                {
                    LoadImageBytesToUI(bytes);
                }

                foreach (string s in imageFiles)
                {
                    imageList.Items.Add(s);
                }

                if (imageFiles.Count > 0)
                {
                    discogsFoundContrib = true;
                    ShowMessage("Discogs: Βρέθηκε artwork");
                    panelImages.Visible = true;
                }
                else
                {
                    discogsFoundContrib = false;
                }  
            }
            catch (Exception err)
            {
                LogError(err, "SearchButton.Click.Discogs");
                tempImageFile = string.Empty;
                discogsFoundContrib = false;
                imageFiles.Clear();
                imageList.Items.Clear();
            }

            //if (!discogsFoundContrib)
            //{
            //    try
            //    {
            //        imageData = GetArtworkFromDiscogs(mp3Track.Tag.FirstAlbumArtist + " - " + mp3Track.Tag.Title);
            //        LoadImageBytesToUI(imageData);
            //        discogsFoundOriginal = true;
            //        ShowMessage("Discogs: Βρέθηκε artwork");
            //    }
            //    catch (Exception err)
            //    {
            //        LogError(err, "SearchButton.Click.Discogs");
            //        tempImageFile = string.Empty;
            //        discogsFoundOriginal = false;
            //    }
            //}

            if (!discogsFoundContrib)
            {
                ShowError("Δεν βρέθηκε artwork");
            }

            if (imageList.Items.Count > 0)
            {
                imageList.SelectedIndex = 0;
            }

            RenderFinished();

            //try with contributing artist
            //try
            //{
            //    imageData = GetArtworkFromLastFM(mp3Track.Tag.FirstPerformer, mp3Track.Tag.Title);
            //    LoadImageBytesToUI(imageData);
            //    lastFMFoundWithContrib = true;
            //    ShowMessage("LastFM: Βρέθηκε artwork");
            //}
            //catch (Exception err)
            //{
            //    LogError(err, "SearchButton.Click.LastFM");
            //    lastFMFoundWithContrib = false;
            //}

            // try with original artist
            //if (!lastFMFoundWithContrib)
            //{
            //    if (!string.IsNullOrEmpty(mp3Track.Tag.FirstAlbumArtist))
            //    {
            //        try
            //        {
            //            imageData = GetArtworkFromLastFM(mp3Track.Tag.FirstAlbumArtist, mp3Track.Tag.Title);
            //            LoadImageBytesToUI(imageData);
            //            lastFMFoundWithArtist = true;
            //            ShowMessage("LastFM: Βρέθηκε artwork");
            //        }
            //        catch (Exception err)
            //        {
            //            LogError(err, "SearchButton.Click.LastFM");
            //            lastFMFoundWithArtist = false;
            //        }
            //    }
            //    else
            //    {
            //        lastFMFoundWithArtist = false;
            //    }
            //}

            // try with spotify - buggy

            //if (!lastFMFound)
            //{

            //    try
            //    {
            //        imageData = GetArtworkFromSpotify(mp3Track.Tag.FirstAlbumArtist, mp3Track.Tag.Album);
            //        LoadImageBytesToUI(imageData);
            //        spotifyFound = true;
            //        ShowMessage("Spotify: Βρέθηκε artwork");
            //    }
            //    catch (Exception err)
            //    {
            //        LogError(err, "SearchButton.Click.Spotify");
            //        spotifyFound = false;
            //    }
            //}
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picArt.Image = new Bitmap(dialog.FileName);
                tempImageFile = dialog.FileName;
            }   
        }

        private void btnBatchForm_Click(object sender, EventArgs e)
        {
            batchOpsForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            aboutForm.ShowDialog();
        }

        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowArtwork(imageList.SelectedItem.ToString());
        }
    }
}
