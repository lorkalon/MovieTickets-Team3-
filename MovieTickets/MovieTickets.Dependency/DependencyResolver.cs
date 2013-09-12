using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using MovieTickets.BLL;
using MovieTickets.IBLL;
using MovieTickets.IDAL;
using MovieTickets.DAL;
using Ninject;

namespace MovieTickets.Dependency
{
    public class DependencyResolver:IDependencyResolver
    {
        private IKernel _kernel;

        public DependencyResolver()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()    // Here must be all interfaces IDAL anad IBLL and their's implementations
        {
            _kernel.Bind<IFilmService>().To<FilmService>();
        }
    }
}
