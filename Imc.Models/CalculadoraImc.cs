namespace Imc.Models
{
    public class CalculadoraImc
    {
        public static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }

        public static string SituacionNutricional(decimal imc)
        {
            string estadoNutricional;

            if (imc < 18.5M)
            {
                estadoNutricional = "Peso bajo";
            }
            else if (imc < 25.0M)
            {
                estadoNutricional = "Peso normal";
            }
            else if (imc < 30.0M)
            {
                estadoNutricional = "Sobrepeso";
            }
            else
            {
                estadoNutricional = "Obesidad";
            }

            return estadoNutricional;
        }
    }
}

