using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    public class DocumentWorker
    {
        public string Path;
        private string _text;

        public DocumentWorker(string path)
        {
            Path = path;
        }

        public string OpenDocument()
        {
            Console.WriteLine("Документ відкрито");
            string text = File.ReadAllText(Path);

            _text = text;

            return text;
        }
        public virtual void EditDocument(Func<string, string> changeText)
        {
            Console.WriteLine("Правка документа доступна у версії Про");
        }
        public virtual void SaveDocument(string text)
        {
            Console.WriteLine("Збереження документа доступне у версії Про");
        }
        public virtual void ChangeExtension(string newExtension)
        {
            Console.WriteLine("Збереження документа в іншому форматі доступне у версії Експерт");
        }
    }
}
