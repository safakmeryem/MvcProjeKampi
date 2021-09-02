using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context: DbContext    // DbContext sınıfına ait özellikler Context sınıfına da eklensin istiyorum
    {
        public DbSet<About> Abouts { get; set; } //BURADA entity katmanıdaki sınıflarınımızı tek tek yazıcaz
        public DbSet<Category> Categories { get; set; } //Başka bir katmanda olduğun için bunlar bunları
        public DbSet<Contact> Contacts{ get; set; }   ///-----REFERANS OLARAK EKLEYECEKSİNN
        public DbSet<Content> Contents { get; set; }  //Referansları eklemek için Dataaccess içindeki referana add referanns ile
        public DbSet<Heading>Headings{ get; set; } //EntityLayer katmanını ekleyelim
        public DbSet<Writer> Writers{ get; set; }    
        }
    }
//sonuna s takisi alınmış hali bizim sql de veritabanımıza yansıyacak tablonun ismi, ikisi birbirine karışmasın diye
//biri about birisi abouts olmuş  -------- BİRİSİ sınıfın ismi, birisi Sqldeki tablonun ismi


//Burada DbSet türündeki propertyleri , sql e birer tablo olarak tanımlayacak