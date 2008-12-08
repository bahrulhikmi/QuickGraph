﻿#if CONTRACTS_FULL
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace QuickGraph.Contracts
{
    [ContractClassFor(typeof(IEdge<>))]
    sealed class IEdgeContract<TVertex>
        : IEdge<TVertex>
    {
        [ContractInvariantMethod]
        public void ObjectInvariant()
        {
            IEdge<TVertex> me = this;
            Contract.Invariant(me.Source != null);
            Contract.Invariant(me.Target != null);
        }

        TVertex IEdge<TVertex>.Source
        {
            get { return Contract.Result<TVertex>(); }
        }

        TVertex IEdge<TVertex>.Target
        {
            get { return Contract.Result<TVertex>(); }
        }
    }
}
#endif