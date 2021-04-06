using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BMKTEnterprises.Models
{
    public class ContactModel : PageModel
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }


    }
}
