const int ROWS = 3;
const int COLS = 3;

const string X = "X";
const string O = "O";

//string[,] board = new string[ROWS,COLS];

//  Row Win for X
// string[,] board = {
//     {X, X, X},
//     {O, O, X},
//     {X, O, O}
// };
//  0,0 
//  0,1
//  0,2

// string[,] board = {
//     {X, O, X},
//     {X, O, O},
//     {X, X, O}
// };
//  0,0
//  1,0
//  2,0


// string[,] board = {
//     {X, O, X},
//     {O, X, O},
//     {X, O, X}
// };
//  Diagonal Win from left to right
//  0,0
//  1,1
//  2,2

string[,] board = {
    {O, O, X},
    {O, X, X},
    {X, O, O}
};
//  Diagonal Win from right to left
//  0,2
//  1,1
//  2,0

int xCount = 0;
int oCount = 0;

for(int row = 0; row < ROWS; row++)
{
    for(int col = 0; col < COLS; col++)
    {
        Console.Write($"{board[row,col]} ");
    }

    //  Adds a New Line after looping the row
    Console.WriteLine();
}

//  Check for Rows Winning
for(int row = 0; row < ROWS; row++)
{
    xCount = 0;
    oCount = 0;


    for(int col = 0; col < COLS; col++)
    {
        //  Increment count for whichever X or O is in that 2D position
        if(board[row, col] == X)
            xCount++;
        else
            oCount++;

        //  Check if there is a win
        //  Check if X won
        if(xCount == 3)
        {
            Console.WriteLine("X Won on a Row");
            break;
        }
        
        //  Check if O won
        else if(oCount == 3)
        {
            Console.WriteLine("O Won on a Row");
            break;
        }

    }
}

//  Check for Column Winning
for(int col = 0; col < COLS; col++)
{
    xCount = 0;
    oCount = 0;

    for(int row = 0; row < ROWS; row++)
    {
        if(board[row, col] == X)
            xCount++;
        else
            oCount++;

        //  Check if X Won
        if(xCount == 3)
        {
            Console.WriteLine("Player X Won on a Column");
            break;
        }
        //  Check if O Won
        else if(oCount == 3)
        {
            Console.WriteLine("Player O Won on a Column");
        }
    }
}

//  Check for Diagonal Winning left to right
xCount = 0; 
oCount = 0;
for(int row = 0; row < ROWS; row++)
{
    for(int col = 0; col < COLS; col++)
    {
        //  Only if Row and Col are equal (this means diagonal)
        if(row == col)
        {
            if(board[row, col] == X)
                xCount++;
            else if(board[row, col] == O)
                oCount++;
        }

        //  Now we check for the winner
        if(xCount == 3)
        {
            Console.WriteLine("X Won Diagonally from left to right");
            break;
        }
        else if(oCount == 3)
        {
            Console.WriteLine("O Won Diagonally from left to right");
            break;
        }
    }
}

//  Check for Diagonal Winning right to left
int row1 = 0;   // Start from row 0
int col1 = COLS -1; // Start from bottom-most column 2
xCount = 0; 
oCount = 0;

while(col1 >= 0 && row1 < ROWS)
{
    if(board[row1, col1] == X)
        xCount++;
    else
        oCount++;

    if(xCount == 3)
    {
        Console.WriteLine("X Won Diagonally from Right to Left");
        break;
    }
    else if(oCount == 3)
    {
        Console.WriteLine("O Won Diagonally from Right to Left");
        break;
    }

    //  Decrease the column
    col1--;

    //  Increment the row
    row1++;

    //  THe above causes the column to move to the left while at the same time the row is moving up
}