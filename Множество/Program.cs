using System; // Павлов Д. 1) Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
namespace ArrayClassаа
{
    class MyArray
    {
        int[] a;
        //  Создание массива и заполнение его одним значением el
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max) // n- длинна массива
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        //Метод подсчета пар чисел, которые делятся на 3
        public int Pair
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] % 3 == 0 | a[i + 1] % 3 == 0)
                        count++;
                }
                return count;
            }
        }
        public override string ToString() //Метод вывода массива на консоль
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(20, -10000, 10000);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Pair);
        }
    }
}
