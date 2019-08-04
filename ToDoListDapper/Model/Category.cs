using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListDapper.Model;

namespace ToDoListDapper
{
   public  class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Business> Business { get; set; }

        public Category()
        {
            Business = new List<Business>();
        }
    }
}
