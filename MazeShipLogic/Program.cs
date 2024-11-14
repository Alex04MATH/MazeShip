namespace MazeShipLogic
{
   public class Tablero
   {
       public int Dimension { get; }
       public Celda[,] Tablero { get; }
       public Tablero(int dimension)
       {
           Dimension=dimension;
           Tablero=new Celda[Dimension,Dimension];
           inicializarCelda();
       }
        private static void inicializarCelda()
        {
            for(int i=0; i<Dimension; i++)
            for (int j = 0; j < Dimension; j++)
            {
                Tablero[i,j] = new Celda();
            }
        }
    }

   public class Celda
   {
       public bool EsObstaculo { get; set; }
       public bool EsTrampa { get; set; }
       
   }

    public class Player
    {
        string nombre;
        
    }
}
