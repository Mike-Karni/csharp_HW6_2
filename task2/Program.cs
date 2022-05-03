/*Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. 
Программа заканчивает свою работу в тот момент, когда решит пользователь.*/
/*1. запросить введите валюту
$ /евро/ Бел.Рубли
показать курс обмена.*/
/*Console.WriteLine("Введите валюту , которую вы ходите обменять на российские рубли: евро, доллар,белорусский рубль");
string currency = Console.ReadLine();
Console.WriteLine("курс евро/российский рубль = 74,56");
Console.WriteLine("курс доллар/российский рубль = 71,02");
Console.WriteLine("курс белорусский рубль/российский рубль = 26,77");*/

Console.WriteLine("Введите  ваш баланс валют");
Console.Write("Баланс евро ");
double balanceEvro = Convert.ToDouble(Console.ReadLine());
Console.Write("Баланс  доллар ");
double balanceUsd = Convert.ToDouble(Console.ReadLine());
Console.Write("белорусский рубль ");
double balanceBelRub = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Ваш баланс валют : \n{balanceEvro} евро. \n{balanceUsd} USD. \n{balanceBelRub} руб");
Console.WriteLine("Какую валюту из вашего баланса вы хотите поменять?");
string wantToChange = Console.ReadLine();
Console.WriteLine($"На какую валюту  вы хотите поменять {wantToChange} ?");
string changeCurrency = Console.ReadLine();

if (wantToChange == "евро") 
{
    if (changeCurrency == "доллар")
    {

        balanceUsd = balanceEvro * 1.05;
        Console.WriteLine($"Ваш баланс после обмена {wantToChange} на {changeCurrency} равен {balanceUsd} долларов");
    }
    else if (wantToChange == "евро") 
    {
        if (changeCurrency == "белорусский рубль")
        {
            balanceBelRub = balanceEvro * 2.78;
            Console.WriteLine($"Ваш баланс после обмена {wantToChange} на {changeCurrency} равен {balanceBelRub} долларов");
        }
    }
}
if (wantToChange == "белорусский рубль") 
{
    if (changeCurrency == "евро")
    {

        balanceEvro = balanceBelRub * 0.36;
        Console.WriteLine($"Ваш баланс после обмена {wantToChange} на {changeCurrency} равен {balanceEvro} евро");
    }
    else if (wantToChange == "белорусский рубль") 
    {
        if (changeCurrency == "доллар")
        {

            balanceUsd = balanceBelRub * 0.38;
            Console.WriteLine($"Ваш баланс после обмена {wantToChange} на {changeCurrency} равен {balanceUsd} долларов");
        }
    }
 }
if (wantToChange == "евро") 
{
    if (changeCurrency == "доллар")
    {

        balanceUsd = balanceEvro * 1.05;
        Console.WriteLine($"Ваш баланс после обмена {wantToChange} на {changeCurrency} равен {balanceUsd} долларов");
    }
    else if (wantToChange == "евро") 
    {
        if (changeCurrency == "белорусский рубль")
        {

            balanceBelRub = balanceEvro * 2.78;
            Console.WriteLine($"Ваш баланс после обмена {wantToChange} на {changeCurrency} равен {balanceBelRub} долларов");
        }
    }  
}
if (wantToChange == changeCurrency) 
    {    
         Console.WriteLine($"А смысл менять {wantToChange} на {changeCurrency}?!!");       
    }













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

