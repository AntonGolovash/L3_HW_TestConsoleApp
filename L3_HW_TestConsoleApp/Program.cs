using MyLibClass.L051;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_HW_TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyProduct myProduct = new MyProduct();
            MyClient client = new MyClient();
            MyOrder order = new MyOrder();
            MyOrdersPosition myOrdersPosition = new MyOrdersPosition();
            MyAccount myAccount = new MyAccount();
        }
    }
}
