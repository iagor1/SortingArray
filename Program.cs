namespace OrdenandoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenorElemento a = new MenorElemento();

            double[] n = new double[5] { 210222, 3100, 21854, 321, 21485 };

            a.CalcularMenorDaLista(n);

            MaiorElemento b = new MaiorElemento();
            b.CalcularMaiorDaLista(n);

        }
    }
}