using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public class ClassCreator : IClassCreator
    {
        public void CreateClass(string classID, string subject, DateTime schedule, Teacher owner, List<ClassSession> classList)
        {
            var newClass = new ClassSession(classID, subject, schedule, owner);
            classList.Add(newClass);
            Console.WriteLine($"Class {classID} created by {owner.Name}");
        }
    }
}
