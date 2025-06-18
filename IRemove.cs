using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public interface IRemove
    {
        void Remove(string classID, Teacher owner, List<ClassSession> classList);
    }
}
