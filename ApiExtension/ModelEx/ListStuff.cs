using ApiExtensionAmazon.ModelEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExtension.ModelEx
{
    public static class ListStuff
    {
        public static List<Stuff> listAll()
        {
            List<Stuff> lstStuffs = new List<Stuff> {
                new Stuff{Id=1,Name="Adidas",Url="adidas.com"},
                new Stuff{Id=2,Name="Rakuten",Url="rakuten.co.jp"},
                new Stuff{Id=3,Name="Nike",Url="nike.com"},
                new Stuff{Id=4,Name="Yahoo! Shopping",Url="shopping.yahoo.co.jp"},
                new Stuff{Id=5,Name="Ebay",Url="ebay.com/"},
                new Stuff{Id=6,Name="Adidas Jp",Url="shop.adidas.jp"},
                new Stuff{Id=7,Name="Adidas",Url="adidas.com"},
                new Stuff{Id=8,Name="Rakuten",Url="rakuten.co.jp"},
                new Stuff{Id=9,Name="Nike",Url="nike.com"},
                new Stuff{Id=10,Name="Yahoo! Shopping",Url="shopping.yahoo.co.jp"},
                new Stuff{Id=11,Name="Ebay",Url="ebay.com/"},
                new Stuff{Id=12,Name="Adidas Jp",Url="shop.adidas.jp"}
            };
            return lstStuffs;
        }
    
    }
}
