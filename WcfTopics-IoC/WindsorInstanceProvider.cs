using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using Castle.Windsor;

namespace WcfTopics_IoC
{
    public class WindsorInstanceProvider : IInstanceProvider
    {
        private readonly Type serviceType;
        private readonly IWindsorContainer container;

        public WindsorInstanceProvider(Type serviceType)
        {
            this.serviceType = serviceType;
            this.container = Program.Container;
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return container.Resolve(serviceType);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
            container.Release(instance);
        }
    }
}
