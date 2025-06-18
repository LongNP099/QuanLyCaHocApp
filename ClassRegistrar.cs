using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public class ClassRegistrar : IClassRegistrar
    {
        public void RegisterToClass(ClassSession availableClass, Teacher owner, List<ClassSession> classList)
        {
            if (!classList.Contains(availableClass))
            {
                availableClass.Instructor = owner;
                classList.Add(availableClass);
                Console.WriteLine($"{owner.Name} has registered to class {availableClass.ClassID}");
            }
            else
            {
                Console.WriteLine($"{owner.Name} is already registered to class {availableClass.ClassID}");
            }
        }
    }
}
