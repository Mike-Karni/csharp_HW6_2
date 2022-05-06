void Insert(ref int[] array, int value, int index)
{
    int[] newArray = new int[array.Length + 1];
    newArray[index] = value;
    for (int i = 0; i < index; i++)
    {
        newArray[i] = array[i];
    }
    for (int i = index; i < array.Length; i++)
    {
        newArray[i + 1] = array[i];
    }
    array = newArray;
}
Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Length];
Console.WriteLine("Введите число , которое хотите добавить в массив");
string newNumber = Console.ReadLine();
int addedNumber = Convert.ToInt32(newNumber);
Console.WriteLine("Введите  индекс на который хотите записать новое число");
int position = Convert.ToInt32(Console.ReadLine());
if(position>=0 && position<Length)
{
Console.WriteLine("Заполните исходный массив");
FillArray(numbers);
Console.WriteLine("Исходный массив : ");
PrintArray(numbers);
Insert(ref numbers, addedNumber, position);
Console.WriteLine("Изменённый массив");
PrintArray(numbers);
}
else
{
    Console.WriteLine("Вы ввели недопустимый индекс, на который хотите записать число.");
}


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string chislo = Console.ReadLine();
        int chislo1 = Convert.ToInt32(chislo);
        array[i] = chislo1;
    }
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
    }
    Console.WriteLine();
}