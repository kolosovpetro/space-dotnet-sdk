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
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public class GitCommitSignature
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "GitCommitSignature";
        
        public static GitCommitSignatureNotVerified NotVerified()
            => new GitCommitSignatureNotVerified();
        
        public static GitCommitSignatureRaw Raw(string signature, string signedDataB64)
            => new GitCommitSignatureRaw(signature: signature, signedDataB64: signedDataB64);
        
        public static GitCommitSignatureRevokedKey RevokedKey(string description, string? revokeComment = null)
            => new GitCommitSignatureRevokedKey(description: description, revokeComment: revokeComment);
        
        public static GitCommitSignatureVerified Verified(string description)
            => new GitCommitSignatureVerified(description: description);
        
        public GitCommitSignature() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
