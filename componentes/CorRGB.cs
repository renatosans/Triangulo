namespace triangulo.componentes
{
    public class CorRGB
    {
        public Byte R { get; set; }
        public Byte G { get; set; }
        public Byte B { get; set; }

        public CorRGB(int R, int G, int B) {
            this.R = Convert.ToByte(R);
            this.G = Convert.ToByte(G);
            this.B = Convert.ToByte(B);
        }
    }
}
