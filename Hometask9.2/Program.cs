// Ви розробляєте програму для генерації текстового звіту. Ваше завдання - створити текстовий звіт, який містить заголовок,
// дату та список подій. Використайте StringBuilder, щоб зберегти пам’ять та оптимізувати об’єднання рядків. Користувач у циклi
// буде вводити подiї, треба додавати їх у загальний список подiй типу StringBuilder 

using System.Text;

Console.WriteLine($"\tREPORT {DateTime.Now.ToString("dd.MM.yyyy")}");

StringBuilder events = new StringBuilder();

int i = 1;
bool isLoopActive = true;

do
{
    Console.WriteLine($"\nEnter the event No{i}:");
    events.Append($"\n{i}. {Console.ReadLine()};");

    Console.WriteLine("Press ENTER to continue or press any other key to generate a report.");
    var key = Console.ReadKey(true);

    switch (key.Key)
    {
        case ConsoleKey.Enter:
            i++;
            break;
        default:
            isLoopActive = false;
            break;
    }    
}
while (isLoopActive);

Console.Clear();
Console.WriteLine($"\tREPORT {DateTime.Now.ToString("dd.MM.yyyy")}");
Console.WriteLine(events);

