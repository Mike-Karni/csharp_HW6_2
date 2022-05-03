//Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

//if ввод не == "exit", то снова запрос ввода.

//Console.WriteLine("Введите слово для выхода из цикла");
//string password = Console.ReadLine();

string password = "";
Console.WriteLine("Введите ваше имя");
string? name = Console.ReadLine();
Console.WriteLine("Установите пароль для входа");
string? passname = Console.ReadLine();
while (password != passname)
{     
    Console.WriteLine("Введите слово для выхода из цикла");
    password = Console.ReadLine();
    
    
}
Console.WriteLine($"Добро пожаловать,  {name}");
/*Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается,
 когда пишем exit еще 4 команды (их можно придумать самому). 
 Например:

- SetName – Установить имя (!)
- Help – вывести список команд
- SetPassword – Установить пароль (!)
- WriteName – вывести имя после ввода пароля (!) */  


