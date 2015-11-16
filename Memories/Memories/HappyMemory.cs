using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memories
{
    class HappyMemory : PersonalMemory
    {
        public const string TypeOfMemory = "Happy";

        public HappyMemory(int strong, int price, int length) 
            : base(strong, price, length)
        {
        }

        public void RememberMemory()
        {
            Console.WriteLine("Memory, {0}, is remembered.", ContentOfMemory);
        }

        public override void ActivateMemory(string content, Human owner)
        {
            base.ActivateMemory(content, owner);
            RememberMemory();
            _owner.Mood += StrongOfMemory;
        }

        public override void DestroyMemory()
        {
            base.DestroyMemory();
            _owner.Mood -= StrongOfMemory;
        }

        public override string MemoryInfo()
        {
            return base.MemoryInfo() + "Type of this memory: " + TypeOfMemory;
        }

        public override void StopActivation()
        {
            Console.WriteLine("Happy memory, {0}, can be fogotten.", ContentOfMemory);
            _owner.Mood -= StrongOfMemory;
        }

    }
}
