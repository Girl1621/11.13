
//напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
//3 -> 11
//2 -> 10
// string result = ConvertDecToBinary(4); //вызвали метод
// Console.WriteLine(result); //вывели на экран
// string ConvertDecToBinary(int number) //объявили метод
// {
//     string tmp = "";
//     while (number > 0)
//     {
//         int remainder = number % 2;
//         number /= 2;
//         tmp = remainder.ToString() + tmp;
        
//     }
//     return tmp; //вернули результат

// }

// Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.


string [] array = new string [3] {"ing","jkl", "j"};
PrintArray(array);
string [] copy = Copy (array);

string[] Copy(string[] array)
{
    string[] copied = new string[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        copied[i] = array[i];
    }

    return copied;
}
void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}