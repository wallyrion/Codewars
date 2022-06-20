namespace Navigating_a_Maze;

public class MatrixConverter
{
    public static bool[,] To2DimensionalMatrix(bool[] maze, int size)
    {
        bool[,] arr = new bool[size, size];
        //var arr = new bool[][size];

        
        for (int i = 0; i < maze.Length; i++)
        {
            var (row, column) = GetRowColumn(i, size);

            arr[row, column] = maze[i];
        }

        return arr;
    }

    public static (int row, int column) GetRowColumn(int flatIndex, int size)
    {
        var row = flatIndex / size;
        var column = flatIndex % size;

        return (row, column);
    }
}