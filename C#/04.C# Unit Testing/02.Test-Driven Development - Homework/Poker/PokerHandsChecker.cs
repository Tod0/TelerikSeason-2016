using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException(nameof(hand));
            }

            if (hand.Cards.Count != 5)
            {
                return false;
            }

            for (int i = 0; i < 5; i++)
            {
                var currentCard = hand.Cards[i].ToString();

                for (int j = i + 1; j < 5; j++)
                {
                    if (currentCard == hand.Cards[j].ToString())
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException(nameof(hand));
            }

            var counter = 0;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face != hand.Cards[i + 1].Face)
                {
                    counter++;
                }

                if (counter == 3)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException(nameof(hand));
            }

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException(nameof(hand));
            }

            var counter = 0;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face != hand.Cards[i + 1].Face)
                {
                    counter++;
                }

                if (counter == 4)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsTwoPair(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException(nameof(hand));
            }

            var counter = 0;
            var currentCounter = 0;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        currentCounter++;
                    }

                    if (currentCounter > 1)
                    {
                        return false;
                    }

                    counter += currentCounter;
                }

                currentCounter = 0;
            }

            if (counter == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOnePair(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException(nameof(hand));
            }

            var counter = 0;
            var currentCounter = 0;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        currentCounter++;
                    }

                    counter += currentCounter;
                }

                currentCounter = 0;
            }

            if (counter == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
