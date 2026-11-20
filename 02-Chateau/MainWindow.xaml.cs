using System.Windows;

namespace Chateau_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    ///
    /// Två uppgifter / två knappar:
    ///   - "Räkna Château": räkna bara viner som innehåller "chateau".
    ///   - "Räkna båda":    räkna både "chateau" och "amarone".
    /// Skriv din kod i OnCountChateauClick och OnCountBothClick.
    ///
    /// Facit finns i FACIT.md.
    /// </summary>
    public partial class MainWindow : Window
    {
        // Listan (arrayen) med vinnamn.
        // Rätt svar: 6 Château-viner och 3 Amarone-viner.
        private string[] _viner =
        {
            "Chateau Margaux",
            "Barolo Riserva",
            "Chateau Latour",
            "Rioja Gran Reserva",
            "Chateau Mouton Rothschild",
            "Amarone della Valpolicella",
            "Chateau Lafite Rothschild",
            "Chianti Classico",
            "Amarone Classico",
            "Chateau Haut-Brion",
            "Pinot Noir Reserve",
            "Amarone della Valpolicella Riserva",
            "Chateau d'Yquem",
            "Nebbiolo Langhe"
        };

        public MainWindow()
        {
            InitializeComponent();

            // Exempel på en loop: här går vi igenom arrayen och
            // visar varje vin i listan. En liknande loop behöver du
            // själv skriva i knapparna nedan.
            foreach (string vin in _viner)
            {
                lstViner.Items.Add(vin);
            }
        }

        // Knapp 1 – räkna BARA Château-viner.
        private void OnCountChateauClick(object sender, RoutedEventArgs e)
        {
            int antalChateau = 0;

            // TIPS (pseudokod):
            //   Gå igenom (loopa) alla viner i _viner – en i taget.
            //   För varje vin: om namnet innehåller "chateau", öka antalChateau med 1.
            //   Det finns en sträng-metod som letar efter text, och en som gör
            //   om texten till små bokstäver innan du jämför.
            //
            // TODO: skriv din loop här.

            txtResult.Text = $"Antal Château-viner: {antalChateau}";
        }

        // Knapp 2 – räkna BÅDE Château- och Amarone-viner.
        private void OnCountBothClick(object sender, RoutedEventArgs e)
        {
            int antalChateau = 0;
            int antalAmarone = 0;

            // TIPS (pseudokod):
            //   Samma loop som ovan, men kontrollera TVÅ saker för varje vin:
            //     - innehåller namnet "chateau"? -> öka antalChateau
            //     - innehåller namnet "amarone"? -> öka antalAmarone
            //   Du behöver alltså två räknare men fortfarande bara en loop.
            //
            // TODO: skriv din loop här.

            txtResult.Text = $"Antal Château-viner: {antalChateau}\nAntal Amarone-viner: {antalAmarone}";
        }
    }
}
