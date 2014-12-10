using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Interceptors
{
    public class LogInterceptor: IInterceptor
    {
        public Castle.Core.Logging.ILogger Logger { get; set; }

        public void Intercept(IInvocation invocation)
        {
            string logMessage = string.Format("{0}.{1}", invocation.TargetType.Name, invocation.Method.Name);
            Logger.Info(logMessage);
            
            invocation.Proceed();
        }
    }
}