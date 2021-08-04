﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotelListings.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength:150, ErrorMessage = "Country Name is too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength:250, ErrorMessage = "Address is too long")]
        public string Address { get; set; }

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
        
    }


    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO CountryDTO { get; set; }
    }
}
