// Написать функцию Shuffle, которая перемешивает элементы массива в случайном порядке.


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string chislo = Console.ReadLine();
        int chislo1 = Convert.ToInt32(chislo);
        array[i] = chislo1;
    }
}
int [] array = new int[5];
FillArray(array);

Shuffle(array);
PrintArray(array);

 void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {   
        
        Console.Write(array1[i] + " ");
    }
    Console.WriteLine();
}





 static void Shuffle(int[] arr)
{
    // создаем экземпляр класса Random для генерирования случайных чисел
    Random rand = new Random();

    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = rand.Next(i + 1);

        int tmp = arr[j];
        arr[j] = arr[i];
        arr[i] = tmp;
    }
}