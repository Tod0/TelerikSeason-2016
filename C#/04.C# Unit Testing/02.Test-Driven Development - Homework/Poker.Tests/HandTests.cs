namespace Poker.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    using Poker;

    [TestFixture]
    public class HandTests
    {
        [Test]
        public void Hand_ImplementToString_ShouldReturnCorrectString()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var expectedResult = string.Join(", ", hand.Cards);
            var actualResult = hand.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
