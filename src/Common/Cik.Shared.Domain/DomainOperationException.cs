﻿using System;

namespace Cik.Shared.Domain
{
    public class DomainOperationException : Exception
    {
        public DomainOperationException(AggregateId aggregateId, string message)
        {
            AggregateId = aggregateId;
        }

        private AggregateId AggregateId { get; }
    }
}