/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


int[] InArray()
{
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] MyArray = new int[size];
return MyArray;
}

int[] ElementsPoint(int[] MyArray)
{
    for(int index = 0; index < MyArray.Length; index++)
    {
        Console.WriteLine($"Введите элемент массива с индексом {index}: ");
        MyArray[index] = int.Parse(Console.ReadLine()!);
    }
    return MyArray;
}

int Proverka(int[] MyArray)
{
    int count = 0;
    for(int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] > 0) count++;
    }
    return count;
}

void Main()
{
int [] MyArray = InArray();
MyArray = ElementsPoint(MyArray);
int count = Proverka(MyArray);
Console.WriteLine($"{String.Join(" ", MyArray)} -> {count}");
}

Main();