int[] lengthInput = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();



char[,] playingField = new char[lengthInput[0], lengthInput[1]];

int[] playerCurrentPosition = new int[2];
bool won = false;
bool lost = false;




CreatPlayingField(playingField);





string movementCommand = Console.ReadLine();

//Console.WriteLine(String.Join(" ", playerCurrentPosition)); player starting position is row 4 , col 2


while (true)
{
    for (int i = 0; i < movementCommand.Length; i++)
    {
        if (movementCommand[i] == 'U')
        {
            if (playerCurrentPosition[0] - 1 >= 0)
            {
                if (playingField[playerCurrentPosition[0] - 1, playerCurrentPosition[1]] == 'B')//Game over method
                {
                    playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';

                    playerCurrentPosition[0] = playerCurrentPosition[0] - 1;
                    lost = true;

                }
                else
                {
                    playingField[playerCurrentPosition[0] - 1, playerCurrentPosition[1]] = 'P'; // Up direction
                    playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';

                    playerCurrentPosition[0] = playerCurrentPosition[0] - 1;
                }
                

            }
            else
            {
                playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';
                won = true;
                
            }
        }
        else if (movementCommand[i] == 'L')
        {

            if (playerCurrentPosition[1] - 1 >= 0)
            {
                if (playingField[playerCurrentPosition[0], playerCurrentPosition[1] - 1] == 'B')//Game over Method
                {
                    playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';

                    playerCurrentPosition[1] = playerCurrentPosition[1] - 1;
                    lost = true;
                }
                else
                {
                    playingField[playerCurrentPosition[0], playerCurrentPosition[1] - 1] = 'P'; // Left Direction
                    playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';

                    playerCurrentPosition[1] = playerCurrentPosition[1] - 1;
                }
                
            }
            else
            {
                playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';
                won = true;
              
            }
        }
        else if (movementCommand[i] == 'R')
        {
            if (playerCurrentPosition[1] + 1 < playingField.GetLength(1))
            {
                if (playingField[playerCurrentPosition[0], playerCurrentPosition[1] + 1] == 'B')//Game over
                {
                    playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';

                    playerCurrentPosition[1] = playerCurrentPosition[0] + 1;
                    lost = true;
                }
                else
                {
                    playingField[playerCurrentPosition[0], playerCurrentPosition[1] + 1] = 'P';
                    playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';

                    playerCurrentPosition[1] = playerCurrentPosition[0] + 1;
                }
                
            }
            else
            {
                playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';
                won = true;
              
            }
        }
        else if (movementCommand[i] == 'D')
        {
            if (playerCurrentPosition[0] + 1 < playingField.GetLength(0))
            {
                if (playingField[playerCurrentPosition[0] + 1, playerCurrentPosition[1]] == 'B')
                {
                    playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';

                    playerCurrentPosition[0] = playerCurrentPosition[0] + 1;

                    lost = true;
                }
                else
                {
                    playingField[playerCurrentPosition[0] + 1, playerCurrentPosition[1]] = 'P';
                    playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';

                    playerCurrentPosition[0] = playerCurrentPosition[0] + 1;
                }
                
            }
            else
            {
                playingField[playerCurrentPosition[0], playerCurrentPosition[1]] = '.';
                won = true;
                
            }
        }
        char[,] replica = new char[lengthInput[0], lengthInput[1]];
        ReplicaCreation(playingField, replica);
        BunnyInfection(playingField, replica , lost); 

        

        if (won)
        {
            break;
        }
        if (lost)
        {
            break;
        }
    }
    if (won)
    {
        break;
    }
    if (lost)
    {
        break;
    }
}
Display(playingField);
if (won)
{
    Console.WriteLine($"won: {playerCurrentPosition[0]} {playerCurrentPosition[1]}");
}
if (lost)
{
    Console.WriteLine($"dead: {playerCurrentPosition[0]} {playerCurrentPosition[1]}");
}

static void Display(char[,] result)
{
    for (int row = 0; row < result.GetLength(0); row++)
    {
        for (int col = 0; col < result.GetLength(1); col++)
        {
            Console.Write(result[row, col]);
        }
        Console.WriteLine();
    }
}

 int[] CreatPlayingField(char[,] playingField)
{
    for (int i = 0; i < playingField.GetLength(0); i++)
    {
        string input = Console.ReadLine();
        for (int j = 0; j < playingField.GetLength(1); j++)
        {
            

            playingField[i, j] = input[j];

            if (playingField[i, j] == 'P')
            {
                playerCurrentPosition[0] = i;
                playerCurrentPosition[1] = j;

            }
        }
    }
    return playerCurrentPosition;
}

static void BunnyInfection(char[,] playingField, char[,] replica, bool lost)
{
    for (int row = 0; row < playingField.GetLength(0); row++)
    {

        for (int col = 0; col < playingField.GetLength(1); col++)
        {

            if (replica[row, col] == 'B')
            {
                if (row - 1 >= 0)
                {
                    if (playingField[row - 1, col] == 'P')
                    {
                        lost = true;
                    }
                    playingField[row - 1, col] = 'B'; // Up Direction

                }
                if (row + 1 < playingField.GetLength(0)) // Down Direction
                {
                    if (playingField[row + 1, col] == 'P')
                    {
                        lost = true;
                    }
                    playingField[row + 1, col] = 'B';

                }
                if (col - 1 >= 0)
                {
                    if (playingField[row, col - 1] == 'P')
                    {
                        lost = true;
                    }
                    playingField[row, col - 1] = 'B';
                }
                if (col + 1 < playingField.GetLength(1))
                {
                    if (playingField[row, col + 1] == 'P')
                    {
                        lost = true;
                    }

                    playingField[row, col + 1] = 'B';
                }
            }

        }
    }
}

static void ReplicaCreation(char[,] playingField, char[,] replica)
{
    for (int row = 0; row < playingField.GetLength(0); row++)
    {

        for (int col = 0; col < playingField.GetLength(1); col++)
        {


            replica[row, col] = playingField[row, col];
        }
    }
}