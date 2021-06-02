// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class StickerPackInfo
         : IPropagatePropertyAccessPath
    {
        public StickerPackInfo() { }
        
        public StickerPackInfo(string id, string name, bool favoriteByDefault, bool archived, bool @private, StickerPackInfo pack, List<Sticker> stickers, DateTime? addedAt = null)
        {
            Id = id;
            Name = name;
            IsFavoriteByDefault = favoriteByDefault;
            IsArchived = archived;
            IsPrivate = @private;
            AddedAt = addedAt;
            Pack = pack;
            Stickers = stickers;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(StickerPackInfo), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(StickerPackInfo), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<bool> _favoriteByDefault = new PropertyValue<bool>(nameof(StickerPackInfo), nameof(IsFavoriteByDefault));
        
        [Required]
        [JsonPropertyName("favoriteByDefault")]
        public bool IsFavoriteByDefault
        {
            get => _favoriteByDefault.GetValue();
            set => _favoriteByDefault.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(StickerPackInfo), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<bool> _private = new PropertyValue<bool>(nameof(StickerPackInfo), nameof(IsPrivate));
        
        [Required]
        [JsonPropertyName("private")]
        public bool IsPrivate
        {
            get => _private.GetValue();
            set => _private.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _addedAt = new PropertyValue<DateTime?>(nameof(StickerPackInfo), nameof(AddedAt));
        
        [JsonPropertyName("addedAt")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? AddedAt
        {
            get => _addedAt.GetValue();
            set => _addedAt.SetValue(value);
        }
    
        private PropertyValue<StickerPackInfo> _pack = new PropertyValue<StickerPackInfo>(nameof(StickerPackInfo), nameof(Pack));
        
        [Required]
        [JsonPropertyName("pack")]
        public StickerPackInfo Pack
        {
            get => _pack.GetValue();
            set => _pack.SetValue(value);
        }
    
        private PropertyValue<List<Sticker>> _stickers = new PropertyValue<List<Sticker>>(nameof(StickerPackInfo), nameof(Stickers), new List<Sticker>());
        
        [Required]
        [JsonPropertyName("stickers")]
        public List<Sticker> Stickers
        {
            get => _stickers.GetValue();
            set => _stickers.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _favoriteByDefault.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _private.SetAccessPath(path, validateHasBeenSet);
            _addedAt.SetAccessPath(path, validateHasBeenSet);
            _pack.SetAccessPath(path, validateHasBeenSet);
            _stickers.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
