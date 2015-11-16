using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memories
{
    class SadMemory : PersonalMemory
    {
        public const string TypeOfMemory = "Sad";

        public SadMemory(int strong, int price, int length) : base( strong, price, length)
        {
        }

        public void ForgetMemory()
        {
            Console.WriteLine("Memory, {0}, is fogotten.", ContentOfMemory);
            _owner.Mood += StrongOfMemory;
        }

        public override void ActivateMemory(string content, Human owner)
        {
            base.ActivateMemory(content, owner);
            ForgetMemory();
        }

        public override void DestroyMemory()
        {
            base.DestroyMemory();
            _owner.Mood -= StrongOfMemory;
        }

        public override string MemoryInfo()
        {
            return base.MemoryInfo() + "Type of this memory: " + TypeOfMemory + ". ";
        }

        public override void StopActivation()
        {
            Console.WriteLine("Sad memory, {0}, can be remembered.", ContentOfMemory);
            _owner.Mood += StrongOfMemory;
        }

    }
}
