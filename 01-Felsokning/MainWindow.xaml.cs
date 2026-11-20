using System.Windows;

namespace Felsokning_lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    ///
    /// Övning 1–5 innehåller 1–3 inbyggda fel var. Koden KOMPILERAR men ger FEL SVAR.
    /// Studenternas uppgift är att hitta och förklara felen.
    /// Övning 6 är tom – studenten ska själv skriva nästlade loopar.
    ///
    /// Facit finns i FACIT.md.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // ---------- Övning 1 – Medelvärde ----------
        // Rätt svar för 2, 3, 4, 5, 7 ska vara 4,2.
        private void OnEx1Click(object sender, RoutedEventArgs e)
        {
            int[] talen = { 2, 3, 4, 5, 7 };

            int summan = 0;
            for (int i = 0; i < talen.Length; i++)
            {
                summan = summan + talen[i];
            }

            double medelvardet = summan / talen.Length;

            txtResult1.Text = $"Programmet säger: medelvärdet är {medelvardet}";
        }

        // ---------- Övning 2 – Summera talen 1 till N ----------
        // Rätt svar för N = 5 ska vara 15.
        private void OnEx2Click(object sender, RoutedEventArgs e)
        {
            int slutTal = int.Parse(txtInput2.Text);

            int summan = 0;
            for (int i = 1; i < slutTal; i++)
            {
                summan = i;
            }

            txtResult2.Text = $"Programmet säger: summan är {summan}";
        }

        // ---------- Övning 3 – Hitta största talet ----------
        // Rätt svar för 4, 9, 2, 15, 7 ska vara 15.
        private void OnEx3Click(object sender, RoutedEventArgs e)
        {
            int[] talen = { 4, 9, 2, 15, 7 };

            int storstaTalet = 0;
            for (int i = 0; i < talen.Length; i++)
            {
                if (talen[i] < storstaTalet)
                {
                    storstaTalet = talen[i];
                }
            }

            txtResult3.Text = $"Programmet säger: största talet är {storstaTalet}";
        }

        // ---------- Övning 4 – Räkna de jämna talen ----------
        // Rätt svar för 2, 4, 5, 6, 7 ska vara 3.
        private void OnEx4Click(object sender, RoutedEventArgs e)
        {
            int[] talen = { 2, 4, 5, 6, 7 };

            int antalJamnaTal = 0;
            for (int i = 0; i < talen.Length; i++)
            {
                if (talen[i] % 2 == 1)
                {
                    antalJamnaTal = antalJamnaTal + 1;
                }
            }

            txtResult4.Text = $"Programmet säger: det finns {antalJamnaTal} jämna tal";
        }

        // ---------- Övning 5 – Omvandla Celsius till Fahrenheit ----------
        // För 27 °C ska rätt svar vara 80,6 °F och "Det är varmt".
        private void OnEx5Click(object sender, RoutedEventArgs e)
        {
            int celsius = int.Parse(txtInput5.Text);

            double fahrenheit = celsius * 9 / 5 + 32;

            string meddelande;
            if (celsius >= 80)
            {
                meddelande = "Det är varmt.";
            }
            else
            {
                meddelande = "Det är inte varmt.";
            }

            txtResult5.Text = $"Programmet säger: {fahrenheit} °F. {meddelande}";
        }

        // ---------- Övning 6 – Nästlade loopar (skriv koden själv) ----------
        // Uppgift: rita en rätvinklig triangel av stjärnor med höjden N
        // med hjälp av TVÅ nästlade for-loopar. Skriv resultatet till txtResult6.
        private void OnEx6Click(object sender, RoutedEventArgs e)
        {
            int hojd = int.Parse(txtInput6.Text);

            // TODO: Skriv din kod här med två nästlade for-loopar.
            // Den yttre loopen styr antalet rader (1 till hojd).
            // Den inre loopen skriver ut rätt antal stjärnor på varje rad.

            txtResult6.Text = "Här ska din triangel visas.";
        }
    }
}
