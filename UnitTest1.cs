using QuadraticEquationSolver.Core;
using Xunit;

namespace QuadraticEquationSolver.Tests
{
    public class QuadTests
    {
        [Theory]
        [InlineData(1, -3, 2, new double[] { 1, 2 })]    // Two roots (x=1, x=2)
        [InlineData(1, -2, 1, new double[] { 1 })]        // One root (x=1)
        [InlineData(1, 2, 3, new double[0])]              // No real roots
        public void Solve_ValidInputs_ReturnsCorrectRoots(double a, double b, double c, double[] expected)
        {
            var result = Quad.Solve(a, b, c);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solve_AIsZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Quad.Solve(0, 1, 1));
        }
    }
}