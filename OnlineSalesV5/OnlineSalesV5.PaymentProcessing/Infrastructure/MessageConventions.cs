﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace OnlineSalesV5.PaymentProcessing
{
    public class MessageConventions : INeedInitialization
    {
        public void Customize(BusConfiguration config)
        {
            config.Conventions()
                .DefiningCommandsAs(t => t.Namespace != null && t.Namespace.StartsWith("OnlineSalesV5.Internal.Commands"))
                .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("OnlineSalesV5.Contracts"))
                .DefiningMessagesAs(t => t.Namespace != null && t.Namespace.StartsWith("OnlineSalesV5.Internal.Messages"));
        }
    }
}

