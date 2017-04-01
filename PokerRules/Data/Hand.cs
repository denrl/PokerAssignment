namespace PokerAssignment.Data
{
    /// <summary>
    /// Enum that contains points different cases
    /// </summary>
    public enum Hand : byte
    {
        Flush = 128,
        ThreeOfAKind = 64,
        TwoOfAKind = 32,
        HighCard = 16,
        NotResolved = 0
    }
}
