using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    public class ProDocumentWorker : DocumentWorker
    {
        public ProDocumentWorker(string path) : base(path){}

        public override void EditDocument(Func<string, string> changeText)
        {
            var text = OpenDocument();
            var newText = changeText(text);
            SaveDocument(newText);
            Console.WriteLine("Документ відредаговано");
        }

        public override void SaveDocument(string text)
        {
            File.WriteAllText(Path, text);
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах доступне у версії Експерт");
        }
    }
}
