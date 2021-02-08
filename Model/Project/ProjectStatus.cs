/* 
 * Xero Projects API
 *
 * This is the Xero Projects API
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.Net.Api.Client.OpenAPIDateConverter;

namespace Xero.Net.Api.Model.Project
{
    /// <summary>
    /// Status for project
    /// </summary>
    /// <value>Status for project</value>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum ProjectStatus
    {
        /// <summary>
        /// Enum INPROGRESS for value: INPROGRESS
        /// </summary>
        [EnumMember(Value = "INPROGRESS")]
        INPROGRESS = 1,

        /// <summary>
        /// Enum CLOSED for value: CLOSED
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        CLOSED = 2

    }

}
