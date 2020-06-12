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
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public partial class UploadClient
    {
        private readonly Connection _connection;
        
        public UploadClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Request a URL that can be used to upload an attachment.
        /// An attachment can be uploaded to the URL that is returned, by making a PUT request that has a proper content-type header and the attachment data as the request body.
        /// The 'storagePrefix' parameter can be one of file, maps, emoji or attachments.
        /// The 'mediaType' parameter can be omitted for all uploads. For image uploads that need to be resized automatically for specific use, such as chat stickers or emoji, use one of `chat-image-attachment`, `chat-sticker`, `chat-animated-sticker`, `emoji`.
        /// </summary>
        public async Task<string> CreateUploadAsync(CreateUploadRequest data)
            => await _connection.RequestResourceAsync<CreateUploadRequest, string>("POST", $"api/http/uploads", data);
    
        public ImageClient Image => new ImageClient(_connection);
        
        public partial class ImageClient
        {
            private readonly Connection _connection;
            
            public ImageClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get meta information for a previously uploaded image.
            /// </summary>
            public async Task<ImageAttachmentMetaDto> GetImageAttachmentMetadataAsync(string id, Func<Partial<ImageAttachmentMetaDto>, Partial<ImageAttachmentMetaDto>>? partial = null)
                => await _connection.RequestResourceAsync<ImageAttachmentMetaDto>("GET", $"api/http/uploads/image/{id}?$fields={(partial != null ? partial(new Partial<ImageAttachmentMetaDto>()) : Partial<ImageAttachmentMetaDto>.Default())}");
        
        }
    
    }
    
}
