using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Playlist.Models;

namespace Playlist.Models
{
    public class Playlist
    {
        [Key]
        public int PlaylistId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Music> musics;

        public int UserId;

        public User user;

    }
}
