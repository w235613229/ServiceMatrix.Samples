using Amazon.Contracts.Sales;
using NServiceBus;
using Amazon.InternalMessages.Sales;

namespace Amazon.Sales
{
    public partial class SubmitOrderProcessor : IHandleMessages<SubmitOrder>
    {
		public void Handle(SubmitOrder message)
		{
			HandleImplementation(message);

			Bus.Publish<OrderAccepted>(
                e => { /* set properties on e in here */ });
		}

		partial void HandleImplementation(SubmitOrder message);

		public IBus Bus { get; set; }
    }
}
