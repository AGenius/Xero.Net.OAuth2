using System;

namespace Xero.Net.Core.OAuth2.Model
{
    public class Tenant
    {
        public Guid id { get; set; }
        public Guid? authEventId { get; set; }
        public Guid TenantId { get; set; }
        public string TenantType { get; set; }
        public string TenantName { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
    }
}
