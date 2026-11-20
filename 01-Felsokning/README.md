# Felsökning & nästlade loopar

Det här är en övningsapp i WPF (C#) med två sorters uppgifter:

- **Övning 1–5: Finn felen.** Varje övning innehåller **1–3 inbyggda fel**. Koden *kompilerar och går att köra*, men den ger **fel svar**. Din uppgift är att hitta felen, förklara *varför* de ger fel svar, och rätta dem.
- **Övning 6: Skriv själv.** Här finns ingen färdig lösning. Du ska skriva **nästlade for-loopar**.

## Så här gör du

1. Starta programmet (tryck F5 i Visual Studio, eller `dotnet run`).
2. Varje övning har en egen flik. Läs beskrivningen och tryck på **Kör**.
3. Jämför programmets svar med det **rätta svaret** som står i beskrivningen.
4. Öppna `MainWindow.xaml.cs` och leta upp metoden för övningen (t.ex. `OnEx1Click`).
5. Hitta felet/felen, rätta dem, kör igen och kontrollera att svaret nu stämmer.

## Övningarna

| # | Flik | Ska göra | Rätt svar |
|---|------|----------|-----------|
| 1 | Medelvärde | Medelvärdet av 2, 3, 4, 5, 7 | **4,2** |
| 2 | Summera 1–N | Summan av 1 till N (N = 5) | **15** |
| 3 | Största talet | Största talet i 4, 9, 2, 15, 7 | **15** |
| 4 | Räkna jämna | Antal jämna tal i 2, 4, 5, 6, 7 | **3** |
| 5 | Celsius → Fahrenheit | 27 °C till °F + "varmt?" (≥ 80 °F) | **80,6 °F, Det är varmt** |
| 6 | Nästlade loopar | Rita en triangel av stjärnor (höjd N) | *(skriv själv)* |

## Tips för felsökning

- Läs koden **långsamt, rad för rad**. Vad händer egentligen i varje steg?
- Vanliga fel att hålla utkik efter:
  - **Heltalsdivision** – `/` mellan två heltal avrundar bort decimalerna.
  - **Fel startvärde** på en variabel.
  - **Off-by-one** – `<` istället för `<=` i en loop.
  - **Fel operator** – `=` istället för `+=`, `<` istället för `>`, `== 1` istället för `== 0`.
  - **Fel variabel** används i ett villkor.

> Facit finns i `FACIT.md` (för lärare).
