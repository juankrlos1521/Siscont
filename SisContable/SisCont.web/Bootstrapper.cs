using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

using SisCont.Interfaces.Titulos;
using SisCont.Services.Tramas;


namespace SisCont.web
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    

            container.RegisterType<IPersonaTitulo, PersonaTrama>();


            RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}