using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMKT_Enterprises.Models
{
    public class ContactModel:PageModel
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Subject { get; set; }
        [Required(ErrorMessage ="Name Required"), Display(Name="Your name")]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required(ErrorMessage ="Email Required"), Display(Name="Your email"), EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="Message Required"), DataType(DataType.EmailAddress)]
        public string Message { get; set; }

        public void OnGet()
        {
        }
    }
}
