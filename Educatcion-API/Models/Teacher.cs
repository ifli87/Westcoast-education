using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Educatcion_API.Models
{
    public class Teacher
    {
        
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int Telephone { get; set; }
        public string? Adress { get; set; }
        public string? City { get; set; }   
        public int ZipCode { get; set; }
        public int ClassesId { get; set; }
        [ForeignKey("ClassesId")]
        public ICollection<Classes> Classes { get; set; } = new List<Classes>();

    }

}