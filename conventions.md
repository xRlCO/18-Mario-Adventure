1. Namen van klassen en namespaces
Gebruik PascalCase voor de namen van klassen en namespaces.
Houd de naamgeving beschrijvend en specifiek. Gebruik geen nietszeggende of onduidelijke namen.
Voorbeeld:

csharp
Copy code
namespace MarioAdventure
{
    class MarioAdventureGame
    {
    }
}
2. Methodenamen
Gebruik ook hier PascalCase voor methodenamen.
Methodebenamingen moeten duidelijk de actie beschrijven die de methode uitvoert. Gebruik werkwoorden aan het begin van de naam.
Voorbeeld:

csharp
Copy code
static void StartGame() 
{
}

static void ShowInstructions() 
{
}
3. Variabelen en parameters
Gebruik camelCase voor lokale variabelen en methodparameters.
Houd de variabelen zo beschrijvend mogelijk en vermijd te korte, nietszeggende namen zoals x, y, tenzij ze een algemene betekenis hebben in de context (zoals in wiskundige berekeningen).
Voorbeeld:

csharp
Copy code
string userInput = Console.ReadLine();
int playerHealth = 100;
4. Commentaar
Schrijf beschrijvend commentaar in het Nederlands waar nodig. Gebruik geen commentaar voor overduidelijke zaken, maar wel voor complexe logica of waar context nodig is.
Voorbeeld:

csharp
Copy code
// Deze methode start het spel en toont het hoofdmenu
static void MainMenu() 
{
}
5. Indentatie en witruimte
Gebruik consistent 4 spaties voor inspringing.
Houd methoden en logische blokken gescheiden door lege regels te gebruiken voor betere leesbaarheid.
Voorbeeld:

csharp
Copy code
static void MainMenu()
{
    Console.WriteLine("Welkom bij het Mario Adventure-spel!");

    string keuze = Console.ReadLine();

    if (keuze == "1")
    {
        StartGame();
    }
    else if (keuze == "2")
    {
        ShowInstructions();
    }
}
6. Foutenafhandeling en invoervalidatie
Voorzie altijd in invoervalidatie wanneer de gebruiker keuzes moet maken. Roep de methode opnieuw aan bij een ongeldige keuze.
Bied duidelijke foutmeldingen voor de gebruiker.
Voorbeeld:

csharp
Copy code
if (keuze != "1" && keuze != "2" && keuze != "3")
{
    Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
    MainMenu();  // Herhaal de methode
}
7. Gebruik van return statements
Gebruik return om de verdere uitvoering van een methode te stoppen na een fout, en vermijd onnodige code-uitvoering.
Voorbeeld:

csharp
Copy code
if (keuze != "1" && keuze != "2")
{
    Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
    World1_1();
    return;  // Stop verdere uitvoering
}
8. Taalgebruik in het spel
Hoewel de conventies de code zelf betreffen, dient ook het taalgebruik richting de gebruiker consequent te zijn. Als het spel bijvoorbeeld grof taalgebruik bevat, moet dit in de tekstconsistentie en toon gehandhaafd blijven.
9. Gebruik van constanten
Maak gebruik van constanten voor vaste waarden die vaak in de code voorkomen.
Voorbeeld:

csharp
Copy code
const string exitMessage = "Het spel wordt afgesloten. Tot ziens!";
Console.WriteLine(exitMessage);
Door deze conventies te volgen, zorg je ervoor dat de code overzichtelijk, begrijpelijk en onderhoudbaar blijft, wat samenwerking en uitbreidingen gemakkelijker maakt.
