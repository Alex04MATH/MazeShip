using System;
using System.Collections.Generic;
namespace MazeShip
{
    public partial class MazeCell
    {
        private bool[,] ValidateConnectivity()
        {
            bool[,] accessible = new bool[rows, columns];
            DFS(0, 0, accessible);

            return accessible;
        }

        private void DFS(int row, int col, bool[,] accessible)
        {
            if (row < 0 || row >= rows || col < 0 || col >= columns)
                return;
            if (accessible[row, col] || mazeCell[row, col].IsWall)
                return;
            accessible[row, col] = true;

            DFS(row - 1, col, accessible);
            DFS(row + 1, col, accessible);
            DFS(row, col - 1, accessible);
            DFS(row, col + 1, accessible);
        }

        private void RepairConnectivity(bool[,] accessible)
        {
            bool connection = true;
            while (connection)
            {
                connection = false;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (!mazeCell[i, j].IsWall && !accessible[i, j])
                        {
                            bool wasConnect = ReconnectCell(i, j, accessible);
                            if (wasConnect)
                            {
                                DFS(i, j, accessible);
                                connection = true;
                            }
                        }
                    }
                }
            }
        }

        private bool ReconnectCell(int row, int col, bool[,] accessible)
        {
            ConnectCell(row, col, accessible);

            return accessible[row, col];
        }
        private void ConnectCell(int row, int col, bool[,] accessible)
        {
            (int, int)[] directions = new[] { (-1, 0), (1, 0), (0, -1), (0, 1) };
            foreach ((int, int) tuple in directions)
            {
                int x = row + tuple.Item1;
                int y = col + tuple.Item2;

                if (x >= 0 && x < rows && y >= 0 && y < columns && accessible[x, y])
                {
                    int interX = (x + row) / 2;
                    int interY = (y + col) / 2;
                    if (!mazeCell[interX, interY].IsFree)
                    {
                        mazeCell[interX, interY].CreateFreeCell();
                        accessible[row, col] = true;
                        DFS(row, col, accessible);
                    }
                }
            }
        }
    }
}
