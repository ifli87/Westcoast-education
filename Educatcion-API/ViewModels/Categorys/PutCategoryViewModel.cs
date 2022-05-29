using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Educatcion_API.ViewModels.Categorys
{
    public class PutCategoryViewModel
    {
        [Required]
        public string? CategoryName { get; set; }
    }
}