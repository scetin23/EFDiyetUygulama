using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Diyet_UI.Abstract
{
    public interface IMakaleler
    {
        int ID { get; set; }
        string MakaleAdi { get; set; }

        string Aciklamasi { get; set; }
    }
}
