using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class About
    {
        [Key] ///attributes ekliyorum.burada tanımlıyorum daha doğrusu..
        //ki projemde çok fazla yer tutmasın.mesela 100 karakter kadar yer tutsun vs diyorum.
        //burada bunu eklemek yerine entity framework paketi ekliyorum projeme
        public int AboutID { get; set; }
        [StringLength(1000)]
        public string AboutDetails { get; set; }
        [StringLength(1000)]
  
        public string AboutDetails2 { get; set; }
        [StringLength(100)]
        public string AboutImage1 { get; set; }
        [StringLength(100)]
        public string AboutImage2 { get; set; }
    }
}
