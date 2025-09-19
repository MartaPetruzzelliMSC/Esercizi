namespace Logic.Core.Accesso
{
    public class ControlloAccesso
    {
        // Controlli classici
        public bool BadgeValido;
        public string CodiceInserito = string.Empty;
        public int LivelloAutorizzazione;

        // Controlli biometrici
        public bool RetinaValidata;
        public bool CodiceDnaCorretto;
        public bool ImprontaDigitaleCorretta;

        // Controlli sul profilo
        public bool OrarioConsentito;
        public double GiorniInAzienda;
        public bool LavoraATorino;

        // Stati di emergenza
        public bool StatoDiBlackout;
        public bool StatoDiEmergenza;
    }
}
