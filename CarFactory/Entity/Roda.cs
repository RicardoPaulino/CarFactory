namespace CarFactory.Entity
{
    public class Roda
    {
        public Roda()
        {
            aro = new Aro();
            pneu = new Pneu();
            tipoRoda = new TipoRoda();
        }
        public Aro aro;
        public Pneu pneu;
        public TipoRoda tipoRoda;

       
    }
}