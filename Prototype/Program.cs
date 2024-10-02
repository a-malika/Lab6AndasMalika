using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace Laboratory6
{
    public class Program
    {
        static void Main(string[] args)
        {
            DocumentManager documentManager = new DocumentManager();
            // Создаем первый документ
            Document firstDocument = new Document("Flowers", "Bla-Bla-Bla flowers flowers flowers", new List<NestedElement>
            {
                new Section("Sunflower", "It is my friend. BBF"),
                new Section("Lilit of death", "beautiful"),
                new Image("some.url"),
                new Table("Table of flowers", 2, 2, new List<List<string>>
                {
                    new List<string> { "one", "two2" },
                    new List<string> { "flower1", "flower2" },
                    new List<string> { "flower3", "flower4" }
                })
            });

            // Выводим информацию о первом документе
            Console.WriteLine("Flowers Document:");
            Console.WriteLine(firstDocument.ToString());

            // Клонируем документ без изменений
            Document secondDocument = documentManager.CreateDocument(firstDocument);
            Console.WriteLine("Cloned Document (without modifications):");
            Console.WriteLine(secondDocument.ToString());

            // Клонируем документ с изменениями
            Document thirdDocument = documentManager.CreateDocumentWithModification(firstDocument, "Info about flowers", "Flowers are beautiful, but he.");
            Console.WriteLine("Modified Cloned Document:");
            Console.WriteLine(thirdDocument.ToString());

            // Сохраняем первый документ в файл
            string filePath = "C:/Users/malik/OneDrive/Рабочий стол/document.json";
            firstDocument.SaveToFile(filePath);
            Console.WriteLine($"Original Document saved to '{filePath}'.");

            // Загружаем документ из файла
            Document fourthDocument = Document.LoadFromFile(filePath);
            Console.WriteLine("Loaded Document from file:");
            Console.WriteLine(fourthDocument.ToString());


            // Добавляем новый элемент к загруженному документу
            fourthDocument.Elements.Add(new Section("Abrakadabra", "Puff magic errm bibidi babidi bum"));
            Console.WriteLine("Loaded Document after adding a new section:");
            Console.WriteLine(fourthDocument.ToString());
        }
    }
}
