using DataAccessLayer;
using Model;
using Ninject.Modules;

namespace Business_Logic
{
    public class SimpleConfigModule : NinjectModule
    {
        public override void Load()
        {
            // Bind<IRepository<Student>>().To<EntityFrameworkRepository<Student>>().InSingletonScope();
            Bind<IRepository<Student>>().To<DapperRepository<Student>>().InSingletonScope();
        }
    }
}
