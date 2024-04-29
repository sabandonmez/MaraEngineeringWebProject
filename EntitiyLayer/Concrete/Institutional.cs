using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Institutional:BaseEntity
    {

        public string Vision { get; set; }
        public string Mission { get; set; }
        public string Culture { get; set; }
        public string AboutUs { get; set; }

    }
}
