

namespace Logic.Core.Salario
{
    public static class SalarioHelper
    {
        private const int Assenza = 0;
        private const int GiornataPiena = 8;

        public static decimal CalcolaSalario(int[] oreGiornaliere, decimal pagaOraria)
        {
            decimal salario = 0;
            decimal bonusFedeltà = 1.0M;
            decimal bonusContinuità = 2.0M;
            int giorniLavorati = 0;
            int giorniConsecutivi = 0;
            int maxGiorniConsecutivi = 0;

            foreach (int oreGiornata in oreGiornaliere)
            {
                if (oreGiornata == Assenza)
                {
                    salario -= pagaOraria * 2;
                    giorniConsecutivi = 0;
                }
                else if (oreGiornata > Assenza)
                {
                    if (oreGiornata > GiornataPiena)
                    {
                        salario = salario + 8 * pagaOraria + (oreGiornata - 8) * pagaOraria * 1.5m;
                        bonusFedeltà += 0.1m;
                    }
                    else
                    {
                        salario += oreGiornata * pagaOraria;
                        bonusFedeltà += 0.05m;
                    }

                    if (giorniLavorati % 6 == 0 && giorniLavorati != 0)
                    {
                        salario += 1000;
                    }

                    giorniConsecutivi++;

                    if (giorniConsecutivi > maxGiorniConsecutivi)
                        maxGiorniConsecutivi = giorniConsecutivi;

                }

                giorniLavorati++;
            }

            salario *= bonusFedeltà;

            if (maxGiorniConsecutivi > 5)
            {
                salario = salario + bonusContinuità * maxGiorniConsecutivi;
            }

            return Math.Round(salario, 2);
        }
    }
}
