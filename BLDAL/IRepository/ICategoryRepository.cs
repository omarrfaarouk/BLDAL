using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLDAL.DTO;

namespace BLDAL.IRepository
{
    internal class ICategoryRepository
    {
        public interface ICategoriesRepository
        {
            bool Categories_Delete(Categories CategoriesLine);
            bool Categories_Insert(Categories CategoriesLine);
            Categories Categories_Select(Categories _CategoriesLine);
            List<Categories> Categories_SelectList();
            bool Categories_Update(Categories CategoriesLine);
        }
    }
}
