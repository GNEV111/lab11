using System;

namespace Lab1
{
    // Структура для заданий 4 и 5
    public struct Student
    {
        public string Famil;
        public string Name;
        public string Facult;
        public int Nomzach;
    }

    class Program
    {
        // Задание 1: Разница между максимальным и минимальным элементами массива
        static void Task1()
        {
            Console.WriteLine("=== Задание 1: Разница между max и min элементами массива ===");

            int[] a = { 5, 2, 9, 1, 7, 3, 8, 4, 6, 0 };
            int min = a[0], max = a[0];

            for (int i = 1; i < 10; i++)
            {
                if (a[i] < min) min = a[i];
                if (a[i] > max) max = a[i];
            }

            Console.Write("Массив: ");
            foreach (int num in a) Console.Write(num + " ");
            Console.WriteLine($"\nMin = {min}, Max = {max}, Разница = {max - min}\n");
        }

        // Задание 2: Инициализация массива случайными числами
        static void Task2()
        {
            Console.WriteLine("=== Задание 2: Массив случайных чисел ===");

            Random rand = new Random();
            int[] a = new int[10];

            Console.Write("Случайные числа от 0 до 99: ");
            for (int i = 0; i < 10; i++)
            {
                a[i] = rand.Next(100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\n");
        }

        // Задание 3: Динамический массив произвольного размера
        static void Task3()
        {
            Console.WriteLine("=== Задание 3: Динамический массив ===");

            Console.Write("Введите размер массива: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] a = new int[n];
                Random rand = new Random();

                Console.Write($"Массив из {n} элементов: ");
                for (int i = 0; i < n; i++)
                {
                    a[i] = rand.Next(100);
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Некорректный ввод!\n");
            }
        }

        // Задание 4: Сумма значений в столбцах двумерного массива
        static void Task4()
        {
            Console.WriteLine("=== Задание 4: Сумма по столбцам матрицы ===");

            int[,] matrix = {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            Console.WriteLine("Матрица 3x4:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }

            Console.Write("Суммы по столбцам: ");
            for (int j = 0; j < 4; j++)
            {
                int sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    sum += matrix[i, j];
                }
                Console.Write(sum + " ");
            }
            Console.WriteLine("\n");
        }

        // Задание 5: Поиск студента по параметрам
        static void Task5()
        {
            Console.WriteLine("=== Задание 5: Поиск студента ===");

            Student[] stud = {
        new Student { Famil = "Иванов", Name = "Иван", Facult = "ИТ", Nomzach = 12345 },
        new Student { Famil = "Петров", Name = "Петр", Facult = "Физика", Nomzach = 23456 },
        new Student { Famil = "Сидоров", Name = "Алексей", Facult = "Математика", Nomzach = 34567 },
        new Student { Famil = "Сидорова", Name = "Анна", Facult = "Математика", Nomzach = 34568 },
        new Student { Famil = "Сидорович", Name = "Александр", Facult = "Математика", Nomzach = 34569 }
    };

            // Вывод всех студентов
            Console.WriteLine("Список студентов:");
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {stud[i].Famil} {stud[i].Name}, {stud[i].Facult}, №{stud[i].Nomzach}");
            }

            // Поиск по части фамилии
            Console.Write("\nВведите часть фамилии для поиска: ");
            string searchFamil = Console.ReadLine();

            bool found = false;
            Console.WriteLine("\nРезультаты поиска:");

            foreach (Student student in stud)
            {
                // Поиск по частичному соответствию (без учета регистра)
                if (student.Famil.IndexOf(searchFamil, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine($"- {student.Famil} {student.Name}, {student.Facult}, №{student.Nomzach}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Студенты с фамилией, содержащей '{searchFamil}', не найдены.");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Выполнение всех заданий
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}