
namespace OrdenandoArray
{
    public class MaiorElemento
    {
        public double CalcularMaiorDaLista(double[] numeros)
        {
            double var = 0;
            int maisAlto = 0;

            for (int atual = 0; atual <= (numeros.Length - 1); atual++)
            {
                if (numeros[atual] > numeros[maisAlto])
                {
                    maisAlto = atual;
                }
                var = numeros[maisAlto];
            }
            Console.WriteLine("o mais alto é :" + var);
            return numeros[maisAlto];
        }
    }
}
