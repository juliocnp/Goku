namespace Goku
{
    public class Magia
    {
        public int Ki;
        public int Dano;

        public Magia(int Ki, int Dano)
        {
            if (Ki < 0)
                this.Ki = 0;
            else if (Ki > 1000)
                this.Ki = 1000;
            else
                this.Ki = Ki;

            if (Dano < 0)
                this.Dano = 0;
            else if (Dano > 1000)
                this.Dano = 1000;
            else
                this.Dano = Dano;
        }
    }
}
