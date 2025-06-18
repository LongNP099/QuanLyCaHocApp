using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public class ClassRemover : IRemove
    {
        public void Remove(string classID, Teacher owner, List<ClassSession> classList)
        {
            var cls = classList.Find(c => c.ClassID == classID);
            if (cls != null)
            {
                classList.Remove(cls);
                Console.WriteLine($"Class {classID} cancelled by {owner.Name}");
            }
            else
            {
                Console.WriteLine($"Class {classID} not found.");
            }
        }
    }
}
