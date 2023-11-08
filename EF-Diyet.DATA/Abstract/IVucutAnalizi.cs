using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IVucutAnalizi
    {
        int ID { get; set; }

        double VKI { get; set; }
        double VYO { get; set; }
        double BMH { get; set; }

        public int KullaniciId { get; set; }
        public Kullanici kullanici { get; set; }
    }
}
