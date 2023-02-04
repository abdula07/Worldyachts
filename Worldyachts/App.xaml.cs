using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Worldyachts
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Models.user14Entities1 Db;


        public static Models.user14Entities1 getDb()
        {
            if (Db == null)
                Db = new Models.user14Entities1();
            return Db;
        }
    }
    
       
}
