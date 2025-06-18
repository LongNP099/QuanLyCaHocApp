using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public interface IClassRegistrar
    {
        void RegisterToClass(ClassSession availableClass, Teacher owner, List<ClassSession> classList);
    }
}
