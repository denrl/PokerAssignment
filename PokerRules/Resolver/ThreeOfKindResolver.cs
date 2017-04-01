using PokerAssignment.Data;

namespace PokerAssignment.Resolver
{
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
