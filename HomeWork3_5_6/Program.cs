using System;
using System.Text;

// Індексатори.

namespace Indexers {

    class Program {
        static void Main() {
            Console.OutputEncoding = Encoding.Unicode;
            Dictionary dictionary = new Dictionary();

            Console.WriteLine("Пошук слів наведених укр. мовою:");
            Console.WriteLine(dictionary[ELangCode.UK, "книга"]);
            Console.WriteLine(dictionary[ELangCode.UK, "дім"]);
            Console.WriteLine(dictionary[ELangCode.UK, "ручка"]);
            Console.WriteLine(dictionary[ELangCode.UK, "стіл"]);
            Console.WriteLine(dictionary[ELangCode.UK, "олівець"]);
            Console.WriteLine(dictionary[ELangCode.UK, "яблуко"]);
            Console.WriteLine(dictionary[ELangCode.UK, "сонце"]);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("\r\nПошук слів наведених англ. мовою:");
            Console.WriteLine(dictionary[ELangCode.EN, "sun"]);
            Console.WriteLine(dictionary[ELangCode.EN, "apple"]);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("\r\nПошук слів наведених чеською мовою:");
            Console.WriteLine(dictionary[ELangCode.CZ, "rezervovat"]);
            Console.WriteLine(dictionary[ELangCode.CZ, "jablko"]);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("\r\nПеревірка індексатора:");
            for (int i = 0; i < 6; i++) {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }

}