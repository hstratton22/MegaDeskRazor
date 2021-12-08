using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Plan
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Conductor { get; set; }
        [Display(Name = "Opening Song")]
       
        [Required]
        public string OpeningSong { get; set; }
        [Display(Name = "Opening Prayer")]
        [Required]
        public string OpeningPrayer { get; set; }
        [Display(Name = "Sacrament Song")]
        [Required]
        public string SacramentSong { get; set; }
        [Display(Name = "Intermediate Song")]
  
        public string? IntermediateSong { get; set; }
        [Display(Name = "Closing Song")]
        [Required]
        public string ClosingSong { get; set; }
        [Display(Name = "Closing Prayer")]
        [Required]
        public string ClosingPrayer { get; set; }
        [Display(Name = "Speaker Subjects")]
        public string SpeakerSubjects { get; set; }
        [Display(Name = "Number Speakers")]
        public int NumberSpeakers { get; set; }

        
    }
}
