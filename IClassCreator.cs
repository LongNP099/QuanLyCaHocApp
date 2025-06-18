using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    public interface IClassCreator
    {
        void CreateClass(string classID, string subject, DateTime schedule, Teacher owner, List<ClassSession> classList);
    }
}
