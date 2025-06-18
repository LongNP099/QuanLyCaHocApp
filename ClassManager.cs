using System;
using System.Collections.Generic;
using testConsole;

namespace testConsole {
    public abstract class ClassManager
    {
        public List<ClassSession> RegisteredClasses { get; set; } = new List<ClassSession>();

        protected IClassCreator Creator { get; }
        protected IRemove Remover { get; }
        protected IClassRegistrar Registrar { get; }

        protected ClassManager(IClassCreator creator, IRemove remover, IClassRegistrar registrar)
        {
            Creator = creator;
            Remover = remover;
            Registrar = registrar;
        }

        public void CreateClass(string classID, string subject, DateTime schedule)
        {
            Creator.CreateClass(classID, subject, schedule, GetOwner(), RegisteredClasses);
        }

        public void CancelClass(string classID)
        {
            Remover.Remove(classID, GetOwner(), RegisteredClasses);
        }

        public void RegisterToClass(ClassSession availableClass)
        {
            Registrar.RegisterToClass(availableClass, GetOwner(), RegisteredClasses);
        }

        public void ShowAllClasses()
        {
            Console.WriteLine($"\n=== Classes of {GetOwner().Name} ===");
            foreach (var cls in RegisteredClasses)
            {
                Console.WriteLine(cls.ToString());
            }
        }

        protected abstract Teacher GetOwner();
    }
}