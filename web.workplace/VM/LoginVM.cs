using System.ComponentModel.DataAnnotations;

namespace web.workplace.VM
{
    public class LoginVM
    {
        [Required(AllowEmptyStrings = false ,ErrorMessage = "User name is required" )]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false , ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }


    }
}