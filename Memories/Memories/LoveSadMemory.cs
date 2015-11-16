using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memories
{
    class LoveSadMemory : SadMemory
    {
        private Spheres _lifeSphereOfMemory = Spheres.Love;

        public Spheres LifeSphereOfMemory { get { return _lifeSphereOfMemory; } }
        public Human ReasonOfSad { get; set; }
        public int DurationOfRelationship { get; set; }
        public override int StrongOfMemory
        {
            get
            {
                return base.StrongOfMemory * (int)_lifeSphereOfMemory + DurationOfRelationship;
            }

            set
            {
                base.StrongOfMemory = value;
            }
        }

        public LoveSadMemory(int strong, int price, int length, Human reasonOfSad, int durationOfRelationship) 
            : base(strong, price, length)
        {
            ReasonOfSad = reasonOfSad;
            DurationOfRelationship = durationOfRelationship;
        }

        public override string MemoryInfo()
        {
            return base.MemoryInfo() + ". Life sphere of memory: " + _lifeSphereOfMemory + ". Person the reason of sad is " + ReasonOfSad + ". Duration of relationship - " + DurationOfRelationship;
        }
    }
}
