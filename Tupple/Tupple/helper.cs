using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupple
{
    public class helper
    {
        public void Run()
        {
            Tuple<int, string> tuple1 = Test1();

            (int x, string y) tuple2 = Test2(5, "s", DateTime.MinValue);
            int x1 = tuple2.x;
            string y1 = tuple2.y;

            int ee = 0;
            (ee, _) = Test2(5, "s", DateTime.MinValue);

            Test3(1, 2, 6, 9);
        }

        public Tuple<int, string> Test1()
        {
            return Tuple.Create<int, string>(5, "salam");
        }

        public (int x, string y) Test2(int a, string b, DateTime c)
        {
            a++;
            b = "sssss";
            c = DateTime.Now;

            return (a, b);
        }

        /*public void Test3((int a, string b, User user) Tuple)
        {
            
        }*/

        Tuple<double, int> tuple = new Tuple<double, int>(1.2, 5);
        (int d, int e) tuple2 = new(6, 8);

        public void Test3(int a, params int[] b)
        {

        }
    }
}
