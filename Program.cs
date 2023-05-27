// //Task1________________________
int GetNumber (string instruction)
{
    Console.WriteLine(instruction);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
// int HowManyDigits (int number)
// {
//     int length = 1;
//     while (number > 9)
//         {
//             number = number / 10;
//             length++;
//         }
//     return length;
// }


// int number = GetNumber ("Введите пяти значное число");
// int digits = HowManyDigits (number);
// while (digits == 1)
// {
//     Console.WriteLine("Ничего не поделать с однозначныи числом");
//     number = GetNumber ("Введите пяти значное число, а не однозначное");
//     digits = HowManyDigits (number);
// }
// int [] array = new int [digits];
// int length = digits - 1;
// int ind = 0;
// int digit;
// while (length>ind)
// {
//     digit = number % 10;
//     array [length - ind] = digit;
//     number = number / 10;
//     ind++;
// }
// array [0] = number;
// ind = 0;
// int isTrue = 1; // 1 , это да. 0, это нет.
// while (array.Length / 2 != ind)
// {
//     if (array [ind] == array [array.Length - 1 - ind])
//     {
//         isTrue = 1;
//     }
//     else
//     {
//         isTrue = 0;
//         break;
//     }
//     ind++;
// }

// if (isTrue == 1)
// {
//     Console.WriteLine("Ваше число палиндром");
// }
// else
// {
//     Console.WriteLine("Ваше число не палиндром");
// }
// //_____________________________

// //2task________________________
// int x1 = GetNumber ("X координаты первой точки");
// int y1 = GetNumber ("Y координаты первой точки");
// int z1 = GetNumber ("Z координаты первой точки");

// int x2 = GetNumber ("X координаты второй точки");
// int y2 = GetNumber ("Y координаты второй точки");
// int z2 = GetNumber ("Z координаты второй точки");

// double hypotenuse = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
// double distance = Math.Sqrt(Math.Pow(hypotenuse, 2) + Math.Pow((z1 - z2), 2));
// distance = Math.Round(distance, 1, MidpointRounding.ToZero);
// Console.WriteLine ($"Дистанция между двумя точками в 3д равна {distance} единиц.");
// //_____________________________
