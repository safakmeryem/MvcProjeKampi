using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>(); // buradaki amacı anlamadım ??/???
        public List<Category> GetAllBL()
        {
            return repo.Listele();
        }

        public void CategoryAddBL( Category p)
        {
            if (p.CategoryName == "" || p.CategoryDescription == "" || p.CategoryName.Length <= 3 || p.CategoryName.Length >= 51)
            {
                //hata mesajı versin....
            }
            else
            {
                repo.Insert(p);
            }

            
        }




    }
}
