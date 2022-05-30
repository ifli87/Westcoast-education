using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Educatcion_API.ViewModels.Teacher
{
    public class PutTeacherViewModel
    {
        [Required]
         public string? FirstName { get; set; }
         [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public int Telephone { get; set; }
        [Required]
        public string? Adress { get; set; }
        [Required]
        public string? City { get; set; }   
        [Required]
        public int ZipCode { get; set; } 
    }
}