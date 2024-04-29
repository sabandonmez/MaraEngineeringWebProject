using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Company:BaseEntity
    {
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
