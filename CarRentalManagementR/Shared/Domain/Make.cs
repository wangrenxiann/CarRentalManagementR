using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementR.Shared.Domain
{
   public class Make:BaseDomainModel
    {
        public string Name { get; set; }

        //public static implicit operator Make(Make v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
