using System;

namespace QuadraticEquationSolver.Core
{
    public static class Quad
    {
        public static double[] Solve(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException("Coefficient 'a' cannot be zero.");

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
                return new double[0]; // No real roots

            if (discriminant == 0)
                return new double[] { -b / (2 * a) }; // One real root

            double sqrtDiscriminant = Math.Sqrt(discriminant);
            return new double[]
            {
                (-b - sqrtDiscriminant) / (2 * a),
                (-b + sqrtDiscriminant) / (2 * a)
            };
        }
    }
}