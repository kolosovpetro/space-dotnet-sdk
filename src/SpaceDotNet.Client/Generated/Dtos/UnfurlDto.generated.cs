// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class UnfurlDto
         : IPropagatePropertyAccessPath
    {
        public UnfurlDto() { }
        
        public UnfurlDto(string title, string link, string text, UnfurlDetailsDto? details = null, string? sitename = null, string? image = null, string? imageMime = null, int? imageWidth = null, int? imageHeight = null, string? video = null, string? videoIFrame = null, string? videoMime = null, int? videoHeight = null, int? videoWidth = null, string? favicon = null)
        {
            Title = title;
            Link = link;
            Text = text;
            Details = details;
            Sitename = sitename;
            Image = image;
            ImageMime = imageMime;
            ImageWidth = imageWidth;
            ImageHeight = imageHeight;
            Video = video;
            VideoIFrame = videoIFrame;
            VideoMime = videoMime;
            VideoHeight = videoHeight;
            VideoWidth = videoWidth;
            Favicon = favicon;
        }
        
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(UnfurlDto), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get { return _title.GetValue(); }
            set { _title.SetValue(value); }
        }
    
        private PropertyValue<string> _link = new PropertyValue<string>(nameof(UnfurlDto), nameof(Link));
        
        [Required]
        [JsonPropertyName("link")]
        public string Link
        {
            get { return _link.GetValue(); }
            set { _link.SetValue(value); }
        }
    
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(UnfurlDto), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get { return _text.GetValue(); }
            set { _text.SetValue(value); }
        }
    
        private PropertyValue<UnfurlDetailsDto?> _details = new PropertyValue<UnfurlDetailsDto?>(nameof(UnfurlDto), nameof(Details));
        
        [JsonPropertyName("details")]
        public UnfurlDetailsDto? Details
        {
            get { return _details.GetValue(); }
            set { _details.SetValue(value); }
        }
    
        private PropertyValue<string?> _sitename = new PropertyValue<string?>(nameof(UnfurlDto), nameof(Sitename));
        
        [JsonPropertyName("sitename")]
        public string? Sitename
        {
            get { return _sitename.GetValue(); }
            set { _sitename.SetValue(value); }
        }
    
        private PropertyValue<string?> _image = new PropertyValue<string?>(nameof(UnfurlDto), nameof(Image));
        
        [JsonPropertyName("image")]
        public string? Image
        {
            get { return _image.GetValue(); }
            set { _image.SetValue(value); }
        }
    
        private PropertyValue<string?> _imageMime = new PropertyValue<string?>(nameof(UnfurlDto), nameof(ImageMime));
        
        [JsonPropertyName("imageMime")]
        public string? ImageMime
        {
            get { return _imageMime.GetValue(); }
            set { _imageMime.SetValue(value); }
        }
    
        private PropertyValue<int?> _imageWidth = new PropertyValue<int?>(nameof(UnfurlDto), nameof(ImageWidth));
        
        [JsonPropertyName("imageWidth")]
        public int? ImageWidth
        {
            get { return _imageWidth.GetValue(); }
            set { _imageWidth.SetValue(value); }
        }
    
        private PropertyValue<int?> _imageHeight = new PropertyValue<int?>(nameof(UnfurlDto), nameof(ImageHeight));
        
        [JsonPropertyName("imageHeight")]
        public int? ImageHeight
        {
            get { return _imageHeight.GetValue(); }
            set { _imageHeight.SetValue(value); }
        }
    
        private PropertyValue<string?> _video = new PropertyValue<string?>(nameof(UnfurlDto), nameof(Video));
        
        [JsonPropertyName("video")]
        public string? Video
        {
            get { return _video.GetValue(); }
            set { _video.SetValue(value); }
        }
    
        private PropertyValue<string?> _videoIFrame = new PropertyValue<string?>(nameof(UnfurlDto), nameof(VideoIFrame));
        
        [JsonPropertyName("videoIFrame")]
        public string? VideoIFrame
        {
            get { return _videoIFrame.GetValue(); }
            set { _videoIFrame.SetValue(value); }
        }
    
        private PropertyValue<string?> _videoMime = new PropertyValue<string?>(nameof(UnfurlDto), nameof(VideoMime));
        
        [JsonPropertyName("videoMime")]
        public string? VideoMime
        {
            get { return _videoMime.GetValue(); }
            set { _videoMime.SetValue(value); }
        }
    
        private PropertyValue<int?> _videoHeight = new PropertyValue<int?>(nameof(UnfurlDto), nameof(VideoHeight));
        
        [JsonPropertyName("videoHeight")]
        public int? VideoHeight
        {
            get { return _videoHeight.GetValue(); }
            set { _videoHeight.SetValue(value); }
        }
    
        private PropertyValue<int?> _videoWidth = new PropertyValue<int?>(nameof(UnfurlDto), nameof(VideoWidth));
        
        [JsonPropertyName("videoWidth")]
        public int? VideoWidth
        {
            get { return _videoWidth.GetValue(); }
            set { _videoWidth.SetValue(value); }
        }
    
        private PropertyValue<string?> _favicon = new PropertyValue<string?>(nameof(UnfurlDto), nameof(Favicon));
        
        [JsonPropertyName("favicon")]
        public string? Favicon
        {
            get { return _favicon.GetValue(); }
            set { _favicon.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _title.SetAccessPath(path, validateHasBeenSet);
            _link.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
            _details.SetAccessPath(path, validateHasBeenSet);
            _sitename.SetAccessPath(path, validateHasBeenSet);
            _image.SetAccessPath(path, validateHasBeenSet);
            _imageMime.SetAccessPath(path, validateHasBeenSet);
            _imageWidth.SetAccessPath(path, validateHasBeenSet);
            _imageHeight.SetAccessPath(path, validateHasBeenSet);
            _video.SetAccessPath(path, validateHasBeenSet);
            _videoIFrame.SetAccessPath(path, validateHasBeenSet);
            _videoMime.SetAccessPath(path, validateHasBeenSet);
            _videoHeight.SetAccessPath(path, validateHasBeenSet);
            _videoWidth.SetAccessPath(path, validateHasBeenSet);
            _favicon.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
