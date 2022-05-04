/*Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. 
Программа заканчивает свою работу в тот момент, когда решит пользователь.*/
/*1. запросить введите валюту*/

// Портфель
Console.WriteLine("Введите  ваш баланс валют");
Console.Write("Баланс евро ");
double balanceEvro = Convert.ToDouble(Console.ReadLine());
Console.Write("Баланс  доллар ");
double balanceUsd = Convert.ToDouble(Console.ReadLine());
Console.Write("белорусский рубль ");
double balanceBelRub = Convert.ToDouble(Console.ReadLine());

//Вывод баланс
Console.WriteLine($"Ваш баланс валют : \n{balanceEvro} евро. \n{balanceUsd} USD. \n{balanceBelRub} руб");
Console.WriteLine("Какую валюту из вашего баланса вы хотите поменять?");
string wantToChange = Console.ReadLine();

while (wantToChange != "евро" && wantToChange != "доллар" && wantToChange != "белорусский рубль")
{
    Console.WriteLine("Введите правильное название валюты:евро / доллар / белорусский рубль");
    wantToChange = Console.ReadLine();
}

Console.WriteLine($"На какую валюту  вы хотите поменять {wantToChange} ?");
string changeCurrency = Console.ReadLine();

while (changeCurrency != "евро" && changeCurrency != "доллар" && changeCurrency != "белорусский рубль")
{
    Console.WriteLine("Введите правильное название валюты:евро / доллар / белорусский рубль");
    changeCurrency = Console.ReadLine();
}

//ЦИКЛИМ ОБМЕННУЮ КАНИТЕЛЬ евро/бакс
Console.WriteLine("Вы хотите продожить обмен? Введите  да или нет");
string answer = Console.ReadLine();
while (answer == "да")
{
    Console.WriteLine("Какую валюту из вашего баланса вы хотите поменять?");
    wantToChange = Console.ReadLine();
     Console.WriteLine("Какое количество евро вы хотите обменять?");
    double countchangeEvro = Convert.ToDouble(Console.ReadLine());
    if (wantToChange == "евро" &&  countchangeEvro <= balanceEvro && answer == "да" && changeCurrency == "доллар")
    {
        Console.WriteLine("Какое количество евро вы хотите обменять?");
        double countchangeEvro = Convert.ToDouble(Console.ReadLine());
        
        if (countchangeEvro <= balanceEvro && answer == "да" && changeCurrency == "доллар")
        {
            balanceUsd = balanceUsd + countchangeEvro * 1.05;
            balanceEvro = balanceEvro - countchangeEvro;
            Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
            Console.WriteLine("Вы хотите продожить обмен? Введите  да или нет");
            answer = Console.ReadLine();
        }
       
      
        {
            Console.WriteLine("Недостаточно евро на балансе!!!");
        }
    }
   
}







/*while (true)
{
    Console.WriteLine("Вы хотите продолжить обмен валют?");
    string answer = Console.ReadLine();
    if (answer == "да")
    {

    }
    else
    {
        break;
    }*/






//Console.WriteLine($"На какую валюту вы хотите поменять {currency}");
/*
if (currency == "евро")
{
    Console.WriteLine("Введите ваш баланс в евро");
    double balanceEvro = Convert.ToDouble(Console.ReadLine());
    double Rurbalance = balanceEvro * 74.56;
    Console.WriteLine($"Ваш баланс после обмена {Rurbalance} российских рублей");

}
else if (currency == "доллар")
{
    Console.WriteLine("Введите ваш баланс в долларах");
    double balanceUsd = Convert.ToDouble(Console.ReadLine());
    double Rurbalance = balanceUsd * 71.02;
    Console.WriteLine($"Ваш баланс после обмена {Rurbalance} российских рублей");

}
else if (currency == "белорусский рубль")
{
    Console.WriteLine("Введите ваш баланс в белорусских рублях");
    double balanceBelRub = Convert.ToDouble(Console.ReadLine());
    double Rurbalance = balanceBelRub * 26.77;
    Console.WriteLine($"Ваш баланс после обмена {Rurbalance} российских рублей");

}*/

