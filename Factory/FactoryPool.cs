using BusinessModels;
using IContracts;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace Factory
{
    public static class FactoryPool
    {
        //Design pattern : Factory design pattern.
        private static IUnityContainer container = null;
        public static IRoleBase Create(string type)
        {
            //Design pattern: Lazy loading. Eager Loading.
            if (container == null)
            {
                container = new UnityContainer();
                container.RegisterType<IRoleBase, Admin>("admin");
                container.RegisterType<IRoleBase, User>("user");
            }
            //Design pattern: RIP replace if poly
            return container.Resolve<IRoleBase>(type);
        }
    }
}
