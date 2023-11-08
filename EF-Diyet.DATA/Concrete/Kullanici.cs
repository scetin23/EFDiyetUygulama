using EF_Diyet_UI.Abstract;
using EF_Diyet_UI.Concrete;
using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanici : IKullanici
    {
     

        public int ID { get; set; }
        [Required]
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string Mail { get; set; }
        [Required]
        public string KullaniciSifre { get; set; }

        [NotMapped]
        public string KullaniciSifreTekrari { get; set; }

        public int Yas { get; set; }
        public string Cinsiyet { get; set; }
        public decimal Kilo { get; set; }
        public decimal Boy { get; set; }
        //public virtual int? KullaniciHedefBilgileriID { get; set; }
        public KullaniciHedefBilgileri KullaniciHedefBilgileri { get; set; }

        //public virtual int? AktiviteBilgileriID { get; set; }
        //public AktiviteBilgileri AktiviteBilgileri { get; set; }



        public List<TuketilenBesin> TuketilenBesinler { get; set; }
       


        //public virtual int? SuVerisiID { get; set; }
        //public SuVerisi SuVerisi { get; set; }



        //public List<EgzersizVerisi> Egzersizler { get; set; }

        //public virtual int? VucutAnaliziID { get; set; }
        public VucutAnalizi VucutAnalizi { get; set; }


        //public virtual int? MakroBesinRaporuID { get; set; }
        //public MakroBesinRaporu MakroBesinRaporu { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        

        //public DateTime? ModifiedDate { get; set; }
        //public DateTime? DeletedDate { get; set; }
        //public string CreatedBy { get; set; }
        //public string DeletedBy { get; set; }
        //public string ModifiedBy { get; set; }
        //public Status Status { get; set; } = Status.Active;


       
    }
}
