using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
 

    public interface Iset
    {
        void print();
    }
    public class servic : Iset
    {
        public void print()
        {
            Console.WriteLine("print........");
        }
    }
    public class client
    {
        private Iset _set;
        public void run(Iset serv)
        {
            this._set = serv;
            Console.WriteLine("start");
            this._set.print();
        }
    }
    class MethodInjection
    {
        public static void Main()
        {
            client cn = new client();
            cn.run(new servic());
            Console.ReadKey();
        }
    }
}
