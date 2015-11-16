using System.Collections.Generic;

namespace Memories
{
    class Human
    {
        public string Name { get; set; }
        public int Mood { get; set; }
        private List<PersonalMemory> _memories;

        public Human(string name)
        {
            Name = name;
            Mood = 0;
            _memories = new List<PersonalMemory>();
        }

        public void AddMemory(PersonalMemory someMemory)
        {
            _memories.Add(someMemory);
        }

        public void DeleteMemory(PersonalMemory someMemory)
        {
            _memories.Remove(someMemory);
        }
    }
}
