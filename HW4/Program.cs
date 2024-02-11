internal class Program
{

    static bool NalogCalculate(decimal fullsum, decimal stavka, out decimal resultTax)
    {
        resultTax = fullsum * stavka / 100;
        if ( stavka >= 0 && stavka < 100 && fullsum >= 0 )
        return true;
        else return false;
    }



    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        bool correctEnter = false;
        {
            //Classwork
            /*
            //1
            {
                int per1 = 0, per2 = 0;
                Console.WriteLine("Введите переменные a и b: ");
                per1 = Convert.ToInt32(Console.ReadLine());
                per2 = Convert.ToInt32(Console.ReadLine());

                if ((per1 + per2) % 2 == 0 && (per1 + per2) % 5 == 0)
                {
                    Console.WriteLine("sum can be devided by 2 and 5");
                }
                else if ((per1 + per2) % 2 == 0)
                {
                    Console.WriteLine("sum can be devided by 2");
                }
                else if ((per1 + per2) % 5 == 0)
                {
                    Console.WriteLine("sum can be devided by 5");
                }
                else Console.WriteLine("sum can't be devided by 2 and 5");
                Console.WriteLine();
                Console.ReadKey();
            }

            //Classwork
            //2
            {
                int number = 0;
                Console.WriteLine("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0 && number <= 30) { Console.WriteLine("Промежуток 0-30"); }
                else if (number >= 31 && number <= 60) { Console.WriteLine("Промежуток 31-60"); }
                else if (number >= 61 && number <= 100) { Console.WriteLine("Промежуток 61-100"); }
                else Console.WriteLine("Don't know this number");
                Console.WriteLine();
                Console.ReadKey();
            }
            */

            //Homework

            /*  1.Найти все числа, большее 200 и меньше 500, которое нацело делится на 17. 
                Реализовать через цикл While(). На выходе мы должны получить строку, где числа разделены ‘,’ */
            {
                Console.WriteLine("Домашнее задание 1");
                Console.WriteLine("Числа в диапазоне 200 - 500, которые нацело делится на 17:");
                int firstNumber = 200, secondNumber = 500;
                string? output = "";
                while (firstNumber < secondNumber)
                {
                    if (firstNumber % 17 == 0) { output += (Convert.ToString(firstNumber) + ", "); }
                    firstNumber++;
                }
                Console.WriteLine(output.Substring(0, output.Length - 2));
                Console.WriteLine();
                //Console.ReadKey();
            }

            /*  2.Ввести с клавиатуры символ. Определить, необходимо ли нам переместить фигуру вверх, вниз, вправо,
                влево в зависимости от введенного символа(W, S, A, D).Вывести результат решения на экран. 
                В случае отсутствия необходимости перемещения вывести соответствующее сообщение.*/
            {
                Console.WriteLine("Домашнее задание 2");
                Console.WriteLine("Введите символ (W S A D) для перемещения: ");
                string? ch = Console.ReadLine();
                switch (ch)
                {
                    case "W": Console.WriteLine("Двигаемся вверх"); break;
                    case "S": Console.WriteLine("Двигаемся вниз"); break;
                    case "A": Console.WriteLine("Двигаемся влево"); break;
                    case "D": Console.WriteLine("Двигаемся вправо"); break;
                    case "w": Console.WriteLine("Двигаемся вверх"); break;
                    case "s": Console.WriteLine("Двигаемся вниз"); break;
                    case "a": Console.WriteLine("Двигаемся влево"); break;
                    case "d": Console.WriteLine("Двигаемся вправо"); break;
                    default: Console.WriteLine("Необходимость перемещения отсутствует"); break;
                }
                Console.WriteLine();
                Console.ReadKey();
            }

            /*  3.Создать массив целочисленных элементов. Циклом занести туда рандомные числа.
                Для генерации случайных чисел использовать класс Random и его метод Next.
                Реализовать перебор элементов массива int[] используя оператор goto */
            {
                Console.WriteLine("Домашнее задание 3");
                Console.WriteLine("Введите размер массива: ");
                string arraySize = "";
                int arraySizeInt = 0;
                arraySize = Console.ReadLine();
                while (!int.TryParse(arraySize, out int arraySizeResult))
                    {
                        Console.WriteLine("Некорректный ввод, повторите");
                        arraySize = Console.ReadLine();
                    }
                arraySizeInt = Convert.ToInt32(arraySize);
                int[] array1 = new int[arraySizeInt];
                int counter = 0;
                Random rand = new Random();

            Label:
                array1[counter] = rand.Next(-10000, 10000);
                Console.Write(array1[counter]+"  ");
                counter++;
                if (counter < arraySizeInt)
                    goto Label;
                Console.WriteLine('\n');
                Console.ReadKey();
            }

            /*  4. Написать функцию которая расчитывает налог на доход, необходимый для уплаты в конце месяца.Метод 
                Должен возвращать bool флаг о том что он смог сделать расчет, а результат ресчета возвращать через out параметр. 
                Решить какие типы данных будут использоваться и как будет возвращаться значение.*/
            {
                Console.WriteLine("Домашнее задание 4");
                string? input = "";
                decimal salary = 0, tax = 0;
                while (!correctEnter)
                {
                    Console.WriteLine("Введите доход: ");
                    input = Console.ReadLine();
                    if (decimal.TryParse(input, out decimal resultSalary))
                    {
                        salary = resultSalary;
                        correctEnter = true;
                    }
                    else Console.WriteLine("Некорректный ввод, повторите");
                }
                correctEnter = false;

                
                while (!correctEnter)
                {
                    Console.WriteLine("Введите ставку налога в процентах: ");
                    input = Console.ReadLine();
                    if (decimal.TryParse(input, out decimal resultTax))
                    {
                        tax = resultTax;
                        if (tax > 50) Console.WriteLine("Ничего себе ставка налога)))");
                        correctEnter = true;
                    }
                    else Console.WriteLine("Некорректный ввод, повторите");
                }
                correctEnter = false;
                if (NalogCalculate(salary, tax, out decimal resTax))
                    Console.WriteLine($"Нужно уплатить налог в размере {resTax} BYN");
                else Console.WriteLine("Расчет произвести не удалось");
                Console.ReadKey();
            }
        }
    }
}