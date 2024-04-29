using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Reference:BaseEntity
    {
        public string ProjectName { get; set; }
        public string ClientName { get; set; } //Müşteri Adı
        public string ProjectDescription { get; set; }
        public string ProjectImageUrl { get; set; }
        public string Location { get; set; }
        public string CompletionDate { get; set; } //Tamamlanma tarihi
    }
}
