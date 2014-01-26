using NServiceBus;

namespace Amazon.ECommerce.Infrastructure
{
    public static class WebGlobalInitialization
    {
        public static IBus InitializeNServiceBus()
        {
			Configure.Transactions.Disable();

            return Configure.With()
                .DefaultBuilder()
                //.ForMvc()
                .XmlSerializer()
                .PurgeOnStartup(false)
                .UnicastBus()
                .RunHandlersUnderIncomingPrincipal(false)
                .CreateBus()
                .Start(() => Configure.Instance.ForInstallationOn<NServiceBus.Installation.Environments.Windows>().Install());
        }
    }
}
