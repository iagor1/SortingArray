

namespace OrdenandoArray
{
    public class MenorElemento
    {
        public double CalcularMenorDaLista(double[] numeros)
        {
            double a = 0;
            int maisBaixo = 0;
            for (int atual = 0; atual <= 4; atual++)
            {
                if (numeros[atual] < numeros[maisBaixo])
                {
                    maisBaixo = atual;
                }
                a = numeros[maisBaixo];
            }
            Console.WriteLine("o mais baixo é :" + a);
            return a;
        }
    
    }
}
