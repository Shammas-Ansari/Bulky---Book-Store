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
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        
        public void Update(OrderDetail Obj)
        {
            _db.OrderDetails.Update(Obj);
        }
    }
}
