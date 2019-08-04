using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ToDoListDapper.Model
{
   public  class CategoryRepository : IRepository<Category>, IDisposable
    {

        SqlConnection connection = null;
        
        public CategoryRepository()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["TodoList"].ConnectionString;
        }

        public int Create(Category obj)
        {
            int res =-1;
            string sql = "INSERT INTO Category(Name) VALUES (@Name)";
            try
            {
                res =connection.Execute(sql, obj);
            }
            catch (System.Data.SqlClient.SqlException ex)// 'Violation of UNIQUE KEY constraint 'UQ__Category__737584F6225B6638)
            {

                if (ex.Message == "Violation of UNIQUE KEY constraint 'UQ__Category__737584F6225B6638'. Cannot insert " +
                        "duplicate key in object 'dbo.Category'. The duplicate key value is (Active).\r\nThe statement has" +
                        " been terminated.")
                {
 
                   MessageBox.Show("Violation of UNIQUE KEY constraint 'UQ__Category__737584F6225B6638'. Cannot insert " +
                        "duplicate key in object 'dbo.Category'. The duplicate key value is (Active).\r\nThe statement has" +
                        " been terminated.");
                    return res;
                }
            }
            return res;
        }

        public int Delete(Category obj)
        {
            string sql = "DELETE FROM Category WHERE ID = @Id";
            return connection.Execute(sql, obj);
        }

        public void Dispose()
        {
            connection?.Dispose();
        }

        public IList<Category> GetAll()
        {
            string sql = "SELECT * FROM Category order by id";
            var category = connection.Query<Category>(sql).ToList();
            return category;
        }

        public Category GetById(int id)
        {
            string sql = "SELECT * FROM Category WHERE Id = @Id";
            Category category = connection.QueryFirstOrDefault<Category>(sql, new { Id = id });
            return category;
        }

    

        public int Update(Category obj)
        {
            string sql = "UPDATE Category SET Name = @Name  WHERE Id = @Id";
            return connection.Execute(sql, obj);
        }



        public Dictionary<int, Category> MultiTableQueryOneToMany()
        {
            var query = "SELECT * FROM Category JOIN Business ON Category.Id = Business.id_Category";

            var authors = new Dictionary<int, Category>();

            var result = connection.Query<Category, Business, Category>(
                query,
                (Category, Business) => {

                    Category authorEntry;

                    if (!authors.TryGetValue(Category.Id, out authorEntry))
                    {
                        authors.Add(Category.Id, Category);
                        Category.Business = new List<Business>();
                        authorEntry = Category;
                    }

                    authorEntry.Business.Add(Business);

                    return authorEntry;
                },
                splitOn: "Id"
                );


            foreach (var pair in authors)
            {
                var author = pair.Value;
                Console.WriteLine($"{author.Id}: {author.Name}");
                foreach (var busines in author.Business)
                {
                    Console.WriteLine($"\t{busines.Id} {busines.Name} {busines.Text}");
                }
            }
            return authors;
        }

    }
}
