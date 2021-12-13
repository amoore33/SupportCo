using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportCo.Models
{
    public class Ticket
    {
        public int ID {get; set;}
        [Display(Name = "Last Name")]
        [Required]
        public string LastName {get; set;} = string.Empty;
        [Display(Name = "First Name")]
        [Required]
        public string FirstName {get; set;} = string.Empty;
        public DateTime SubmitDate {get; set;} = DateTime.Now;
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email {get; set;} = string.Empty;
        public string Phone {get; set;} = string.Empty;
        [Display(Name = "Device Type")]
        public string DeviceType {get; set;} = string.Empty;
        public string Description {get; set;} = string.Empty;
        public string Status {get; set;} = string.Empty;
    }
}