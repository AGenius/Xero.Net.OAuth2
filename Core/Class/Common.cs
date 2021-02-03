using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xero.Net.Core
{
    /// <summary>
    /// Some Common methods
    /// </summary>
    internal static class Common
    {
        // Retrieve the Assemblies physical file location so the default path to store/load files from is usable.
        public static string ApplicationPath = System.IO.Directory.GetParent(System.Reflection.Assembly.GetEntryAssembly().Location).FullName;

        /// <summary>
        /// Handle a list of enums
        /// </summary>
        /// <typeparam name="T">Entity Type</typeparam>
        /// <param name="fieldName">The FieldName to include in the filter string  e.g.  ContactStatus</param>
        /// <param name="objectList">List of Items (Enums)</param>
        /// <returns>Concatenated string list of results</returns>
        internal static string BuildFilterString<T>(string fieldName, List<T> objectList)
        {
            List<string> itemList = objectList.ConvertAll(f => f.ToString());
            string filter = string.Empty;

            if (itemList != null)
            {
                foreach (var itm in itemList)
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " || "; //  
                    filter += $"{fieldName}=\"{itm}\"";
                }
                if (itemList.Count > 1)
                {
                    filter = "(" + filter + ")";
                }
            }
            return filter;
        }
        /// <summary>
        /// Handle a Single Enum list - Builds a string of the enum names
        /// </summary>
        /// <typeparam name="T">Entity Type (Enum)</typeparam>
        /// <param name="fieldName">The FieldName to include in the filter string  e.g.  ContactStatus</param>
        /// <param name="enumItem">The Enum</param>
        /// <returns>Concatenated string list of results</returns>
        internal static string BuildFilterString<T>(string fieldName, T enumItem)
        {
            string filter = string.Empty;

            if (enumItem != null)
            {
                filter += $"{fieldName}=\"{enumItem}\"";
            }
            return filter;
        }

        /// <summary>
        /// Decode and convert a JSON Web Token string to a JSON object string
        /// </summary>
        /// <param name="JWTTokenString">The JWT token to be decoded</param>
        /// <returns>string containing the JSON object</returns>
        public static string JWTtoJSON(string JWTTokenString)
        {
            var jwtHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
            string jsonResult = string.Empty;

            //Check if readable token (string is in a JWT format)            
            if (jwtHandler.CanReadToken(JWTTokenString))
            {
                var token = jwtHandler.ReadJwtToken(JWTTokenString);

                //Extract the payload of the JWT                
                string payload = "{";
                foreach (var item in token.Payload)
                {
                    if (item.Value.GetType().Name == "JArray")
                    {
                        payload += '"' + item.Key + "\":" + item.Value + ",";
                    }
                    else
                    {
                        payload += '"' + item.Key + "\":\"" + item.Value + "\",";
                    }
                }
                payload += "}";
                return Newtonsoft.Json.Linq.JToken.Parse(payload).ToString(Newtonsoft.Json.Formatting.Indented);
            }
            return null;
        }
    }
}
