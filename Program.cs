using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practic_try_catch
{
    class Program
    {
        const int five = 5;
        const int ten = 10;
        static int amount = 0;
        static void Main(string[] args)
        {
            int[] array = new int[five];
            bool isParse;

            WriteLine("Здраствуйте, введите 5 цифр: \n");
            for (int i = 0; i < five; i++)
            {
                isParse = int.TryParse(ReadLine(), out array[i]);
            }

            CheckProblem(array);

            ReadKey();
        }

        private static void CheckProblem(int[] array)
        {
            try
            {
                for (int i = 0; i < ten; i++)
                {
                    amount = amount + array[i];
                }
            }
            catch (IndexOutOfRangeException indexOutOfRangeException)
            {
                WriteLine(indexOutOfRangeException);
            }
            catch (ArithmeticException arithmeticException)
            {
                WriteLine(arithmeticException);
            }
            finally
            {
                WriteLine("\n Завершение обработки массива");
            }
        }
    }
}