using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public static class ConnectionHelper
    {
        public static string ConnectionString
        {
            get
            {
                string db = Path.Combine(Path.GetFullPath(@"..\..\"), "book_db.mdf");
                return $@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename={db};Initial Catalog=book_db;Trusted_Connection=True";
            }
        }
    }
}
