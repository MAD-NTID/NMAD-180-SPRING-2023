const int WIN_COUNT = 3;
const int ROWS = 3;
const int COLS = 3;

const string X = "X";
const string O = "O";

// This is how you declare the 2D if playing live by inputs
//string[,] board = new string[ROWS,COLS];

// Tie, no body Wins!
string[,] board = {
    {X, X, O},
    {O, O, X},
    {X, O, O}
};

// Row #1 Win for X [0,0], [0,1], [0,2]
// string[,] board = {
//     {X, X, X},
//     {O, O, X},
//     {X, O, O}
// };

// Row #2 Win for X [1,0], [1,1], [1,2]
// string[,] board = {
//     {X, O, O},
//     {X, X, X},
//     {O, X, O}
// };

// Row #3 Win for X [2,0], [2,1], [2,2]
// string[,] board = {
//     {X, O, O},
//     {O, O, X},
//     {X, X, X}
// };

// Column #1 Win for X [0,0], [1,0], [2,0]
// string[,] board = {
//     {X, O, X},
//     {X, O, O},
//     {X, X, O}
// };

// Column #2 Win for X [0,1], [1,1], [2,1]
// string[,] board = {
//     {O, X, O},
//     {O, X, X},
//     {X, X, O}
// };

// Column #3 Win for X [0,2], [1,2], [2,2]
// string[,] board = {
//     {O, X, X},
//     {O, O, X},
//     {X, O, X}
// };

// Diagonal Left to Right Win for X [0,0], [1,1], [2,2]
// string[,] board = {
//     {X, O, X},
//     {O, X, O},
//     {O, O, X}
// };

// Diagonal Right to Left Win for X [0,2], [1,1], [2,0]
// string[,] board = {
//     {O, O, X},
//     {O, X, X},
//     {X, O, O}
// };

//  Display the Game Board
for(int row = 0; row < ROWS; row++)
{
    for(int col = 0; col < COLS; col++)
    {
        //  Prints the value for the Coordinate row, col
        Console.Write($"{board[row,col]} ");
    }

    //  Adds a New Line after looping the row
    Console.WriteLine();
}

//  These variables to be used by all game logic
int xCount = 0;
int oCount = 0;
//  This flag is used to determine whether to continue the game or not. 
//  Additionally, this flag prevents further checking of game logic in case there are two winners of the same symbol.
//  Finally, this flag is used to show if a Tie has happened.
bool gameIsWon = false;

//  Check for Rows Winning
for(int row = 0; row < ROWS; row++)
{
    //  We clear the xCount and oCount if a row does not contain any 3 consecutive symbols
    //  This is so we can proceed to the next row and test again
    xCount = 0;
    oCount = 0;

    for(int col = 0; col < COLS; col++)
    {
        //  Increment count for whichever X or O is in that 2D position
        if(board[row, col] == X)
            xCount++;
        else
            oCount++;
    }

    //  Check if X won
    if(xCount == WIN_COUNT)
    {
        Console.WriteLine("X Won on a Row");
        gameIsWon = true;
    }
    
    //  Check if O won
    else if(oCount == WIN_COUNT)
    {
        Console.WriteLine("O Won on a Row");
        gameIsWon = true;
    }

    if(gameIsWon)
        Environment.Exit(0);
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
    }

    if(xCount == WIN_COUNT)
    {
        Console.WriteLine("Player X Won on a Column");
        gameIsWon = true;
    }
    else if(oCount == WIN_COUNT)
    {
        Console.WriteLine("Player O Won on a Column");
        gameIsWon = true;
    }

    if(gameIsWon)
        Environment.Exit(0);
}

//  Check for Diagonal Winning left to right
xCount = 0; 
oCount = 0;

for(int row = 0; row < ROWS; row++)
{
    if(board[row, row] == X)
        xCount++;
    else if(board[row, row] == O)
        oCount++;

    if(xCount == WIN_COUNT)
    {
        Console.WriteLine("X Won Diagonally from Left to Right");
        gameIsWon = true;   
    }
    else if(oCount == WIN_COUNT)
    {
        Console.WriteLine("O Won Diagonally from Left to Right");
        gameIsWon = true;
    }

    if(gameIsWon)
        Environment.Exit(0);
}

//  Check for Diagonal Winning Right to Left
xCount = 0; 
oCount = 0;

for(int row = 0; row < ROWS; row++)
{
    //  Start from right most column. As the row number increases, the row is substracted from the column. 
    //  This makes the column moves to the left
    if(board[row, COLS - row - 1] == X)
        xCount++;
    else if(board[row, COLS - row - 1] == O)
        oCount++;

    if(xCount == WIN_COUNT)
    {
        Console.WriteLine("X Won Diagonally from Right to Left");
        gameIsWon = true;
    }
    else if(oCount == WIN_COUNT)
    {
        Console.WriteLine("O Won Diagonally from Right to Left");
        gameIsWon = true;
    }

    if(gameIsWon)
        Environment.Exit(0);
}

Console.WriteLine("Tie, no body won");