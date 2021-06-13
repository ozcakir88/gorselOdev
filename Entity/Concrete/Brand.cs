﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
   public class Brand:IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }
}