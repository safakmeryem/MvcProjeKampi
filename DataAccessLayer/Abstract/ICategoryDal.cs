using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        //Şimdi bu alttaki satırların hepsini yorum satırına alıcam
        //Bu metotları IRepository de tanımlıycam 
        //    Tek tek entitylerin içerisinde tanımlamak yerine IRepository den miras alıcam
        
        //----------------------------
        ////Crud operasyonlarını metot olarak yazıcam // metot yazılırken --Type Name(); //
        
        //List<Category> Listele ();
        //void Insert(Category p );
        //void Update(Category p );
        //void Delete(Category p );        // şimdi gidip bir sınıf oluşturup burada yazdığım metotların görevlerini orada tanımlamam gerekiyor
        //----------------------
        
    }
}


