using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Team:BaseEntity
    {
        public string StaffNameSurname { get; set; }
        public string StaffEmail { get; set; }
        public string StaffImageUrl { get; set; }
    }
}
