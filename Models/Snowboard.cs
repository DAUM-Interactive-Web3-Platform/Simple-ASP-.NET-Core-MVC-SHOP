using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Models
{
    public class Snowboard
    {
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Length { get; set; }
      
        public string LongDescription { get; set; }

        [Required]
        public string RidingStyle { get; set; }

        
        public string ImageThumbnailUrl { get; set; }
    }

}
