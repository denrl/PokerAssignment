using System.Collections.Generic;
using System.Linq;

using PokerAssignment.Data;


namespace PokerAssignment
{

    /// <summary>
    /// Processes hands and returns the ranked list of palyers in the order of winning
    /// </summary>
    public class RuleProcessor
    {
        Aggregator resolver = new Aggregator();

        public IList<string> rank(IList<PlayingHand> positions)
        {

            return  positions.Select(hand =>
                                        new
                                            {
                                                Points = resolver.calculatePoints(hand.Cards),
                                                PlayerName = hand.Player,
                                             })
                              .OrderByDescending(_ => _.Points).Select(_ => _.PlayerName).ToList();

        }
        
    }
}
