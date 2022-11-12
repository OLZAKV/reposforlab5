using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil studies");
        }
        public override void Read()
        {
            Console.WriteLine("Good pupil reads");
        }
        public override void Write()
        {
            Console.WriteLine("Good pupil writes");
        }
        public override void Relax()
        {
            Console.WriteLine("Good pupil relaxing");
        }
    }
}
