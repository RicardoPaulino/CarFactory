namespace CarFactory.Entity
{
    public class Porta
    {
        public Porta()
        {
            machaneta = new Machaneta();
            retrovisor = new Retrovisor();
        }
        public Machaneta machaneta;
        public Retrovisor retrovisor;
    }
}