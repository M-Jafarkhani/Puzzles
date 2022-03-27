int A = 3;

if (A == 0)
{
    return 0;
}

if (A < 0)
{
    A *= -1;
}

int steps = 1;

int maxRange = 1;

while (true)
{
    if (isInMaxRange(A, maxRange))
    {
        return steps;
    }

    steps++;

    maxRange += steps;
}

bool isInMaxRange(int A, int maxRange)
{
    if (A > maxRange)
    {
        return false;
    }

    if (A % 2 == maxRange % 2)
    {
        return true;
    }

    return false;
}

