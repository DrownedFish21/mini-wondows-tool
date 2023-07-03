using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Tool
{
    public static  class Define
    {
        public static bool isClose;
        public static bool isOpen;
        public static int OPENVOL_SIZE = 1300;
        public static int CLOSEVOL_SIZE = 1900;

        public struct FILES
        {
            public string ShowName;
            public string RailName;
        }
        //public static List<FILES> Files = new List<FILES>();
        public static Dictionary<string, string> Files = new();
        
    }
}
