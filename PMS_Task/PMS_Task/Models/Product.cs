using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS_Task.Models
{
	public class ProductModel
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Qty { get; set; }
        public int Cid { get; set; }
        public virtual CategoryModel Category { get; set; }
    }
}