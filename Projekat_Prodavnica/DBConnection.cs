using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat_Prodavnica
{
    internal class DBConnection
    {
        public string MyConection()
        {
            string con = "Data Source = DESKTOP-MDQ23VJ; Initial Catalog = Prodavnica; Integrated Security = True";
            return con;
        }
    }
}
