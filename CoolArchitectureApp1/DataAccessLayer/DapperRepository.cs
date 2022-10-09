using Dapper;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DapperRepository<T> : IRepository<T> where T : class, IDomainObject
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbConnection;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        IDbConnection db = new SqlConnection(connectionString);
        public void Create(T t)
        {
            var sql = "INSERT INTO Students (Name, [Group], Speciality) VALUES (@Name, @Group, @Speciality); SELECT CAST(SCOPE_IDENTITY() as int)";
            int Id = db.Query<int>(sql, t).FirstOrDefault();
            t.Id = Id;
        }

        public void DeleteById(int id)
        {
            var sql = "DELETE FROM Students WHERE Id = @Id";
            db.Query<int>(sql, new { Id = id }).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return db.Query<T>("SELECT * FROM Students").ToList();
        }

        public void Save()
        {
        }
    }
}
