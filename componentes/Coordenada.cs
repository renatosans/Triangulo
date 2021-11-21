namespace triangulo.componentes
{
    public class Coordenada
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coordenada(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public String GetX(){
            return Convert.ToString(this.x) + "px";
        }

        public String GetY(){
            return Convert.ToString(this.y) + "px";
        }
    }
}
