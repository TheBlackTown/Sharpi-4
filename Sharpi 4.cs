using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_неявного_преобразования
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 i16 = 1;
            Int32 i32 = 1;
            double db = 1;

            i16 = 132;
            i16 = (short) db;
            i32 = i16;
            i32 = (int) db;
            db = 116;
            db = i32;
        }
    }
}
