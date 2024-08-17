﻿using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
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
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        
        public void Update(Company Obj)
        {
            _db.Companies.Update(Obj);
        }
    }
}
