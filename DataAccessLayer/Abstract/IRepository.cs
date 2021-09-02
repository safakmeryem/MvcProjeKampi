using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //T yerine bizim gönderdiğimiz entity gelecek, örnek category gibi
                                     //buradaki T sen sqlden hangi entity i gönderirsen onu karşılıyor...
    {

            //Crud operasyonlarını metot olarak yazıcam // metot yazılırken --Type Name(); //

            List<T > Listele();     //buradaki T entity sınıfı- Category olabilir, Writer olabilir  
            void Insert(T p);
            void Update(T p);
            void Delete(T p);

        List<T> Listele(Expression<Func<T, bool>> filter);   //şartlı listeleme
        }
}
