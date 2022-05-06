/*Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. 
Программа заканчивает свою работу в тот момент, когда решит пользователь.*/
/*1. запросить введите валюту*/

// // Портфель
decimal EurUsd = Convert.ToDecimal(1.05);
decimal EurBelRub = Convert.ToDecimal(2.78);
decimal UsdEur = Convert.ToDecimal(0.95);
decimal UsdBelRub = Convert.ToDecimal(2.65);
decimal BelRubEur = Convert.ToDecimal(0.36);
decimal BelRubUsd = Convert.ToDecimal(0.38);
decimal countchange;
Console.WriteLine("Введите  ваш баланс валют");
decimal balanceEvro = InputBalance("евро");
decimal balanceUsd = InputBalance("доллар");
decimal balanceBelRub = InputBalance("белорусский рубль");
Console.WriteLine($"Ваш баланс валют : \n{balanceEvro} евро. \n{balanceUsd} USD. \n{balanceBelRub} белорусский  рубль ");
while (true)
{
    string answer = DoYouWantContinue("да");
    if (answer == "нет")
    {
        break;
    }
    else if (answer == "да")
    {
        string wantToChange = ChoiseChange("");
        while (wantToChange != "евро" && wantToChange != "доллар" && wantToChange != "белорусский рубль")
        {
            wantToChange = CorrectNameInput("");
        }
        string changeCurrency = onWhatRoChange("");
        while (changeCurrency != "евро" && changeCurrency != "доллар" && changeCurrency != "белорусский рубль")
        {
            changeCurrency = CorrectNameInput("");
        }
        Console.WriteLine($"Какую сумму {wantToChange} вы хотите обменять на {changeCurrency} ?");
        countchange = Convert.ToDecimal(Console.ReadLine());
        if (wantToChange == "евро" && countchange <= balanceEvro && changeCurrency == "доллар")
        {           
            balanceUsd = CalculateBalance1(balanceUsd, countchange, EurUsd);
            balanceEvro = CalculateBalance2(balanceEvro, countchange);
            Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
        }
        else if (wantToChange == "евро" && countchange <= balanceEvro && changeCurrency == "белорусский рубль")
        {
            balanceBelRub = CalculateBalance1(balanceBelRub, countchange, EurBelRub);
            balanceEvro = CalculateBalance2(balanceEvro, countchange);
            Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
        }
        else if (wantToChange == "доллар" && countchange <= balanceUsd && changeCurrency == "евро")
        {
            balanceEvro = CalculateBalance1(balanceEvro, countchange, UsdEur);
            balanceUsd = CalculateBalance2(balanceUsd, countchange);
            Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
        }
        else if (wantToChange == "доллар" && countchange <= balanceUsd && changeCurrency == "белорусский рубль")
        {
            balanceBelRub = CalculateBalance1(balanceBelRub, countchange, UsdBelRub);
            balanceUsd = CalculateBalance2(balanceUsd, countchange);
            Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
        }
        else if (wantToChange == "белорусский рубль" && countchange <= balanceBelRub && changeCurrency == "евро")
        {
            balanceEvro = CalculateBalance1(balanceEvro, countchange, BelRubEur);
            balanceBelRub = CalculateBalance2(balanceBelRub, countchange);
            Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
        }
        else if (wantToChange == "белорусский рубль" && countchange <= balanceBelRub && changeCurrency == "доллар")
        {
            balanceUsd = CalculateBalance1(balanceUsd, countchange, BelRubUsd);
            balanceBelRub = CalculateBalance2(balanceBelRub, countchange);
            Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
        }
    }
}
//                              decimal function for currency balance input
decimal InputBalance(string balance)
{
    Console.Write($"Баланс {balance} ");
    return Convert.ToDecimal(Console.ReadLine());
}
//                              string fuction for answer
string DoYouWantContinue(string answer)
{
    Console.WriteLine("Желаете продолжить обмен?");
    return Console.ReadLine();
}

// string function for currency choise
string ChoiseChange(string currency)
{
    Console.WriteLine("Какую валюту из вашего баланса вы хотите поменять?");
    return Console.ReadLine();
}
//string method for correct name currency  input
string CorrectNameInput(string name)
{
    Console.WriteLine("Введите правильное название валюты:евро / доллар / белорусский рубль");
    return Console.ReadLine();
}

// На что меняем валюту функция
string onWhatRoChange(string name)
{
    Console.WriteLine($"На какую валюту  вы хотите поменять {name} ?");
    return Console.ReadLine();
}

// Вычисления 1 функция
decimal CalculateBalance1(decimal firstCurrency, decimal countchange, decimal CurrencyRatio)
{
    return firstCurrency = firstCurrency + countchange * CurrencyRatio;
}
//вычисления функция   
decimal CalculateBalance2(decimal SecondCurrency, decimal countchange)
{
    return SecondCurrency = SecondCurrency - countchange;
}