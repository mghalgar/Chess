using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 8;
            var x = 3;
            var y = 4;
            var count = Calculate(x, y, n);
            Console.WriteLine(count);
        }

        /// <summary>
        /// محاسبه تعداد انتخاب های حرکت وزیر با فرض صفحه خالی از مهره
        /// </summary>
        /// <param name="x">موقعیت افقی</param>
        /// <param name="y">موقعیت عمودی</param>
        /// <param name="n">تعداد خانه ها در هر سطر</param>
        /// <returns></returns>
        static int Calculate(int x, int y, int n)
        {
            var c = (n - 1) * 3;
            var d = MinOfDistance(x, y, n);
            return c + d * 2;
        }

        static int MinOfDistance(int x, int y, int n)
        {
            var a = x < y ? x : y;
            return SideDistance(a, n);
        }

        static int SideDistance(int a, int n) => a > (n / 2) ? n - a : a - 1;
    }
}
