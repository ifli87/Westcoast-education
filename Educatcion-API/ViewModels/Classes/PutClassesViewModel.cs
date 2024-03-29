using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Educatcion_API.ViewModels
{
    public class PutClassesViewModel
    {  
        [Required]
        public int CourseNumber { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Length { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Details { get; set; }


        
    }
}