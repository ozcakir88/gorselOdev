﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
   public class Category:IEntity
    {
        public int Id { get; set; }
        public string  CategoryName { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean Active { get; set; }


    }
}
