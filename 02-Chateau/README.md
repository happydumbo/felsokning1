# Château- och Amarone-viner

## Uppgift
Du har en lista (array) med vinnamn i programmet. Det finns **två knappar**:

- **Räkna Château** – räkna hur många viner som har ett namn som innehåller "chateau".
- **Räkna båda** – räkna hur många som innehåller "chateau" **och** hur många som innehåller "amarone".

Skriv din kod i metoderna `OnCountChateauClick` och `OnCountBothClick` i `MainWindow.xaml.cs`.

### Exempel
Med vinerna som finns i programmet är rätt svar **6 Château-viner** och **3 Amarone-viner**.

## Mål
- Träna på att **loopa igenom en array**.
- Använda en **sträng-metod** för att söka efter text.
- Använda en och flera **räknare** (`int`).

## Tips
- Gå igenom (loopa) alla viner i listan – en i taget.
- Kontrollera om ett namn **innehåller** ett visst ord.
  - Det finns en färdig sträng-metod som letar efter text.
  - Tänk på stora/små bokstäver – det finns en metod som gör om text till små bokstäver innan du jämför.
- **Räkna Château:** en räknare, ett villkor.
- **Räkna båda:** samma loop, men **två räknare** och **två villkor**.

> I konstruktorn finns redan en loop som visar vinerna i listan – titta på den som exempel.

### Pseudokod – räkna båda

```
antalChateau = 0
antalAmarone = 0
för varje vin i listan:
    namn = vinets namn i små bokstäver
    om namn innehåller "chateau":
        antalChateau = antalChateau + 1
    om namn innehåller "amarone":
        antalAmarone = antalAmarone + 1
visa antalChateau och antalAmarone
```
