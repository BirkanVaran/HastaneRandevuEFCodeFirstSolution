using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuEFCF_DAL;
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_BLL
{
    public class DoktorManager
    {

        //Global alan
        MyContext myDBContext = new MyContext();

        public bool YeniDoktorEkle(Doktor yeniDr)
        {
            try
            {
                //1. yöntem
                myDBContext.Doktorlar.Add(yeniDr);
                //2. yöntem: Bu yöntemi ilerleyen derslerde Repository design pattern konusunda yani mvc'de kullanacağız.
                // myDBContext.Set<Doktor>().Add(yeniDr);

                myDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Doktor> TumAktifDoktorlariGetir()
        {
            try
            {
                //1. yöntem uzun fazladan bir doktor listesi oluşturmuş olduk bunun yerine 2. yöntemi kullanabiliriz.
                //List<Doktor> drList = new List<Doktor>();
                //drList = myDBContext.Doktorlar.ToList();
                //return drList;

                //2. yöntem 
                //where ile sadece aktifler çekilecek
                //Bunu daha sonra yapacağız.
                return myDBContext.Doktorlar.Where(x=>x.AktifMi).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public List<Doktor> BransaGoreDoktorlariGetir(Branslar brans)
        {
            try
            {
                return 
                    myDBContext.Doktorlar
                    .Where(x=> x.Brans==brans).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Doktor DoktoruIdyeGoreBul(int id)
        {
            try
            {
                Doktor dr = myDBContext.Doktorlar.FirstOrDefault(x=> x.DoktorId==id);
                return dr;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
