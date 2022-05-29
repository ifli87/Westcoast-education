using System.ComponentModel.DataAnnotations.Schema;

namespace Educatcion_API.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public int CourseNumber { get; set; }
        public string? Title { get; set; }
        public string? Length { get; set; }
        public int CategoryId { get; set; }
        public string? Description { get; set; }
        public string? Details { get; set; }

        [ForeignKey("CategoryId")]
         public Category Category { get; set; } = new Category();
    }
}

// Kursnummer (Idag använder kunden 4 siffror för detta t ex 1179)
// Kurs title
// Längd (t ex 3 dagar, 40 timmar video)
// Kategori( t ex JavaScript, .NET, Java, Python)
// Beskrivning (är en kortare övergripande beskrivning om kursen och varför man ska gå den)
// Detaljer (här finns information om vilka moduler/delar kursen går igenom)