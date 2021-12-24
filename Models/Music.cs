using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Playlist.Models
{
    public class Music
    {
        [Key]
        public int MusicId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Field can't be empty")]
        public string Name { get; set; }

        [Display(Name = "Album")]
        [Required(ErrorMessage = "Field can't be empty")]
        public string Album { get; set; }

        [Display(Name = "Artist")]
        [Required(ErrorMessage = "Field can't be empty")]
        public string Artist { get; set; }

        [Display(Name = "Realese Date")]
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.Date)]
        public string RealiseData { get; set; }

        [Display(Name = "Link")]
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.Url)]
        public string Link { get; set; }
    }
}
