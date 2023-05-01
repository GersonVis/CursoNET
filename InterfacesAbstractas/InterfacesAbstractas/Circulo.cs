namespace InterfacesAbstractas
{
    sealed class Circulo : FiguraBase, IFigura, IRenderizar
    {
        int radio;

        public int Calcular(int x, int y)
        {
            throw new System.NotImplementedException();
        }

         void IFigura.Dibujar()
        {
            throw new System.NotImplementedException();
        }
         void IRenderizar.Dibujar() { 
        
        }

        public void Renderizar()
        {
            throw new System.NotImplementedException();
        }

        public sealed override void Pintar()
        {
            throw new System.NotImplementedException();
        }
    }

}
