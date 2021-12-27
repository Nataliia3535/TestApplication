using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class Incident
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Account Name is required.")]
        public string Account_Name { get; set; }
        [Required(ErrorMessage = "First is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Second is required.")]
        public string LastName { get; set; }
        [UniqEmail]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
         
        public string IncidentDescription { get; set; }
    }
}
