using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Task
{
    class Startup
    {
        public static void Main()
        {
            var initialValue = int.Parse(Console.ReadLine());

            var sequence = new Queue<int>();
            sequence.Enqueue(initialValue);

            var resultingSequence = new List<int>();
            resultingSequence.Add(initialValue);
            while (resultingSequence.Count < 50)
            {
                var nextValue = sequence.Dequeue();

                var firstOperation = nextValue + 1;
                sequence.Enqueue(firstOperation);

                var secondOperation = (nextValue * 2) + 1;
                sequence.Enqueue(secondOperation);

                var thirdOperation = nextValue + 2;
                sequence.Enqueue(thirdOperation);

                resultingSequence.AddRange(new[]
                {
                    firstOperation,
                    secondOperation,
                    thirdOperation
                });
            }

            Console.WriteLine(string.Join(Environment.NewLine, resultingSequence.Take(50)));
        }
    }
}
