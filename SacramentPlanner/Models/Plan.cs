using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Subject")]
        public string SpeakerSubjects { get; set; }
        [Display(Name = "Speakers")]
        public ICollection<Speaker> Speakers { get; set; }

        
    }
}
