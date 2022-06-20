// See https://aka.ms/new-console-template for more information

int[] path = { 36, 37, 38, 31, 24, 25, 26 };

bool[] maze =
{
    true, true, true, false,
    true, false, true, true,
    true, true, false, true,
    true, true, false, true

};

var res = Kata.FindPath(maze, 4, 9, 15);

Console.ReadLine();
public class Kata
{
    public static int[] FindPath(bool[] maze, int size, int startIndex, int goalIndex)
    {
        var set = new HashSet<int>();

        return GetResultOrDefault(maze, size, startIndex, goalIndex, set);
    }

    private static int[] GetResultOrDefault(bool[] maze, int size, int start, int goal, HashSet<int> passedIndexes)
    {
        if (start == goal)
        {
            passedIndexes.Add(goal);
            return passedIndexes.ToArray();
        }
        
        if (maze[start] == false)
        {
            return null;
        }

        if (passedIndexes.Contains(start))
        {
            return null;
        }

        var indexesCopy = passedIndexes.ToHashSet();
        indexesCopy.Add(start);
        
        bool isLeftBound = start % size == 0;
        bool isRightBound = (start - size + 1) % size == 0;
        bool isTopBound = start < size;
        bool isBottomBound = start >= maze.Length - size;

        int[]? leftResult = null, rightResult = null, topResult = null, bottomResult = null;
        Parallel.Invoke(() =>
        {
            leftResult = isLeftBound ? null : GetResultOrDefault(maze, size, start - 1, goal, indexesCopy);
        }, () =>
        {
            rightResult = isRightBound ? null : GetResultOrDefault(maze, size, start + 1, goal, indexesCopy);

        }, () =>
        {
            bottomResult = isBottomBound ? null : GetResultOrDefault(maze, size, start + size, goal, indexesCopy);

        }, () =>
        {
            topResult = isTopBound ? null : GetResultOrDefault(maze, size, start - size, goal, indexesCopy);
        });        
        
        return (leftResult
                ?? rightResult
                ?? bottomResult
                ?? topResult)!;
    }
}

