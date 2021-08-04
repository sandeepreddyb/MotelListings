using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotelListings.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage ="Country Name is Too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Name is Too long")]
        public string ShortName { get; set; }
    }

    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public virtual IList<HotelDTO> Hotels { get; set; }
    }
}
