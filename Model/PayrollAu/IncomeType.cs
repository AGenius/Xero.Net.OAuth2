/* 
 * Xero Payroll AU API
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.Net.Api.Model.PayrollAu
{
    /// <summary>
    /// Defines IncomeType
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum IncomeType
    {
        /// <summary>
        /// Enum SALARYANDWAGES for value: SALARYANDWAGES
        /// </summary>
        [EnumMember(Value = "SALARYANDWAGES")]
        SALARYANDWAGES = 1,

        /// <summary>
        /// Enum WORKINGHOLIDAYMAKER for value: WORKINGHOLIDAYMAKER
        /// </summary>
        [EnumMember(Value = "WORKINGHOLIDAYMAKER")]
        WORKINGHOLIDAYMAKER = 2,

        /// <summary>
        /// Enum NONEMPLOYEE for value: NONEMPLOYEE
        /// </summary>
        [EnumMember(Value = "NONEMPLOYEE")]
        NONEMPLOYEE = 3,

        /// <summary>
        /// Enum CLOSELYHELDPAYEES for value: CLOSELYHELDPAYEES
        /// </summary>
        [EnumMember(Value = "CLOSELYHELDPAYEES")]
        CLOSELYHELDPAYEES = 4,

        /// <summary>
        /// Enum LABOURHIRE for value: LABOURHIRE
        /// </summary>
        [EnumMember(Value = "LABOURHIRE")]
        LABOURHIRE = 5

    }

}