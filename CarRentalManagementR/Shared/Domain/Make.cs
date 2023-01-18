using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementR.Shared.Domain
{
   public class Make:BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = " Name does not meet length requirements")]
        public string Name { get; set; }

        //public static implicit operator Make(Make v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
