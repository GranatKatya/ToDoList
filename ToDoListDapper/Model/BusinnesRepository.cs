using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDapper.Model
{
  public  class BusinnesRepository : IRepository<Business>, IDisposable
    {
        SqlConnection connection = null;

        public BusinnesRepository()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["TodoList"].ConnectionString;
          
        }

        public int Create(Business obj)
        {
            string sql = "INSERT INTO Business(Name, Text, StartDate, Deadline, State, id_Category) VALUES (@Name, @Text, @StartDate, @Deadline, @State, @id_Category)";
            return connection.Execute(sql, obj);
        }

        public int Delete(Business obj)
        {
            string sql = "DELETE FROM Business WHERE ID = @Id";
            return connection.Execute(sql, obj);
        }

        public void Dispose()
        {
            connection?.Dispose();
        }

        public IList<Business> GetAll()
        {
            string sql = "SELECT * FROM Business order by startdate , state";
            var authors = connection.Query<Business>(sql).ToList();
            return authors;
        }
        public IList<Business> GetAllBusinessByDeadline(DateTime dateTime)
        {
            string sql = "SELECT * FROM Business where Deadline =@Deadline";
            var authors = connection.Query<Business>(sql, new { Deadline = dateTime }).ToList();
            return authors;
        }


        public Business GetById(int id)
        {
            string sql = "SELECT * FROM Business WHERE Id = @Id";
            Business author = connection.QueryFirstOrDefault<Business>(sql, new { Id = id });
            return author;
        }


        public Business GetByName(string name)
        {
            string sql = "SELECT * FROM Business WHERE Name = @Name";
            Business category = connection.QueryFirstOrDefault<Business>(sql, new { Name = name });
            return category;

        }


        public int Update(Business obj)
        {
            string sql = "UPDATE Business SET Name = @Name, Text = @Text, StartDate=@StartDate, Deadline=@Deadline, State=@State, id_Category=@id_Category WHERE Id = @Id";
            return connection.Execute(sql, obj);
        }
    }




    public static class StatusRow
    {
       public static string Title = "AddCategory";
    }


}
