using System.ComponentModel.DataAnnotations;

namespace Jason_CRUD.ViewModel
{
    public class CustomerViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
