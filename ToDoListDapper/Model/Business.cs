using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDapper.Model
{
    public class Business
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }
        public string State { get; set; }

        public int id_Category { get; set; }
        //  public string Category { get; set; }
        // public int selectedindex { get; set; }
        //List<string> statelist;

        //public Business()
        //{
        //    statelist = new List<string>() {"Active", "Done", "Expired" };
        //}
    }
}
