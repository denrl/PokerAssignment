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

        public override Hand Data
        {
            get { return Resolved ? Hand.ThreeOfAKind : Hand.NotResolved; }
        }
    }
}
