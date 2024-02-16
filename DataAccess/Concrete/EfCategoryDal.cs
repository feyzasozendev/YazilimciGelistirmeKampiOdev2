using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryDal
    {
        List<Category> _category;

        public EfCategoryDal()
        {
            _category = new List<Category>
            {
                new Category{CategoryId=1, CategoryName = "Yazılım"},
                new Category{CategoryId=2, CategoryName="Network"},
                new Category{CategoryId=3, CategoryName="Siber Güvenlik"}
            };
        }
        public void Add(Category category)
        {
            _category.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _category.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            _category.Remove(categoryToDelete);
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(int id)
        {
            return _category;
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _category.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }
}
