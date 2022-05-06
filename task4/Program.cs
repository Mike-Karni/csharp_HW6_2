void Insert (ref int[] array,int value,int index)
{
    int[] newArray = new int[array.Length+1];
    newArray[index] = value;
    for(int i =0;i<index;i++)
    {
        newArray[i] = array[i];
    }
    for(int i=index;i<array.Length;i++)
    {
        newArray[i+1] = array[i];
    }
    array=newArray;
}
 Console.WriteLine("Введите длину массива ");
 int Length = Convert.ToInt32(Console.ReadLine());
 int[] numbers = new int[Length];
Console.WriteLine("Введите число , которое хотите добавить в массив");
 string newNumber = Console.ReadLine();
 int addedNumber = Convert.ToInt32(newNumber);
Console.WriteLine("Введите на который хотите записать новое число");
int position = Convert.ToInt32(Console.ReadLine());

 FillArray(numbers);
 PrintArray(numbers);
Insert(ref numbers,addedNumber,position);
NewFillArray(numbers);
PrintArray(numbers);

  void NewFillArray(int[] array)
 {
    for (int i = 0; i < array.Length-1; i++)
    {
        array[i] = new Random().Next(100, 1000);
        array[position] = addedNumber;
     }
 }
 void FillArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
     }
 }


 void PrintArray(int[] array1)
 {
     for (int i = 0; i < array1.Length; i++)
     {
         Console.Write(array1[i] + " " );
     }
     Console.WriteLine();
 }