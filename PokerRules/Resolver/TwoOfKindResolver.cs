using PokerAssignment.Data;

namespace PokerAssignment.Resolver
{
    /// <summary>
    /// Impl of MultiKindResolver (2 of a kind)
    /// </summary>
    public class TwoOfKindResolver : MultiKindResolver
    {
        public TwoOfKindResolver() : base(2)
        {
        }


        public override Hand Data
        {
            get { return Resolved ? Hand.TwoOfAKind : Hand.NotResolved; }
        }
    }
}
