int input = 3724;

string result = string.Empty;

Dictionary<int, string> map = new Dictionary<int, string>()
{
    { 1000, "M" },
    { 900, "CM" },
    { 500, "D" },
    { 400, "CD" },
    { 100, "C" },
    { 90, "XC" },
    { 50, "L" },
    { 40, "XL" },
    { 10, "X" },
    { 9, "IX" },
    { 5, "V" },
    { 4, "IV" },
    { 1, "I" }
};

foreach (KeyValuePair<int, string> entry in map)
{
    while (input / entry.Key > 0)
    {
        input -= entry.Key;
        result += entry.Value;
    }
}

return 1;