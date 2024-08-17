using Bulky.DataAccess.Repository.IRepository;
using BulkyApp.DataAccess.Data;
using BulkyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        
        public void Update(Category Obj)
        {
            _db.Categories.Update(Obj);
        }
    }
}
