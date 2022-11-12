using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public ExpertDocumentWorker(string path) : base(path){}

        public override void ChangeExtension(string newExtension)
        {
            var newPath = System.IO.Path.ChangeExtension(Path, newExtension);
            File.Move(Path, newPath);
            Path = newPath;
            Console.WriteLine("Документ збережений в новому форматі");
        }
    }
}
