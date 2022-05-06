// Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – первая добавляет к числовому массиву значение, 
// тем самым увеличивая массив, а вторая удаляет элемент под нужным индексом и уменьшает массив на 1.

// Написать функцию Shuffle, которая перемешивает элементы массива в случайном порядке.

//  int[] array = {1,2,3,4,5,6,7};
//  int length = array.Length;
//  Console.WriteLine("Введите число, которое вы хотите добавить к массиву");
//  string newNumber = Console.ReadLine();

//  for(int i = 0; i<length;i++)
//  {
//     Console.Write($" {array[i] } ");   
// }
// int endNumber = Convert.ToInt32(newNumber);
//  Console.WriteLine(" ");

//  int[] addedArray = {1,2,3,4,5,6,7,endNumber};
//  for(int i = 0; i<addedArray.Length;i++)
//  {
//    Console.Write($" {addedArray[i] } ");
    
//  }

 Console.WriteLine("Введите длину массива ");
 int Length = Convert.ToInt32(Console.ReadLine());
 int[] numbers = new int[Length];
 FillArray(numbers);
 PrintArray(numbers);
 Console.WriteLine("Введите число , которое хотите добавить в массив");
 string newNumber = Console.ReadLine();
 int addedNumber = Convert.ToInt32(newNumber);
//  PrintNewArray(numbers,newNumber);
AddedArray(numbers,addedNumber);
PrintArray(numbers);

void AddedArray(int[] array,int number)
{   
    for (int i = 2;i < array.Length;i++)
    {
        array[0]  = new Random().Next(100, 1000);
        array[i-1] = new Random().Next(100, 1000);
        array[i] = number;
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

//   void PrintNewArray(int[] array1,int newNumber)
//  {
//      Console.Write(newNumber +" ");
//      for (int i = 0; i < array1.Length; i++)
//      {
//          Console.Write(array1[i] + " " );
//      }
//      ;
//      Console.WriteLine();

//  }