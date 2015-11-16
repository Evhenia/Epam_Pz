using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memories
{
    class StudySadMemory : SadMemory
    {
        private Spheres _lifeSphereOfMemory = Spheres.Study;

        public Spheres LifeSphereOfMemory { get { return _lifeSphereOfMemory; } }
        public Institution SadEducationalPlace { get; set; }
        public override int StrongOfMemory
        {
            get
            {
                return base.StrongOfMemory * ((int)LifeSphereOfMemory + (int)SadEducationalPlace);
            }

            set
            {
                base.StrongOfMemory = value;
            }
        }


        public StudySadMemory(int strong, int price, int length, int sadEducationalPlace) : base(strong, price, length)
        {
            SadEducationalPlace = (Institution)sadEducationalPlace;
        }

        public override string MemoryInfo()
        {
            return base.MemoryInfo() + "Life sphere of memory:" + _lifeSphereOfMemory + ". Educational place, which is the reason of sad, is " + SadEducationalPlace + ". ";
        }
    }

    enum Spheres { Family = 1, Study, Love }
    enum Institution { School = 1, College, Institute, University }
}
