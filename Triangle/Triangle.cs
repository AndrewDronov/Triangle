namespace Triangle;

public enum Type
{
    Right = 1,
    Obtuse = 2,
    Acute = 3,
}

public static class Triangle
{
    private const double TOLERANCE = 0.00001;
    
    public static Type GetType(double a, double b, double c)
    {
        if (Math.Abs(a * a + b * b - c * c) < TOLERANCE || Math.Abs(a * a + c * c - b * b) < TOLERANCE || Math.Abs(c * c + b * b - a * a) < TOLERANCE)
        {
            return Type.Right;
        }

        if (a * a + b * b < c * c || a * a + c * c < b * b || c * c + b * b < a * a)
        {
            return Type.Obtuse;
        }

        return Type.Acute;
    }
}