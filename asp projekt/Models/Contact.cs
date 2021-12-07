using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5_2.Models
{
    public class Contact
    {
        public Contact()
        {
            Issues = new HashSet<Issue>();
        }

        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwę kontaktu!")]
        [MaxLength(15, ErrorMessage = "Nazwa nie może być dłuższa niż 15 znaków")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Niepoprawny adres email!")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Numer musi zawierać tylko cyfry!")]
        public string Phone { get; set; }

        [DisplayFormat(DataFormatString ="{0:F2}")]
        public int Rating { get; set; }

        public ICollection<Issue> Issues { get; set; }
    }
}
