using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace UpravlenieResursamiMnogoprocessornihSystemAlgLPT
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n, q;
            Console.WriteLine("Введите количество общих заданий на все процессоры");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество идентичных процессоров");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите время в тактах уделяемое каждой задаче");
            q = int.Parse(Console.ReadLine());

            Stopwatch st = new Stopwatch();
            st.Start(); // запускает временной счетчик
            List<int> p = new List<int>(); //массив процессоров
            for (int i = 0; i < k; i++) p.Add(0);
            int[] works = new int[n]; //массив заданий
            for (int i = 0; i < k; i++) works[i] = new Random().Next(1, n); //массив процессоров, где между всеми процессорами делятся все задания с рандомным уровнем сложности
            Array.Sort(works);
            Array.Reverse(works); // перестановка элементов сортированного массива по убыванию уровня сложности
            Queue<int> pack = new Queue<int>(); //отсортированная очередь заданий
            foreach (int work in works) pack.Enqueue(work);
            int ticks = 0; //количество тактов
            do
            {
                for (int i = 0; i < p.Count(); i++) //перебирает все процессоры
                {
                    p[i] -= q;
                    if (p[i] <= 0) //если задача выполнена, берёт следующую
                    {
                        if (pack.Count > 0) p[i] = pack.Dequeue(); // сверяет оставшиеся задачи и переносит выполненую задачу в конец списка  
                    }
                    ticks++;
                }
            }
            while (CheckProcessors(p)); // проверяет все ли процессоры выполнили всю работу
            st.Stop(); // останавливает временной счетчик
            Console.WriteLine("\nДлина оптимального расписания час:минута.секунда.милисекунда.микросекунда {00:00.00.00.0}", st.Elapsed.ToString());
            Console.WriteLine("такты={0}", ticks);
            Console.ReadKey();
        }

        static bool CheckProcessors(List<int> processors)
        {
            foreach (int proc in processors) if (proc > 0) return true; //если хотя бы один процессор занят, то продолжает цикл
            return false;
        }

    }
}
