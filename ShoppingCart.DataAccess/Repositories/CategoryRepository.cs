using ShoppingCart.DataAccess.Data;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Category category)
        {
            var categoryDB =_context.categories.FirstOrDefault(x => x.Id == x.Id); 
            if(categoryDB != null)
            {
                categoryDB.Name= category.Name;
                categoryDB.DisplayOrder = category.DisplayOrder;
            }
        }
    }
}
