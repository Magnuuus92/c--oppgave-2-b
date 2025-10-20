using System.Runtime.InteropServices;

DateTime currentTime = DateTime.Now;

Console.WriteLine("Input name:");
string? name = Console.ReadLine();
Console.WriteLine("input language:");


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





Dictionary<string, string> testDict = new Dictionary<string, string>
{
    {"spansk", "el mes es " + spaMonthArray[month] },
    {"engelsk", "The month is " + engMonthArray[month] },
    {"norsk", "Nå er vi i " + norMonthArray[month]}
};
Console.WriteLine(testDict[language]);
/*
Dictionary<string, string> frekkDict = new Dictionary<string, string>
{
    {"spansk", "el mes es " + spaMonthArray[month] },
    {"engelsk", "The month is " + engMonthArray[month] },
    {"norsk", "Nå er vi i " + norMonthArray[month]}
};/*