using System;
using System.ComponentModel.DataAnnotations;

namespace ToBlazor.Models
{
    public class VideoJuego
    {
        public VideoJuego()
        {
            idVJ = Guid.NewGuid().ToString().Substring(16);
        }
        [Key]
        public string idVJ { get; set; }
        public string nombre { get; set; }
        public string foto { get; set; }
        public bool activo { get; set; }
    }
}
