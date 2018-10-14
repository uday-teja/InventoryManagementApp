using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using InventoryManagement.Model.Models;
using SQLite;

namespace InventoryManagement.Data
{
    public class SQLiteService
    {
        public string FileName;

        public SQLiteService(string name)
        {
            FileName = name;
            var databasePath = Path.Combine(Environment.CurrentDirectory, FileName);
            var db = new SQLiteConnection(databasePath);
            db.CreateTable<Company>();
        }

        public void AddCompany(Company company)
        {
            using (var db = new SQLiteConnection(FileName))
            {
                db.Insert(company);
            }
        }
    }
}