using Godot;
using System;
using System.Collections.Generic;

public partial class MazeCell : Node2D
{
    private Cell[,] mazeCell;
    private const int columns = 27; // number of columns
    private const int rows = 27; // number of rows 
    private List<(Cell, Cell)> Walls = new List<(Cell, Cell)>();

    public override void _Ready()
    {
        generateMaze();
        
        bool[,] accessible=ValidateConnectivity();
        
        RepairConnectivity(accessible);

        ImprimirLaberinto();
    }
    private void initializeMaze()
    {
        mazeCell = new Cell[rows, columns];
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
        int x = cell.Coordinate.Item1;
        int y = cell.Coordinate.Item2;

        if (x > 1) Walls.Add((cell, mazeCell[x - 2, y]));
        if (x < rows - 2) Walls.Add((cell, mazeCell[x + 2, y]));
        if (y > 1) Walls.Add((cell, mazeCell[x, y - 2]));
        if (y < columns - 2) Walls.Add((cell, mazeCell[x, y + 2]));
    }
    #endregion
    #region Romper Muro
    private void BreakWall(Cell cell, Cell cell1)
    {
        int interX = (cell.Coordinate.Item1 + cell1.Coordinate.Item1) / 2;
        int interY = (cell.Coordinate.Item1 + cell1.Coordinate.Item1) / 2;

        mazeCell[interX, interY].CreateFreeCell();
    }
    #endregion
    private void ImprimirLaberinto()
    {
        int fila=0;
        for (int y = 0; y < rows; y++)
        {
           
            string linea = "";
            for (int x = 0; x < columns; x++)
            {
                if (mazeCell[y, x].IsWall)
                    linea += "0";
                else
                    linea += "1";
            }
            GD.Print(linea);
           fila++;
        }
        GD.Print(fila);
    }
}
