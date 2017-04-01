using System.Collections.Generic;
using PokerAssignment.Data;

namespace PokerAssignment.Resolver
{

    /// <summary>
    /// Base class for resolvers
    /// </summary>
    public abstract class PokerResolver
    {
        public abstract void resolve(IList<Card> cards);

        public virtual bool Resolved { get; protected set; }

        public virtual Hand Data { get; protected set; }

    }
}
