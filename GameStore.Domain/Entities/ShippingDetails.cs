using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities
{
   public class ShippingDetails
    {
        [Required(ErrorMessage = "Укажите имя")]
        public string Name { get; set; }

        [Display(Name = "Почта")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = " Укажите почту ")]
        public string email { get; set; }

        [Required(ErrorMessage = "Укажите страну")]
        [Display(Name = "Страна")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Укажите город")]
        [Display(Name = "Город")]
        public string City { get; set; }

        

        
    }
}
