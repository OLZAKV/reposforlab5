using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть ключ доступу: ");
            var key = Console.ReadLine();
            var path = "C:\\Users\\alex\\Documents\\GitHub\\reposforlab5\\ООП ЛР5\\DocumentWorker\\text.txt";

            var documentWorker = new DocumentWorker(path);

            switch (key)
            {
                case "pro":
                    documentWorker = new ProDocumentWorker(path);
                    break;
                case "exp":
                    documentWorker = new ExpertDocumentWorker(path);
                    break;
            }

            documentWorker.OpenDocument();
            documentWorker.SaveDocument("text");
            documentWorker.EditDocument((oldText) => oldText + "\n new line");
            documentWorker.ChangeExtension("doc");
        }
    }
}
