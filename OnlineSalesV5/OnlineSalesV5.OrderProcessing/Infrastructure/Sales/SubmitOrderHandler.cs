﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using NServiceBus;
using OnlineSalesV5.Internal.Commands.Sales;


namespace OnlineSalesV5.Sales
{
    public partial class SubmitOrderHandler : IHandleMessages<SubmitOrder>
    {
		
		public void Handle(SubmitOrder message)
		{
			// Handle message on partial class
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(SubmitOrder message);

        public IBus Bus { get; set; }

    }

	
}
