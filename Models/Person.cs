using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DevExpressStarterProject.Models {
    public class Person {
        [Required]
        [DisplayFormat(NullDisplayText = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DisplayFormat(NullDisplayText ="Password")]
        public string Password { get; set; }

        [Required]
        [DisplayFormat(NullDisplayText = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password you entered do not match")]
        public string ConfirmPassword { get; set; }

        [Required, RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Invalid e-mail")]
        [DisplayFormat(NullDisplayText = "E-mail")]
        public string Email { get; set; }
    }
}
