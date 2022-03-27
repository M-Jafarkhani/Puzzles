string input = "MDCCCIV";

var result = 0;

for (int i = 0; i < input.Length;)
{
    if (i < input.Length - 1)
    {
        result += getValue(input[i], input[i + 1]);

        if (isSubtractive(input[i], input[i + 1]))
        {
            i += 2;
        }
        else
        {
            i += 1;
        }
    }
    else
    {
        result += getValue(input[i]);

        i += 1;
    }
}

return result;

bool isSubtractive(char numeral, char next)
{
    return ((numeral == 'I' && next == 'V') ||
            (numeral == 'I' && next == 'X') ||
            (numeral == 'X' && next == 'L') ||
            (numeral == 'X' && next == 'C') ||
            (numeral == 'C' && next == 'D') ||
            (numeral == 'C' && next == 'M'));
}

int getValue(char numeral, char? next = null)
{
    switch (numeral)
    {
        case 'I':
            if (next != null && next == 'V')
                return 4;
            else if (next != null && next == 'X')
                return 9;
            else
                return 1;
        case 'V':
            return 5;
        case 'X':
            if (next != null && next == 'L')
                return 40;
            else if (next != null && next == 'C')
                return 90;
            else
                return 10;
        case 'L':
            return 50;
        case 'C':
            if (next != null && next == 'D')
                return 400;
            else if (next != null && next == 'M')
                return 900;
            else
                return 100;
        case 'D':
            return 500;
        case 'M':
            return 1000;
    }

    return 0;
}






