using Serenity.Navigation;
using MyPages = SereneDBXplorer.Definition.Pages;

 
[assembly: NavigationMenu(2000, "Definition", icon: "fa-database")]

[assembly: NavigationLink(2100, "Definition/Database List Definitions", typeof(MyPages.DatabaseDefinitionsController), icon: "fa-server")]