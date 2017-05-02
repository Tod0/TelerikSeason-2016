namespace Poker.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    using Poker;

    [TestFixture]
    public class PokerHandsCheckerTests
    {
        private static PokerHandsChecker pokerHandsChecker = new PokerHandsChecker();

        [Test]
        public void IsValidHand_ShouldReturnFalse_IfHandHasLessThanFiveCards()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsValidHand(hand);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidHand_ShouldReturnFalse_IfHandHasMoreThanFiveCards()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Spades)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsValidHand(hand);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidHand_ShouldReturnFalse_IfHandHasDuplicates()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsValidHand(hand);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidHand_ShouldReturnTrue_IfHandHasFiveDifferentCards()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsValidHand(hand);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsFlush_ShouldReturnTrue_IfHandIsFlush()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsFlush(hand);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsFlush_ShouldReturnFalse_IfHandIsNotFlush()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsFlush(hand);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnTrue_IfHandIsFourOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsFourOfAKind(hand);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnFalse_IfHandIsNotFourOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsFourOfAKind(hand);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsThreeOfAKind_ShouldReturnTrue_IfHandIsThreeOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsThreeOfAKind(hand);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsThreeOfAKind_ShouldReturnFalse_IfHandIsNotThreeOfAKind()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsThreeOfAKind(hand);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsOnePair_ShouldReturnTrue_IfHandIsOnePair()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsOnePair(hand);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsOnePair_ShouldReturnFalse_IfHandIsNotOnePair()
        {
            IList<ICard> cards = new List<ICard>
            {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            };
            var hand = new Hand(cards);

            var result = pokerHandsChecker.IsOnePair(hand);

            Assert.IsFalse(result);
        }

        // TODO: two pair
    }
}
