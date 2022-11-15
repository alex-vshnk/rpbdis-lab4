using WebApplication.Data;

var context = new LanguageClassesContext();

DbInitializer.Initialize(context);

Console.WriteLine("success");
Console.ReadKey();