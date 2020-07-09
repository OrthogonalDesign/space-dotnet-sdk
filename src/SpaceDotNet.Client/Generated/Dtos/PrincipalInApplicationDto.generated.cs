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
    public sealed class PrincipalInApplicationDto
         : PrincipalInDto, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "PrincipalIn.Application";
        
        public PrincipalInApplicationDto() { }
        
        public PrincipalInApplicationDto(string application)
        {
            Application = application;
        }
        
        private PropertyValue<string> _application = new PropertyValue<string>(nameof(PrincipalInApplicationDto), nameof(Application));
        
        [Required]
        [JsonPropertyName("application")]
        public string Application
        {
            get { return _application.GetValue(); }
            set { _application.SetValue(value); }
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _application.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}