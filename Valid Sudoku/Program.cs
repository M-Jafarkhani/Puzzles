using System.Collections;

List<string> A = new List<string>()
{
    "..5.....6",
    "....14...",
    ".........", 
    ".....92..", 
    "5....2...", 
    ".......3.", 
    "...54....", 
    "3.....42.", 
    "...27.6.."
};

int[,] sudoku = new int[9, 9];

if (A.Count != 9)
{
    return 0;
}

for (int i = 0; i < 9; i++)
{
    if (A[i].Length != 9)
    {
        return 0;
    }

    char[] row = A[i].ToCharArray();

    for (int j = 0; j < 9; j++)
    {
        sudoku[i, j] = ToInt(row[j]);
    }
}

for (int i = 0; i < 9; i++)
{
    Hashtable hash = new Hashtable();

    for (int j = 0; j < 9; j++)
    {
        if (sudoku[i, j] != 0)
        {
            if (hash.Contains(sudoku[i, j]))
            {
                return 0;
            }
            else
            {
                hash.Add(sudoku[i, j], sudoku[i, j]);
            }
        }
    }
}

for (int i = 0; i < 9; i++)
{
    Hashtable hash = new Hashtable();

    for (int j = 0; j < 9; j++)
    {
        if (sudoku[j, i] != 0)
        {
            if (hash.Contains(sudoku[j, i]))
            {
                return 0;
            }
            else
            {
                hash.Add(sudoku[j, i], sudoku[j, i]);
            }
        }
    }
}

for (int i = 0; i < 9; i++)
{
    Hashtable hash = new Hashtable();

    for (int j = 3 * (i / 3); j < 3 * (i / 3) + 3; j++)
    {
        for (int k = 3 *(i % 3); k < 3 *(i % 3) + 3; k++)
        {
            if (sudoku[j, k] != 0)
            {
                if (hash.Contains(sudoku[j, k]))
                {
                    return 0;
                }
                else
                {
                    hash.Add(sudoku[j, k], sudoku[j, k]);
                }
            }
        }
    }
}

int ToInt(char c)
{
    if (c == '.')
    {
        return 0;
    }

    return c - '0';
}

return 1;