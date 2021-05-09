using System; // Павлов. Д. 3) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
namespace ArrayClass
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
        //  Заполнение массивa числами от начального значения с заданным шагом.
        public MyArray(int n, int min, int max) // n- длинна массива, min-начало, max-шаг
        {
            a = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                a[i] = min + (max * i);
            }
        }
        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= -1;
            }
        }
        public int Sum()// возвращает сумму элементов массива
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return s;
        }
        public void Multi(int mlt)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= mlt;
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
            MyArray a = new MyArray(10, 5, 2);
            Console.WriteLine("Массив");
            Console.WriteLine(a.ToString());
            Console.WriteLine("Сумма чисел в массиве: " + a.Sum());
            a.Inverse();
            Console.WriteLine("Инверcия массивa:");
            Console.WriteLine(a.ToString());
            a.Multi(5);
            Console.WriteLine($"Умножение инвертированного массива на 5: {a}");
        }
    }
}