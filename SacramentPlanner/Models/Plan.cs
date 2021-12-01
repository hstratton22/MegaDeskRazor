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
        [Range(1, 341)]
        [Required]
        public int OpeningSong { get; set; }
        [Display(Name = "Opening Prayer")]
        [Required]
        public string OpeningPrayer { get; set; }
        [Display(Name = "Sacrament Song")]
        [Range(169, 196)]
        [Required]
        public int SacramentSong { get; set; }
        [Display(Name = "Intermediate Song")]
        [Range(1, 341)]
        public int? IntermediateSong { get; set; }
        [Display(Name = "Closing Song")]
        [Range(1, 341)]
        [Required]
        public int ClosingSong { get; set; }
        [Display(Name = "Closing Prayer")]
        [Required]
        public string ClosingPrayer { get; set; }
        [Display(Name = "Speaker Subjects")]
        public string SpeakerSubjects { get; set; }
        [Display(Name = "Number Speakers")]
        public int NumberSpeakers { get; set; }

        
    }
}
