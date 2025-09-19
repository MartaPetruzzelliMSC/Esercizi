namespace Logic.Core.Accesso
{
    public enum AccessWay
    {
        Main,
        Secondary,
        Emergency,
        None
    }

    public static class ControlloAccessoHelper
    {
        public static LivelloAccesso VerificaAccesso(ControlloAccesso controllo)
        {
            if(controllo.OrarioConsentito && controllo.GiorniInAzienda > 5 & !controllo.LavoraATorino)
            { 
                if(!ControllaVie(controllo).Contains(AccessWay.None))
                {
                    return LivelloAccesso.Consentito;
                }
            }
            if (controllo.LavoraATorino)
            {
                if(ControllaVie(controllo).Contains(AccessWay.Emergency))
                {
                    return LivelloAccesso.Sorvegliato;
                }
            }
            return LivelloAccesso.Negato;
        }

        public static int NumTestBiometrici(ControlloAccesso controllo)
        {
            int TestBiometrici = 0;
            if (controllo.RetinaValidata) TestBiometrici++;
            if (controllo.CodiceDnaCorretto) TestBiometrici++;
            if (controllo.ImprontaDigitaleCorretta) TestBiometrici++;
            return TestBiometrici;
        }

        public static List<AccessWay> ControllaVie(ControlloAccesso controllo)
        {
            List<AccessWay> porteConsentite = new List<AccessWay>();
            if(controllo.StatoDiEmergenza && !controllo.StatoDiBlackout)
            {
                porteConsentite.Add(AccessWay.Emergency);
            } 
            if (controllo.BadgeValido && controllo.LivelloAutorizzazione >= 3 && NumTestBiometrici(controllo) >= 2)
            {
                porteConsentite.Add(AccessWay.Main);
            } 
            if (controllo.BadgeValido && controllo.CodiceInserito.Equals("1970") && NumTestBiometrici(controllo) >= 1)
            {
                porteConsentite.Add(AccessWay.Secondary);
            }
            
            if(porteConsentite.Count == 0)
            {
                porteConsentite.Add(AccessWay.None);
            }
            return porteConsentite;
        }
    }
}
