using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key] //key mutlaka olmak zorunda olmazsa hata verir
        public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }  //içeriğin metni
        public DateTime ContentDate { get; set; }




        //bu ikisini ben ekledim bakalım doğru mu--doğruymuş;)
        public int HeadingID { get; set; }
        public virtual Heading   Heading { get; set; }


        public int? WriterID { get; set; } //burası boş geçilebilir demek bu soru işareti
        public virtual Writer Writer { get; set; }

        //public ICollection <Writer> Writers { get; set; } ------bu iki kısım yokk
        //public ICollection <Heading> Headings { get; set; }


        //Contentyazarı 
        //content başlığı
    }
}
