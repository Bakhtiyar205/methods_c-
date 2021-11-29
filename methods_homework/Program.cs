using System;

namespace methods_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Exercise
            Division();

            //Second Exercise
            OddCount();

            //Third Exercise
            OddSum();

            //Forth Exercise
            Complex();


            //Fifth Exercise
            int[] num = { 21, 22, 23, 24, 25, 4 };

            SumEven(num);

            
        }



        //First Exercise
        static void Division()
        {
            var n = 27;
            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("n is divided by 3 and 7");
            }
            else
            {
                Console.WriteLine("n is not divided  by 3 and 7");
            }
        }




        //Second Exercise
        static void OddCount()
        {
            var n = 2;
            var m = 9;
            var oddCount = 0;
            for (int i = n; i < m; i++)
            {
                if (i % 2 != 0)
                {
                    oddCount++;
                }


            }
            Console.WriteLine(oddCount);
        }



        //Third Exercise
        static void OddSum()
        {
            var n = 2;
            var m = 9;
            var oddSum = 0;
            for (int i = n; i < m; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum += i;
                }


            }
            Console.WriteLine(oddSum);
        }


        //Forth Exercise
        static void Complex()
        {
            var n = 29;
            var division = 0;
            var i = 1;
            while (i <= n)
            {

                if (n % i == 0)
                {
                    division++;
                }
                i++;
            }
            if (division > 2)
            {
                Console.WriteLine("Number is complex");
            }
            else
            {
                Console.WriteLine("Number is simple");
            }
        }



        //Fifth Exercise
        static void SumEven(int[] num)
        {
            int sum = 0;
            foreach (var item in num)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }

    }
}
