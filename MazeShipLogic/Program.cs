namespace MazeShipLogic
{
   public class Tablero
   {
       public int Dimension { get; }
       public Celda[,] tablero { get; }
       public Tablero(int dimension)
       {
           Dimension=dimension;
           tablero = new Celda[Dimension,Dimension];
           inicializarCelda(Dimension,tablero);
       }
        private static void inicializarCelda(int dimension, Celda[,] tablero)
        {
            for(int i=0; i<dimension; i++)
                for (int j = 0; j < dimension; j++)
                {
                tablero[i,j] = new Celda();
                }
        }
    }

   public class Celda
   {
       public bool EsObstaculo { get; set; }
       public bool EsTrampa { get; set; }
       
       
   }

    public struct Player
    {
        string nombre;
        
    }
}
