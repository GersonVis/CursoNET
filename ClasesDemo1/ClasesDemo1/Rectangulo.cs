namespace ClasesDemo1
{
    class Rectangulo {
        double baseRectangulo;
        double alturaRectangulo;
        string color;

        public Rectangulo() {
            color = "negro";
        }
        public Rectangulo(int baseRectangulo, int alturaRectangulo) {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
            color = "negro";
        }

        public double calcularArea() {
            return alturaRectangulo * baseRectangulo;
        }
        public double CalcularPerimetro() {
            return (2 * alturaRectangulo) + (2 * baseRectangulo);
        }

        public void Deconstruct(out double baseRect, out string colorRect) {
            baseRect = baseRectangulo;
            colorRect = color;
        }

        public static double calcularArea(int baseRectangulo, int alturaRectangulo) { 
            return (2 * baseRectangulo) + (2 * alturaRectangulo);
        }
       }
}
