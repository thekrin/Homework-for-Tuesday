using System;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Homework_for_Tuesday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmis ededi 10 vahid artiran metod
            //int number = 11;
            //AddTen(ref number);
            //Console.WriteLine(number);

            //Gonderilmis deyer menfidirse 0, 100-den coxdursa 100 eden metod.
            //0-100 araligindadirsa oldugu kimi qalsin
            //int point = -13;
            //WritePoint(ref point);
            //Console.WriteLine(point);

            //Verilmis ededler siyahisini yalniz cut deyerler qalan yeni bir arraye-e ceviren metod
            //int[] numbers = { 11, 12, 4, 5, 6, 7, 22 };
            //MakeEven(ref numbers);
            //Console.WriteLine("Even numbers :");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] array = { -21, -34, 11, 13, 777, -99 };
            //MakePositive(ref array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}



            //string str = "Krin";
            //str = str.ToUpper();
            //Console.WriteLine(str);

            //string str2 = "KRIn";
            //str2 = str2.ToLower();
            //Console.WriteLine(str2);

            //int[] numbers = { 21, 23, 43, 45, 77 };
            //var Index = Array.IndexOf(numbers,77);
            //Console.WriteLine(Index);

            //int[] numbers2 = { 11, 12, 13, 14, };
            //var Index2 = Array.LastIndexOf(numbers2, 13);
            //Console.WriteLine(Index2);

            #region Task1
            //Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod
            int[] array = { 22, 33, 44, 55, 66 };
            int newnumber = 77;
            AddDigit(ref array,newnumber);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            #endregion
        }

        //static void AddTen(ref int numb)
        //{
        //    numb += 10;

        //}

        //static void WritePoint(ref int point)
        //{
        //    if (point < 0)
        //    {
        //        point = 0;
        //    }
        //    else if (point > 100)
        //    {
        //        point = 100;
        //    }
        //}

        //static void MakeEven(ref int[] digits)
        //{
        //    int count = 0;
        //    for (int i = 0; i < digits.Length; i++)
        //    {
        //        if (digits[i] % 2 == 0)              
        //            count++;

        //    }
        //    int[] newnumbers = new int[count];
        //    int e = 0;
        //    for (int i = 0; i < digits.Length; i++)
        //    {
        //        if (digits[i] % 2 == 0)
        //        {
        //            newnumbers[e] = digits[i];
        //            e++;
        //        }                 
        //    }
        //    digits = newnumbers;
        //}


        //static void MakePositive(ref int[] numbers)
        //{
        //    int count = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] > 0)
        //            count++;
        //    }
        //    int[] newarray = new int[count];
        //    int e = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] > 0)
        //        {
        //            newarray[e] = numbers[i];
        //            e++;
        //        }
        //    }
        //    numbers = newarray;
        //}

        #region Task1
        static void AddDigit(ref int[]array ,int newnumber)
        {
            int[] newarr= new int[array.Length + 1];
            int e= 0;
            for (int i = 0; i < array.Length; i++)
            {
                newarr[e] = array[i];
                e++;
            }
            array = newarr;
            newarr[newarr.Length - 1] = newnumber;
        }
        #endregion




    }
}
