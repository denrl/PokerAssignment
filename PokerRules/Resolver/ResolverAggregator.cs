using System;
using System.Collections.Generic;
using System.Linq;
using PokerAssignment.Data;
using PokerAssignment.Resolver;

namespace PokerAssignment
{
    /// <summary>
    /// Main logic that calculated total points
    /// </summary>
    public class Aggregator
    {

        private IList<PokerResolver> resolvers = new List<PokerResolver>();

        public Aggregator()
        {
            resolvers.Add(new FlushResolver());
            resolvers.Add(new ThreeOfKindResolver());
            resolvers.Add(new TwoOfKindResolver());
            resolvers.Add(new HighCardResolver());
        }

        public int calculatePoints(IList<Card> cards)
        {
            int points = resolvers.Sum(resolver =>
            {
                resolver.resolve(cards);
                return (int)resolver.Data;
            });
            //
            return points;
        }
    }
}
