using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPNET_Core_3.Models
{
    public class Register
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }

        //[DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}
