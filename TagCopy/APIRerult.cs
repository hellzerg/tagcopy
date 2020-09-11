using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TagCopy
{
    // LAST.FM

    public partial class APIResult
    {
        [JsonProperty("track")]
        public Track Track { get; set; }
    }

    public partial class Track
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mbid")]
        public Guid Mbid { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("duration")]

        public long Duration { get; set; }

        [JsonProperty("streamable")]
        public Streamable Streamable { get; set; }

        [JsonProperty("listeners")]

        public long Listeners { get; set; }

        [JsonProperty("playcount")]

        public long Playcount { get; set; }

        [JsonProperty("artist")]
        public Artist Artist { get; set; }

        [JsonProperty("album")]
        public Album Album { get; set; }

        [JsonProperty("toptags")]
        public Toptags Toptags { get; set; }
    }

    public partial class Album
    {
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("mbid")]
        public Guid Mbid { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("image")]
        public Image[] Image { get; set; }

        [JsonProperty("@attr")]
        public Attr Attr { get; set; }
    }

    public partial class Attr
    {
        [JsonProperty("position")]
        public long Position { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("#text")]
        public Uri Text { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }

    public partial class Artist
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mbid")]
        public Guid Mbid { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Streamable
    {
        [JsonProperty("#text")]
        public long Text { get; set; }

        [JsonProperty("fulltrack")]
        public long Fulltrack { get; set; }
    }

    public partial class Toptags
    {
        [JsonProperty("tag")]
        public object[] Tag { get; set; }
    }
}