﻿using EF_Diyet_UI.Abstract;
using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Diyet_UI.Concrete
{
    public class Tarifler : ITarifler
    {
        public int ID { get; set; }
        public string TarifAdi { get; set; }
        public string Aciklamasi { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        //public DateTime? ModifiedDate { get; set; }
        //public DateTime? DeletedDate { get; set; }
        //public string CreatedBy { get; set; }
        //public string DeletedBy { get; set; }
        //public string ModifiedBy { get; set; }
       
    }
}
