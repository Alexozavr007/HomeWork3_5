using HomeWork3_5_4;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

var store = new Store();
// виводимо інфо про 3й товар в "сторі"
store[2].DisplayInfo();

Console.Write("Введіть назву товару для пошуку: ");
var articleName = Console.ReadLine();

store.SearchAndDisplayInfo(articleName);