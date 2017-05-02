namespace Poker.Tests
{
    using NUnit.Framework;

    using Poker;

    [TestFixture]
    public class CardTests
    {
        [TestCase(CardFace.Two, CardSuit.Diamonds)]
        [TestCase(CardFace.Ace, CardSuit.Spades)]
        [TestCase(CardFace.Four, CardSuit.Clubs)]
        [TestCase(CardFace.Jack, CardSuit.Hearts)]
        public void Card_ImplementToString_ShouldReturnCorrectString(CardFace face, CardSuit suit)
        {
            var card = new Card(face, suit);
            var expectedResult = string.Format($"{card.Face} of {card.Suit}");
            var actualResult = card.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
