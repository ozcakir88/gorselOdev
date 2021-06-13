﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
   public class OrderDetail:IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public int Count { get; set; }
        public int SalePrice { get; set; }
        public DateTime  CreateDate { get; set; }

        public bool Active { get; set; }

    }
}
