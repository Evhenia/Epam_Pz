using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memories
{
    abstract class PersonalMemory
    {
        protected Human _owner;

        public Human Owner { get; }
        public string ContentOfMemory { get; protected set; }
        public virtual int StrongOfMemory { get; set; }
        public double Price { get; set; }
        public int MaxLengthOfMemory { get; set; }



        public PersonalMemory(int strong, int price, int length)
        {
            StrongOfMemory = strong;
            Price = price * (1 + 0.1) * strong;
            MaxLengthOfMemory = length;
        }

        protected void SetOwner(Human owner)
        {
            //if (_owner != null)
            //{
            //    _owner.DeleteMemory(this);
            //}
            _owner = owner;
            _owner.AddMemory(this);
        }

        protected void WriteMemory(string content)
        {
            if (content.Length < MaxLengthOfMemory)
            {
                ContentOfMemory = content;
            }
            else
            {
                Console.WriteLine("Your memory is too long. Choose another memory or buy longer memory.");
            }
        }

        public virtual void ActivateMemory(string content, Human owner)
        {
            SetOwner(owner);
            Console.WriteLine("Fogetting memory, {0}, is activated.", ContentOfMemory);
            WriteMemory(content);
        }

        public virtual void DestroyMemory()
        {
            _owner.DeleteMemory(this);
        }

        public virtual string MemoryInfo()
        {
            return "Owner: " + _owner + ", strong of memory: " + StrongOfMemory + ", price: " + Price + ", max length of this memory: " + MaxLengthOfMemory + ".\n Content of this memory: " + ContentOfMemory;
        }
        public abstract void StopActivation();
    }
    
}
