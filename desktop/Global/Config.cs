using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using desktop.Models;

namespace desktop.Global
{
    public class Config
    {
        //Api
        public static string apiBaseUrl = "http://localhost:5235/api/";

        public static Imovel tempImovel = new Imovel();
        public static bool edit = false;
        public static Operation operation = new Operation();
        
    }

    public enum Operation
    {
        Add = 1,
        Edit = 2
    }
}
