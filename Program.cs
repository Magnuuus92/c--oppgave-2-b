using System.Runtime.InteropServices;

DateTime currentTime = DateTime.Now;

Console.WriteLine("Input name:");
string? name = Console.ReadLine();
Console.WriteLine("input language:");
//string? language = Console.ReadLine();

//1. dklarer data - dictionary
//2. konstruer key
//3. access dictionary with key
//4. output final text (dictionary entry + date)

Dictionary<string, string> langDict = new Dictionary<string, string>
{
        {"norsk", "Hei " + name + " klokka er " +  currentTime.Hour + ":" + currentTime.Minute},//1
        {"spansk", "Hola " + name + " son las " +  currentTime.Hour + ":" + currentTime.Minute}, //1
        {"engelsk", "Hello " + name + " the time is " +  currentTime.Hour + ":" + currentTime.Minute},//1
};
string language = Console.ReadLine();
Console.WriteLine(langDict[language]);
int month = currentTime.Month - 1;

/*Dictionary<int, string> monthDict = new Dictionary<int, string>
{
    {1 , "january" },
    {2 , "february" },
    {3 , "march" },
{4 , "april" },
{5 , "may" },
{6 , "june" },
{7 , "july" },
{8 , "august" },
{9 , "september" },
{10 , "october" },
{11 , "november" },
{12 , "december" }
};*/

string[] norMonthArray =
{
    "januar", "februar", "mars", "april", "mai", "juni", "juli", "august", "september", "oktober", "november", "desember"
};


string[] spaMonthArray =
{
    "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"
};
string[] engMonthArray =
{
    "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december"
};

//Console.WriteLine(engMonthArray[month]);



Dictionary<string, string> testDict = new Dictionary<string, string>
{
    {"spansk", "el mes es " + spaMonthArray[month] },
    {"engelsk", "The month is " + engMonthArray[month] },
    {"norsk", "Nå er vi i " + norMonthArray[month]}
};
Console.WriteLine(testDict[language]);
