using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibClass.L051
{
    public class MyOrder
    {
        string Description;
        string OrdersDate;
        double TotalCost;
        MyOrdersPosition[] MyOrdersPositions;
        MyClient Client;
    }
}
