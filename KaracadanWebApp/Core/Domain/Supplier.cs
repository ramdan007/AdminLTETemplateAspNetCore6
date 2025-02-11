using System;

namespace KaracadanWebApp.Core.Domain
{
    public partial class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}
