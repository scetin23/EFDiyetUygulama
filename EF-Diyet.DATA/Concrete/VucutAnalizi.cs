using EF_Diyet_UI.Abstract;
using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class VucutAnalizi : IVucutAnalizi
    {
        public int ID { get; set; }
        public double VKI { get; set; }
        public double VYO { get; set; }
        public double BMH { get; set; }

        public int KullaniciId { get; set; }
        public Kullanici kullanici { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        //public DateTime? ModifiedDate { get; set; }
        //public DateTime? DeletedDate { get; set; }
        //public string CreatedBy { get; set; }
        //public string DeletedBy { get; set; }
        //public string ModifiedBy { get; set; }
       
    }
}
