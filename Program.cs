using System.Threading.Channels;

namespace LessonsMassive
{
    internal class Program
    {

        static void Recursion (int i)
        {
            if (i < 10000)
            {
            i++;
            Recursion(i);
            }

        }

        static void ShowArray(int limitArrayNumber, int[] rndArray)
        {
            for (int i = 0; i < limitArrayNumber; i++)
            {
                Console.Write(rndArray[i] + " ");
            }  
            
            
        }


        static void Main(string[] args)
        {

            /*

            for (int i = 0; i <= 10000; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Loop Complited");
        Recursion(0);
        Console.WriteLine("Loop Complited");


            */

            /*

            int[] array = new int[10];


            array[0] = 10;
            Console.WriteLine(array[0]);

            array[9] = 80;
            Console.WriteLine(array[9]);

        int index = 2;
        array[index] = 20;
        //array[0]
        // .....    |....|....|....|....|....|....|....|....|....|
        // 1.    2.   3. 

        //Console.WriteLine(array);

            Random rnd = new Random();

            //Записываем в каждую ячейку массива случайное число

            for (int i = 0; i <= 9; i++)
            {
                array[i] = rnd.Next(100);
            }
        
            //

            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }

            */


            //9 1 12 67 45 23 15

            int limitRndNumber = 100; // верхний предел лимита генератора псевдослучайных чисел
            int seedRndNumber = 100; // число seed
            int limitArrayNumber = 10; // лимит колличество элементов в инициализаторе массива
            int minArrayNumber = limitRndNumber; // минимальное число массива 
            int minArrayNumberIndex = 0; // индекс минимального элемента в массиве
            int arrayBufferNumber;
            
            int[] rndArray = new int[limitArrayNumber];

            Random rndNumber = new Random(seedRndNumber);

            for (int i = 0; i < limitArrayNumber; i++)
            {
                rndArray[i] = rndNumber.Next(limitRndNumber);
                Console.Write(rndArray[i] + " ");
            }

            Console.WriteLine("\n");

            //96 15 66 90 35 94 71 61 34 14

            for (int i = 0; i < limitArrayNumber; i++) // находим минимальное число в массиве
            {
                if (rndArray[i] < minArrayNumber)
                {
                    minArrayNumber = (rndArray[i]);
                    minArrayNumberIndex = i;
                }
            }

            //arrayBufferNumber = minArrayNumber; // записываем значение буфферной переменной равное значению переменной минимального числа

            if (minArrayNumber != rndArray[0]) // если минимальное число не является первым в массиве - выполняется смена местами нулевого индекса массива и индекса значения элемента массива с минимальным числом массива
            {
                arrayBufferNumber = rndArray[minArrayNumberIndex];
                rndArray[minArrayNumberIndex] = rndArray[0];
                rndArray[0] = minArrayNumber;
            }

            ShowArray(limitArrayNumber, rndArray); 

        }

    }
}