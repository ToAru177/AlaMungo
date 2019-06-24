using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    public  class DB
    {
        public static CustomerData Customer { get; } = new CustomerData();
        public static EmployeeData Employee { get; } = new EmployeeData();
        public static MetaDataBookData MetaData { get; } = new MetaDataBookData();
        public static SellData Sell { get; } = new SellData();
        public static BuyData Buy { get; } = new BuyData();
        public static UsedBookData UsedBook { get; } = new UsedBookData();
    }
}
