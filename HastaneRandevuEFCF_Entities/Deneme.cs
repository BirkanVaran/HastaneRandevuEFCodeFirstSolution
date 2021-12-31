using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuEFCF_Entities
{
   public class Deneme
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }
        public int DoktorId { get; set; }
        public int HastaId { get; set; }
        public DateTime RandevuTarihi { get; set; }

        //İlişki 
        public virtual Doktor Doktor { get; set; }

        public virtual Hasta Hasta { get; set; }
    }
}
