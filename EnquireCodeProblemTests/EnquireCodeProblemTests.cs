using System;
using Xunit;
using Moq;
using EnquireCodeProblems;
using System.Linq;

namespace EnquireCodeProblemTests
{
    public class NextFibonacciWithLoopTests
    {
        [Fact]
        public void TheFibanacciAfterFourIsFive()
        {
            Assert.True(EnquireCodeProblems.EnquireCodeProblemSolutions.NextFibonacciLoop(4) == 5);
        }

        [Fact]
        public void TheFibanacciAfterFiveIsEight()
        {
            Assert.True(EnquireCodeProblems.EnquireCodeProblemSolutions.NextFibonacciLoop(5) == 8);
        }
    }

    public class NextFibonacciRecursiveTests
    {
        [Fact]
        public void TheFibanacciAfterFourIsFive()
        {
            Assert.True(EnquireCodeProblems.EnquireCodeProblemSolutions.NextFibonacciRecursive(4) == 5);
        }

        [Fact]
        public void TheFibanacciAfterFiveIsEight()
        {
            Assert.True(EnquireCodeProblems.EnquireCodeProblemSolutions.NextFibonacciRecursive(5) == 8);
        }
    }

    public class AnnogramTest
    {
        [Fact]
        public void ListenIsAnAnnogramOfEnlist()
        {
            Assert.True(EnquireCodeProblems.EnquireCodeProblemSolutions.IsAnnogram("listen", "enlist"));
        }

        [Fact]
        public void ListenIsNotAnAnnogramOfInlists()
        {
            Assert.False(EnquireCodeProblems.EnquireCodeProblemSolutions.IsAnnogram("listen", "inlists"));
        }

        [Fact]
        public void ListenIsNotAnnogramOfGoogle()
        {
            Assert.False(EnquireCodeProblems.EnquireCodeProblemSolutions.IsAnnogram("listen", "google"));
        }

        [Fact]
        public void ThereIsOneAnnogram()
        {
            Assert.True(EnquireCodeProblemSolutions.GetAnnograms(new[] { "google", "inlists", "enlist" }, "listen").Count() == 1);
        }
    }

    public class GetNthFibonacciTests
    {
        [Fact]
        public void TheZeroethOrLessFibonacciThrows()
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => EnquireCodeProblemSolutions.GetFibonacci(-1));
        }

        [Fact]
        public void TheFirstFibonacciIsZero()
        {
            Assert.True(EnquireCodeProblems.EnquireCodeProblemSolutions.GetFibonacci(1) == 0);
        }

        [Fact]
        public void TheThirdFibonacciIsOne()
        {
            Assert.True(EnquireCodeProblems.EnquireCodeProblemSolutions.GetFibonacci(3) == 1);
        }

        [Fact]
        public void TheFourthFibonacciIsTwo()
        {
            Assert.True(EnquireCodeProblems.EnquireCodeProblemSolutions.GetFibonacci(4) == 2);
        }

        [Fact]
        public void TheNinthFibonacciIsTwentOne()
        {
            Assert.True(EnquireCodeProblems.EnquireCodeProblemSolutions.GetFibonacci(9) == 21);
        }
    }
}
