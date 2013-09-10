﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace MovieTickets.Dependency
{
    class MovieTicketsBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ISword>().To<Sword>(); // Bindings
        }
    }
}
