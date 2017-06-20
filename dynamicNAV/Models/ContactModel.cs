using System.ComponentModel.DataAnnotations;

namespace dynamicNAV.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage ="The first name field is required")]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The last name field is required")]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The email address field is required")]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "The message field is required")]
        [Display(Name = "Message:")]
        public string Message { get; set; }
    }
}