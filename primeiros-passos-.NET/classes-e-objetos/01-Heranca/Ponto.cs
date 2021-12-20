namespace Classes.Heranca
{
    public class Ponto
    {
        public int x, y;
        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            //faz alguma coisa...
        }

        private void CalcularDistancia2()
        {
            //faz algumaa coisa
        }

        public virtual void CalcularDistancia3()
        {
            
        }
    }
}