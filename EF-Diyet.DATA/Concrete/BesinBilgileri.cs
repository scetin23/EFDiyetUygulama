using EF_Diyet_UI.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Diyet_UI.Concrete
{
    public class BesinBilgileri : IBesinBilgileri
    {
        public int ID { get; set; }
        public string BesinAdi { get; set; }
        public string OlcuBirimi { get; set; }
        public float GramKarsiligi { get; set; }

        public float? Kalori { get; set; } = 0;

        public float? Karbonhidrat { get; set; } = 0;

        public float? Protein { get; set; } = 0;
        
        public float? Yag { get; set; } = 0;
        

      
        public List<TuketilenBesin> TuketilenBesinler { get; set; }

        //public DateTime CreatedDate { get; set; } = DateTime.Now;
        //public DateTime? ModifiedDate { get; set; }
        //public DateTime? DeletedDate { get; set; }
        //public string CreatedBy { get; set; }
        //public string DeletedBy { get; set; }
        //public string ModifiedBy { get; set; }
        //public Status Status { get; set; } = Status.Active;

    }
}
