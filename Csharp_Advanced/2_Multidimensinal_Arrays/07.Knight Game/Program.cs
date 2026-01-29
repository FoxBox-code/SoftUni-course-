using System.Globalization;

int sizeOfTheBoard = int.Parse(Console.ReadLine());


int knightsToREmove = 0;




if (sizeOfTheBoard > 30 || sizeOfTheBoard < 0)
{
    Console.WriteLine(knightsToREmove);
    return;
}

char[,] board = new char[sizeOfTheBoard, sizeOfTheBoard];



CreatABoard(sizeOfTheBoard, board);



while (true)
{
    int mostAttacks = 0;
    int rowOfAggressor = 0;
    int colOfAggressor = 0;
    

    for (int i = 0; i < sizeOfTheBoard; i++)
    {

        for (int j = 0; j < sizeOfTheBoard; j++)
        {
            if (board[i, j] == 'K')
            {
                char movingPiece = board[i, j];
                int attacks = 0;

                if (j + 1 < board.GetLength(1)) // move 1/8 one foward two down
                {
                    if (i + 2 < board.GetLength(0))
                    {
                        char movingTo = board[i + 2, j + 1];
                        if (movingPiece == movingTo)
                        {
                           
                            attacks++;
                        }
                    }
                }
                if (j - 2 >= 0) // move 2/8 moving two back one up
                {
                    if (i - 1 >= 0)
                    {
                        char movingTo = board[i - 1, j - 2];

                        if (movingPiece == movingTo)
                        {

                            attacks++;
                        }
                    }
                }
                if (j - 1 >= 0) // move 3/8 moving one back two up
                {
                    if (i - 2 >= 0)
                    {
                        char movingTo = board[i - 2, j - 1];

                        if (movingPiece == movingTo)
                        {

                            attacks++;
                        }
                    }
                }
                if (j + 1 < board.GetLength(1)) // move 4/8 moving one foward two up
                {
                    if (i - 2 >= 0)
                    {
                        char movingTo = board[i - 2, j + 1];

                        if (movingPiece == movingTo)
                        {

                            attacks++;
                        }
                    }
                }
                if (j + 2 < board.GetLength(1)) // move 5/8 moving two foward one up
                {
                    if (i - 1 >= 0)
                    {
                        char movingTo = board[i - 1, j + 2];

                        if (movingPiece == movingTo)
                        {

                            attacks++;
                        }
                    }
                }
                if (j + 2 < board.GetLength(1)) // move 6/8 moving two foward one down
                {
                    if (i + 1 < board.GetLength(0))
                    {
                        char movingTo = board[i + 1, j + 2];

                        if (movingPiece == movingTo)
                        {

                            attacks++;
                        }
                    }
                }
                if (j - 1 >= 0) // move 7/8 moving one back two down
                {
                    if (i + 2 < board.GetLength(0))
                    {
                        char movingTo = board[i + 2, j - 1];

                        if (movingPiece == movingTo)
                        {

                            attacks++;
                        }
                    }
                }
                if (j - 2 >= 0) // move 8/8 moving two back one down
                {
                    if (i + 1 < board.GetLength(0))
                    {
                        char movingTo = board[i + 1, j - 2];

                        if (movingPiece == movingTo)
                        {

                            attacks++;
                        }
                    }
                }
                if (mostAttacks < attacks)
                {
                    mostAttacks = attacks;

                    rowOfAggressor = i;
                    colOfAggressor = j;
                }



            }
        }
    }
    if (mostAttacks == 0)
    {
        break;
    }
    else
    {
        knightsToREmove++;
        board[rowOfAggressor, colOfAggressor] = '0';

    }
}
Console.WriteLine(knightsToREmove);












static void CreatABoard(int sizeOfTheBoard, char[,] board)
{
    for (int i = 0; i < sizeOfTheBoard; i++)
    {
        string input = Console.ReadLine();
        for (int j = 0; j < sizeOfTheBoard; j++)
        {


            board[i, j] = input[j];
        }
    }
}