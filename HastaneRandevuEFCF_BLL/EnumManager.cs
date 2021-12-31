using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_BLL
{
    public static class EnumManager
    {

        public static List<Enums> TumBranslariGetir()
        {
            List<Enums> data = new List<Enums>();

            foreach (var item in Enum.GetValues(typeof(Branslar)))
            {
                Enums theEnum = new Enums()
                {
                    TheKey = Convert.ToInt32(item),
                    TheValue = item.ToString()
                };
                data.Add(theEnum);
            }


            return data;
        }

        public static Branslar BransiBul(int id)
        {

            switch (id)
            {
                case 0:
                    return Branslar.BransYok;

                case 1:
                    return Branslar.Dahiliye;

                case 2:
                    return Branslar.GozHastaliklari;

                case 3:
                    return Branslar.Kardiyolji;

                case 4:
                    return Branslar.KBB;

                case 5:
                    return Branslar.Ortopedi;

                default:
                    return Branslar.BransYok;

            }
        }
        public static string BransiTurkceStringOlarakVer(Branslar brans)
        {
            string bransString = "";

            switch (brans)
            {
                case Branslar.BransYok: bransString = "Genel Servis"; break;
                case Branslar.Dahiliye: bransString = "Dahiliye Servisi"; break;
                case Branslar.KBB: bransString = "KBB Servisi"; break;
                case Branslar.GozHastaliklari: bransString = "Göz Hastalıkları Servisi"; break;
                case Branslar.Ortopedi: bransString = "Ortapedi Servisi"; break;
                case Branslar.Kardiyolji: bransString = "Kardiyoloji Servisi"; break;
                default: bransString = "Genel Servis"; break;
            }

            return bransString;
        }
    }
}
