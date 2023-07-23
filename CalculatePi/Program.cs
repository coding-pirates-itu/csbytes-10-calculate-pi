var epsilon = 1e-10;

var pi = FastCalc(epsilon);

Console.WriteLine($"PI = {pi}");


static double SlowCalc(double epsilon)
{
    var pi = 0.0;

    var b = 4.0;
    var a = 1.0;

    while (true)
    {
        var delta = b / a;
        pi += delta;
        if (Math.Abs(delta) < epsilon) break;

        a += 2;
        b = -b;
    }

    return pi;
}


static double FastCalc(double epsilon)
{
    var pi = 0.0;

    var b1 = 16.0 / 5;
    var a1 = 1;
    var b2 = -4.0 / 239;

    while (true)
    {
        var delta1 = b1 / a1;
        var delta2 = b2 / a1;
        pi += delta1 + delta2;
        if (Math.Abs(delta1 + delta2) < epsilon) break;

        a1 += 2;
        b1 /= -25;
        b2 /= -(239 * 239);
    }

    return pi;
}
