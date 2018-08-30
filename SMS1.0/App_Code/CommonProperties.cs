using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS1._0.App_Code
{
    public class CommonProperties
    {
        public string surname { get; set; }
        public string othernames { get; set; }
        public string gender { get; set; }
        public DateTime DOB { get; set; }
        public string photo { get; set; }
        public string phone { get; set; }
        public string nationality { get; set; }
        public string religion { get; set; }
        public string state { get; set; }

        public string CS = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|schoolManagementSystem.mdf; Integrated Security=True";
    }
}