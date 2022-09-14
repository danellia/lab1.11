/*Вариант 5
Дана целочисленная квадратная матрица порядка 5. Найдите
максимальный элемент среди элементов, лежащих левее вспомогательной
диагонали, и максимальный элемент среди элементов, лежащих правее
вспомогательной диагонали, поменяйте их местами*/
namespace lab1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix();
            for (int i = 1; i <= Matrix.size; ++i)
            {
                for (int j = 1; j <= Matrix.size; ++j)
                {
                    object? current = null;
                    Console.WriteLine("Enter Matrix element[" + i + ", " + j + "]: ");
                    while (current == null)
                    {
                        try
                        {
                            current = Convert.ToInt32(Console.ReadLine());
                            m[i - 1, j - 1] = (int)current;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Try again!");
                            current = null;
                        }
                    }

                }
            }
            Console.WriteLine(m.ToString());
            Console.WriteLine("Max element from left: " + m.findMaxLeft());
            Console.WriteLine("Max element from right: " + m.findMaxRight());
        }
    }
}
