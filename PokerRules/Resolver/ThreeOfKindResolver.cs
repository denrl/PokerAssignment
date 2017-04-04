using PokerAssignment.Data;

namespace PokerAssignment.Resolver
{
    /// <summary>
    /// Impl of MultiKindResolver (3 of a kind)
    /// </summary>
    public class ThreeOfKindResolver : MultiKindResolver
    {
        public ThreeOfKindResolver() : base(3)
        {
        }

        public override long Data
        {
            get { return Resolved ? (long)Hand.ThreeOfAKind : (long)Hand.NotResolved; }
        }
    }
}
