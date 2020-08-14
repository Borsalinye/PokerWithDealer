namespace PokerWithDealer.net
{
    class Card
    {
        public Suits Suit { get; }
        public Ranks Rank { get; }
        public Card(Suits suit, Ranks rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }
        public enum Suits : byte
        {
            Spades,
            Hearts,
            Diamonds,
            Clubs
        }
        public enum Ranks : byte
        {
            Two = 2,
            Three,
            Fouth,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            В = 2,
            Д = 3,
            К = 4,
            Т = 11
        }
    }
}
