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
using TagLib;

namespace TagCopy
{
    public partial class BatchOpsForm : Form
    {
        TagLib.File mp3Track;
        string[] trackFiles;

        int progressStep = 0;

        const string MP3_EXTENSION = ".mp3";

        public BatchOpsForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        private void CommentDeleter_DragDrop(object sender, DragEventArgs e)
        {
            trackList.Items.Clear();

            trackFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string file in trackFiles)
            {
                if (!file.EndsWith(MP3_EXTENSION)) continue;
                
                trackList.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void CommentDeleter_DragEnter(object sender, DragEventArgs e)
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

        private void btnBatchDelete_Click(object sender, EventArgs e)
        {
            if (trackList.Items.Count <= 0) return;

            btnBatchDelete.Enabled = false;

            progress.Value = 0;
            progressStep = 100 / trackFiles.Length;

            foreach (string track in trackFiles)
            {
                if (!track.EndsWith(MP3_EXTENSION)) continue;

                try
                {
                    mp3Track = TagLib.File.Create(track);

                    if (matchArtists.Checked)
                    {
                        mp3Track.Tag.AlbumArtists = mp3Track.Tag.Performers;
                    }

                    if (deleteComments.Checked)
                    {
                        mp3Track.Tag.Comment = string.Empty;
                    }

                    if (deleteAlbum.Checked)
                    {
                        mp3Track.Tag.Album = string.Empty;
                    }

                    if (deleteYear.Checked)
                    {
                        mp3Track.Tag.Year = 0;
                    }

                    if (deleteSubtitle.Checked)
                    {
                        mp3Track.Tag.Subtitle = string.Empty;
                    }

                    if (deleteTrackNumber.Checked)
                    {
                        mp3Track.Tag.Track = 0;
                    }

                    progress.Invoke((MethodInvoker)delegate
                    {
                        progress.Value += progressStep;
                    });

                }
                catch (Exception err)
                {
                    // log error
                    MessageBox.Show(err.Message, "Σφάλμα στο κομμάτι: " + track);
                    continue;
                }
                finally
                {
                    mp3Track.Save();
                }
            }

            progress.Value = 100;

            MessageBox.Show("Η αντιστοίχιση καλλιτεχνών ολοκληρώθηκε επιτυχώς!");

            progress.Value = 0;
            btnBatchDelete.Enabled = true;

            trackFiles = null;
            trackList.Items.Clear();
        }

        private void CommentDeleter_Load(object sender, EventArgs e)
        {
            progress.Value = 0;
        }
    }
}
