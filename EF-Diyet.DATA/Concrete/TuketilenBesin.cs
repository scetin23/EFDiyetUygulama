﻿using EF_Diyet_UI.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Diyet_UI.Concrete
{
    public class TuketilenBesin : ITuketilenBesin
    {

        public int ID { get; set; }

        public virtual int? KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public virtual int? BesinBilgileriID { get; set; }
        public BesinBilgileri BesinBilgileri { get; set; }
        public Ogun Ogun { get; set; }
        public float ToplamKalori { get; set; }
        public DateTime TuketilenTarih { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        //public DateTime? DeletedDate { get; set; }
        //public string CreatedBy { get; set; }
        //public string DeletedBy { get; set; }
        //public string ModifiedBy { get; set; }
       
    }
}
