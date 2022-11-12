using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil studies");
        }
        public override void Read()
        {
            Console.WriteLine("Bad pupil reads");
        }
        public override void Write()
        {
            Console.WriteLine("Bad pupil writes");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad pupil relaxing");
        }
    }
}
