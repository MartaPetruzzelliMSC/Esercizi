using Logic.Core.Accesso;
using Logic.Test.Utilita;

namespace Logic.Test
{
    public class TestControlloAccesso
    { 
        public int testEffettuati = 0;
        public int testSuperati = 0;

        public TestControlloAccesso()
        {
            testEffettuati = 0;
            testSuperati = 0;
        }

        public void Testa()
        {
            DisplayHelper.MostraTitolo("Exercises on access control");

            AggiornaStatistiche(EseguiTest("Accesso normale valido", new ControlloAccesso
            {
                BadgeValido = true,
                RetinaValidata = true,
                CodiceDnaCorretto = true,
                ImprontaDigitaleCorretta = false,
                LivelloAutorizzazione = 3,
                OrarioConsentito = true,
                GiorniInAzienda = 10.4,
                LavoraATorino = false,
                StatoDiBlackout = false,
                StatoDiEmergenza = false,
                CodiceInserito = "1234"
            }, LivelloAccesso.Consentito));

            AggiornaStatistiche(EseguiTest("Accesso negato per blackout", new ControlloAccesso
            {
                BadgeValido = true,
                RetinaValidata = true,
                CodiceDnaCorretto = true,
                ImprontaDigitaleCorretta = true,
                LivelloAutorizzazione = 2,
                OrarioConsentito = true,
                GiorniInAzienda = 10.4,
                LavoraATorino = false,
                StatoDiBlackout = true,
                StatoDiEmergenza = false,
                CodiceInserito = "1234"
            }, LivelloAccesso.Negato));

            AggiornaStatistiche(EseguiTest("Accesso di emergenza", new ControlloAccesso
            {
                BadgeValido = false,
                RetinaValidata = false,
                CodiceDnaCorretto = false,
                ImprontaDigitaleCorretta = false,
                LivelloAutorizzazione = 1,
                OrarioConsentito = true,
                GiorniInAzienda = 10.4,
                LavoraATorino = false,
                StatoDiBlackout = false,
                StatoDiEmergenza = true,
                CodiceInserito = "1234",
            }, LivelloAccesso.Consentito));

            AggiornaStatistiche(EseguiTest("Accesso forzato durante verifica manuale", new ControlloAccesso
            {
                BadgeValido = false,
                RetinaValidata = false,
                CodiceDnaCorretto = false,
                ImprontaDigitaleCorretta = false,
                LivelloAutorizzazione = 1,
                OrarioConsentito = false,
                GiorniInAzienda = 3.6,
                LavoraATorino = true,
                StatoDiBlackout = false,
                StatoDiEmergenza = true,
                CodiceInserito = "1234",
            }, LivelloAccesso.Sorvegliato));

            AggiornaStatistiche(EseguiTest("Accesso con codice secondario", new ControlloAccesso
            {
                BadgeValido = true,
                RetinaValidata = false,
                CodiceDnaCorretto = true, // 1 check biometrico
                ImprontaDigitaleCorretta = false,
                LivelloAutorizzazione = 1,
                OrarioConsentito = true,
                GiorniInAzienda = 10,
                LavoraATorino = false,
                StatoDiBlackout = false,
                StatoDiEmergenza = false,
                CodiceInserito = "1970"
            }, LivelloAccesso.Consentito));
            AggiornaStatistiche(EseguiTest("Accesso negato per livello troppo basso", new ControlloAccesso
            {
                BadgeValido = true,
                RetinaValidata = true,
                CodiceDnaCorretto = true,
                ImprontaDigitaleCorretta = false,
                LivelloAutorizzazione = 2,
                OrarioConsentito = true,
                GiorniInAzienda = 10.4,
                LavoraATorino = false,
                StatoDiBlackout = false,
                StatoDiEmergenza = false,
                CodiceInserito = "1234",
            }, LivelloAccesso.Negato));

            AggiornaStatistiche(EseguiTest("Accesso negato per orario non consentito", new ControlloAccesso
            {
                BadgeValido = true,
                RetinaValidata = true,
                CodiceDnaCorretto = true,
                ImprontaDigitaleCorretta = true,
                LivelloAutorizzazione = 4,
                OrarioConsentito = false,
                GiorniInAzienda = 10.4,
                LavoraATorino = false,
                StatoDiBlackout = false,
                StatoDiEmergenza = false,
                CodiceInserito = "1234",
            }, LivelloAccesso.Negato));

            AggiornaStatistiche(EseguiTest("Accesso negato per registro offline", new ControlloAccesso
            {
                BadgeValido = true,
                RetinaValidata = true,
                CodiceDnaCorretto = true,
                ImprontaDigitaleCorretta = true,
                LivelloAutorizzazione = 5,
                OrarioConsentito = true,
                GiorniInAzienda = 1,  // blocco
                LavoraATorino = false,
                StatoDiBlackout = false,
                StatoDiEmergenza = false,
                CodiceInserito = "1234",
            }, LivelloAccesso.Negato));

            AggiornaStatistiche(EseguiTest("Accesso negato con solo codice secondario e nessuna biometria", new ControlloAccesso
            {
                BadgeValido = true,
                RetinaValidata = false,
                CodiceDnaCorretto = false,
                ImprontaDigitaleCorretta = false,
                LivelloAutorizzazione = 1,
                OrarioConsentito = true,
                GiorniInAzienda = 210.4,
                LavoraATorino = false,
                StatoDiBlackout = false,
                StatoDiEmergenza = false,
                CodiceInserito = "1970"
            }, LivelloAccesso.Negato));

            AggiornaStatistiche(EseguiTest("Accesso negato per verifica manuale in corso", new ControlloAccesso
            {
                BadgeValido = true,
                RetinaValidata = true,
                CodiceDnaCorretto = true,
                ImprontaDigitaleCorretta = true,
                LivelloAutorizzazione = 3,
                OrarioConsentito = true,
                GiorniInAzienda = 100.4,
                LavoraATorino = true,  // blocco
                StatoDiBlackout = false,
                StatoDiEmergenza = false,
                CodiceInserito = "1234"
            }, LivelloAccesso.Negato));

            DisplayHelper.MostraRisultati("Exercises on access control", testEffettuati, testSuperati);
        }

        private void AggiornaStatistiche(bool risultatoDelTest)
        {
            testSuperati += risultatoDelTest ? 1 : 0;
            testEffettuati++;
        }

        private bool EseguiTest(string nome, ControlloAccesso configurazione, LivelloAccesso atteso)
        {
            var risultato = ControlloAccessoHelper.VerificaAccesso(configurazione);
            var success = risultato == atteso;
            Console.WriteLine($"[{nome}] => {(success? "✔ SUCCESSO" : $"✘ FALLITO\n  Atteso: {atteso}\n  Ottenuto: {risultato}")}");
            return success;
        }
    }
}
