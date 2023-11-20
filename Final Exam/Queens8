class Public
{
    static void Main()
    {
        int size = 8;
        Queens(new bool[size, size], new int[size, size], 0);
        Console.WriteLine(count);
    }
    static int count = 0;
    static void Queens(bool[,] board,int[,] occupied, int columIndex)
    {
        if(columIndex == board.GetLength(0))
        {
            count++;
            return;
        }
        
        
        for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
        {

            if (occupied[rowIndex, columIndex] == 0)
            {

                board[rowIndex, columIndex] = true;
                MarkOccupied(occupied, +1, rowIndex, columIndex);
                Queens(board, occupied, columIndex + 1);
                board[rowIndex, columIndex] = false;
                MarkOccupied(occupied, -1, rowIndex, columIndex);
            }
        }
    }

    static void MarkOccupied(int[,] occupied,int value, int row, int col)
    {
        for (int i = 0; i < occupied.GetLength(0); i++)
        {
            occupied[i, col] += value;
            occupied[row, i] += value;

           
            if (col + i < occupied.GetLength(0) && row + i < occupied.GetLength(0))
            {
                occupied[row + i, col + i] += value;
            }
            if (col + i < occupied.GetLength(0) && row - i >= 0)
            {
                occupied[row - i, col + i] += value;
            }

            
        }
    }
    
    
}
