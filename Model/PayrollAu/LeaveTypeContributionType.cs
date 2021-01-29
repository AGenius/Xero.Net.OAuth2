/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.3
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

namespace Xero.Net.Api.Model.PayrollAu
{
    /// <summary>
    /// Defines LeaveTypeContributionType
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum LeaveTypeContributionType
    {
        /// <summary>
        /// Enum SGC for value: SGC
        /// </summary>
        [EnumMember(Value = "SGC")]
        SGC = 1,

        /// <summary>
        /// Enum SALARYSACRIFICE for value: SALARYSACRIFICE
        /// </summary>
        [EnumMember(Value = "SALARYSACRIFICE")]
        SALARYSACRIFICE = 2,

        /// <summary>
        /// Enum EMPLOYERADDITIONAL for value: EMPLOYERADDITIONAL
        /// </summary>
        [EnumMember(Value = "EMPLOYERADDITIONAL")]
        EMPLOYERADDITIONAL = 3,

        /// <summary>
        /// Enum EMPLOYEE for value: EMPLOYEE
        /// </summary>
        [EnumMember(Value = "EMPLOYEE")]
        EMPLOYEE = 4

    }

}
