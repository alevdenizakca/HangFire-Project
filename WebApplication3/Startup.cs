
using Hangfire;
using Hangfire.Common;
using Hangfire.SqlServer;
using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using WebApplication3.Controllers;

[assembly: OwinStartup(typeof(WebApplication3.Startup))]

namespace WebApplication3
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AppManagement"].ConnectionString;
            if (connectionString.ToLower().StartsWith("metadata="))
            {
                System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder efBuilder = new System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder(connectionString);
                connectionString = efBuilder.ProviderConnectionString;
            }
            JobStorage.Current = new SqlServerStorage(connectionString);
            
            RecurringJob.AddOrUpdate<SchedulerController>(x => x.RunSchedulerMethod(), "*/5 * * * *");
            
            app.UseHangfireServer();
            app.UseHangfireDashboard();
        }
    }
}
