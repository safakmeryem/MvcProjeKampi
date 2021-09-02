using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class

    {

        Context c = new Context();
        DbSet<T> _object;   //buradaki _object bizim aslında T değerine karşılık gelen sınıfımızı tutuyor
        public GenericRepository()     //yapıcı metot oluşturulan sınıfın ismiyle aynı isimde olur
        {
            _object = c.Set<T>();  //T değerine karşı gelen değeri burada buluyorum..
                                   // yukarıda tanımladığım _obj e değer ataması yapıyorum. dışardan gönderilen T değeri

        }
        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> Listele()
        {
           return  _object.ToList(); //listeyi bana geri döndür dedim
            
        }

        public List<T> Listele(Expression<Func<T, bool>> filter) //burası şartlı listeleme işlemi
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
