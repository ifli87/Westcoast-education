using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Educatcion_API.ViewModels.Teacher
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int Telephone { get; set; }
        public string? Adress { get; set; }
        public string? City { get; set; }   
        public int ZipCode { get; set; }
    }
}