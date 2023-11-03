// Напишите программу, которая принимает на вход одно число (А) и выдает сумму числе от 1 до А
// 7->28
// 4->10
// 8->36

//_тип_возвращаемого_значения_ _название функции_(_принимаемые_аргументы_)
//{
//   -тело_функции_
//    returne <> - это возврат значения
//}

//в C# методы и функции практически означает одно и тоже

int FinSum(int A)              //все фукции подсвечиваются желтым цветом
{
    int sum = 0;
for(int i = 1; i <= A; i++)

    sum += i;
     return sum;
}


// System.Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// int sum = 0;

// for(int i = 1; i <= number; i++)

//     sum += i; // sum = sum + 1

//     System.Console.WriteLine(sum);
