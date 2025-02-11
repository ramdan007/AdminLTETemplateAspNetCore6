using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaracadanWebApp.Core.Domain
{
    public class Customer: BaseEntity
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AdminComment { get; set; }
    }
}
