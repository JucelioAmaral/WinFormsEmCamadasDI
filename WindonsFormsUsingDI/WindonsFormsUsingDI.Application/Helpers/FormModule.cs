using AutoMapper;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Application.Contratos;
using WindonsFormsUsingDI.Application.Helpers.ProfileDto;

namespace WindonsFormsUsingDI.Application.Helpers
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            //https://pt.stackoverflow.com/questions/184157/d%C3%BAvida-sobre-como-implementar-uma-inje%C3%A7%C3%A3o-de-depend%C3%AAncia-no-c-utilizando-o-ninj
            //Para injeção de dependencia funcionar nos formulários.
            Bind<IDonoService>().To<DonoService>();
            ////Bind<ICaoService>().To<CaoService>();
            ////Bind<IGeralService>().To<GeralService>();

            ////Bind<IDonoRepository>().To<DonoRepository>();
            ////Bind<ICaoRepository>().To<CaoRepository>();
            ////Bind<IGeralRepository>().To<GeralRepository>();

            //https://stackoverflow.com/questions/43560555/how-do-i-use-ninject-to-inject-automapper-mapper-in-place-of-imapper
            //Para injeção de dependencia do AutoMapper funcionar.
            Kernel.Bind<IMapper>().ToMethod(context =>
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<WindonsFormsUsingDIProfile>();
                    // tell automapper to use ninject when creating value converters and resolvers
                    cfg.ConstructServicesUsing(t => Kernel.Get(t));
                });
                return config.CreateMapper();
            }).InSingletonScope();
        }

        public static FormModule Create()
        {
            return new FormModule();
        }
    }
}
