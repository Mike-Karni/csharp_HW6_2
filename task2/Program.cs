/*Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
С помощью команд он может попросить сконвертировать одну валюту в другую. 
Курс конвертации просто описать в программе. 
Программа заканчивает свою работу в тот момент, когда решит пользователь.*/
/*1. запросить введите валюту*/

// // Портфель
//1 Console.WriteLine("Введите  ваш баланс валют");
//1 decimal balanceEvro = InputBalance("евро");
//1 decimal balanceUsd = InputBalance("доллар");
//1 decimal balanceBelRub = InputBalance("белорусский рубль");
// // Вывод баланс
//1  Console.WriteLine($"Ваш баланс валют : \n{balanceEvro} евро. \n{balanceUsd} USD. \n{balanceBelRub} белорусский  рубль ");

// while (true)
// {
// -    Console.WriteLine("Желаете продолжить обмен?");
// -    string answer = Console.ReadLine();
// 1     функиция :string answer = DoYouWantContinue("да");
// 1    if (answer == "нет")
// 1    {
// 1        break;
// 1    }
// 1    else if (answer == "да")
// 1    {
//-         Console.WriteLine("Какую валюту из вашего баланса вы хотите поменять?");
//-         string wantToChange = Console.ReadLine();
//1         string wantToChange = ChoiseChange("");
//1         while (wantToChange != "евро" && wantToChange != "доллар" && wantToChange != "белорусский рубль")
//1         {
//-             Console.WriteLine("Введите правильное название валюты:евро / доллар / белорусский рубль");
//-             wantToChange = Console.ReadLine();
//1             string wantToChange = CorrectNameInput("");
//         }
//         Console.WriteLine($"На какую валюту  вы хотите поменять {wantToChange} ?");
//         string changeCurrency = Console.ReadLine();
//         while (changeCurrency != "евро" && changeCurrency != "доллар" && changeCurrency != "белорусский рубль")
//         {
//             Console.WriteLine("Введите правильное название валюты:евро / доллар / белорусский рубль");
//             changeCurrency = Console.ReadLine();
//         }
//         Console.WriteLine($"Какую сумму {wantToChange} вы хотите обменять на {changeCurrency} ?");
//         double countchange = Convert.ToDouble(Console.ReadLine());
//         if (wantToChange == "евро" && countchange <= balanceEvro && changeCurrency == "доллар")
//         {
//             balanceUsd = balanceUsd + countchange * 1.05;
//             balanceEvro = balanceEvro - countchange;
//             Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
//         }
//         else if (wantToChange == "евро" && countchange <= balanceEvro && changeCurrency == "белорусский рубль")
//         {
//             balanceBelRub = balanceBelRub + countchange * 2.78;
//             balanceEvro = balanceEvro - countchange;
//             Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
//         }
//         else if (wantToChange == "доллар" && countchange <= balanceEvro && changeCurrency == "евро")
//         {
//             balanceEvro = balanceEvro + countchange * 0.95;
//             balanceUsd = balanceUsd - countchange;
//             Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
//         }
//         else if (wantToChange == "доллар" && countchange <= balanceEvro && changeCurrency == "белорусский рубль")
//         {
//             balanceBelRub = balanceBelRub + countchange * 2.65;
//             balanceUsd = balanceUsd - countchange;
//             Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
//         }
//         else if (wantToChange == "белорусский рубль" && countchange <= balanceEvro && changeCurrency == "евро")
//         {
//             balanceEvro = balanceEvro + countchange * 0.36;
//             balanceBelRub = balanceBelRub - countchange;
//             Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
//         }
//         else if (wantToChange == "белорусский рубль" && countchange <= balanceEvro && changeCurrency == "доллар")
//         {
//             balanceUsd = balanceUsd + countchange * 0.38;
//             balanceBelRub = balanceBelRub - countchange;
//             Console.WriteLine($"Ваш баланс портфеля после обмена  {wantToChange} на {changeCurrency} равен \n{balanceUsd} долларов \n{balanceEvro} евро \n{balanceBelRub} белорусских рублей");
//         }
//     }
// }
// Console.WriteLine("Введите  ваш баланс валют");
// Console.Write("Баланс евро ");

//                              decimal function for currency balance input
// decimal InputBalance(string balance)
// {
//     Console.Write($"Баланс {balance} ");
//     return Convert.ToDecimal(Console.ReadLine());

// }
//                              string fuction for answer
// string DoYouWantContinue(string answer)
// {
//     Console.WriteLine("Желаете продолжить обмен?");
//     return Console.ReadLine();
// }

                                // string function for currency choise
// string ChoiseChange(string currency)
// {
//     Console.WriteLine("Какую валюту из вашего баланса вы хотите поменять?");
//     return Console.ReadLine();

// }
                                //string method for correct name currency  input
// string CorrectNameInput( string name)
// {
//     Console.WriteLine("Введите правильное название валюты:евро / доллар / белорусский рубль");
//     return Console.ReadLine(); 
}
