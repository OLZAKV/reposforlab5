using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent pupil studies");
        }
        public override void Read()
        {
            Console.WriteLine("Excelent pupil reads");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent pupil writes");
        }
        public override void Relax()
        {
            Console.WriteLine("Excelent pupil relaxing");
        }
    }
}
