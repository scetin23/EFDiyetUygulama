using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Diyet_UI.Abstract
{
    public interface IKullaniciHedefBilgileri
    {
        int ID { get; set; }

        Hedef Hedef { get; set; }

        float HedefKatSayi { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici kullanici { get; set; }
    }
}
