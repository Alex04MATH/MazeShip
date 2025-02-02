using System;
using System.Collections.Generic;
namespace MazeShip
{
    public partial class MazeCell
    {
        public Cell[,] mazeCell { get; }
        private int columns = 31; // number of columns
        private int rows = 31; // number of rows 
        private List<(Cell, Cell)> Walls = new List<(Cell, Cell)>();

        public MazeCell()
        {
            mazeCell = new Cell[rows, columns];
            generateMaze();

            bool[,] accessible = ValidateConnectivity();

            RepairConnectivity(accessible);

            ImprimirLaberinto();
        }
        private void initializeMaze()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mazeCell[i, j] = new Cell(i, j, true);
                }
            }
        }
        #region Prim Algorithm 
        private void generateMaze()
        {
            initializeMaze();
            Random random = new Random();

            int startX = random.Next(0, rows);
            int startY = random.Next(0, columns);
            Cell initialCell = mazeCell[startX, startY];

            initialCell.CreateFreeCell();
            AddWalls(initialCell);

            while (Walls.Count > 0)
            {
                int index = random.Next(Walls.Count);
                (Cell, Cell) cellOriginNeighbor = Walls[index];
                Walls.RemoveAt(index);

                if (!cellOriginNeighbor.Item2.IsFree)
                {
                    cellOriginNeighbor.Item2.CreateFreeCell();

                    BreakWall(cellOriginNeighbor.Item1, cellOriginNeighbor.Item2);

                    AddWalls(cellOriginNeighbor.Item2);
                }
            }
        }
        #endregion
        #region Añadir muro Vecino
        private void AddWalls(Cell cell)
        {
            int x = cell.position.x;
            int y = cell.position.y;

            if (x > 1) Walls.Add((cell, mazeCell[x - 2, y]));
            if (x < rows - 2) Walls.Add((cell, mazeCell[x + 2, y]));
            if (y > 1) Walls.Add((cell, mazeCell[x, y - 2]));
            if (y < columns - 2) Walls.Add((cell, mazeCell[x, y + 2]));
        }
        #endregion
        #region Romper Muro
        private void BreakWall(Cell cell, Cell cell1)
        {
            int interX = (cell.position.x + cell1.position.x) / 2;
            int interY = (cell.position.y + cell1.position.y) / 2;

            mazeCell[interX, interY].CreateFreeCell();
        }
        #endregion
        private void ImprimirLaberinto()
        {
            int fila = 0;
            int l = 0;
            for (int y = 0; y < rows; y++)
            {

                string linea = "";
                for (int x = 0; x < columns; x++)
                {
                    l++;
                    if (mazeCell[y, x].IsWall)
                        linea += "0";
                    else
                        linea += "1";
                }
                System.Console.Write(linea);
                if (l == columns)
                {
                    l = 0;
                    System.Console.WriteLine();
                }
                fila++;
            }
            System.Console.WriteLine(fila);
        }
    }
}
