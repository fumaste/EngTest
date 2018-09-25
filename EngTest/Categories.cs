using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngTest
{
    public static class Categories
    {

        public static ItemCategory Books => new ItemCategory("books", 0);
        public static ItemCategory Foods => new ItemCategory("foods", 0);
        public static ItemCategory Medical => new ItemCategory("medical", 0);
        public static ItemCategory Beauty => new ItemCategory("beauty", 0.10);
        public static ItemCategory Multimedia => new ItemCategory("multimedia", 0.10);
        
    }
}
