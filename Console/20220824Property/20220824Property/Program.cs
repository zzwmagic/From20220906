using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220824Property
{

    public class info
    {
        private string _AA = "hello";
        public string AA
        {
            get { return _AA; }
            set { _AA = value; }
        }
    }
    class Program
    {

       
        static void Main(string[] args)
        {
            info _info = new info();
            Console.WriteLine(_info.AA);
            Console.ReadKey();
        }
    }
}
