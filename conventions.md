# Code Conventies voor 18+ Mario Adventure Game

Dit document beschrijft de codeconventies die gevolgd moeten worden voor de `18+ Mario Adventure`-codebase. Deze richtlijnen zorgen ervoor dat de code consistent, leesbaar en onderhoudbaar blijft.

## 1. Namen van klassen en namespaces

- Gebruik **PascalCase** voor de namen van klassen en namespaces.
- Kies beschrijvende en specifieke namen die duidelijk aangeven wat de klasse of namespace doet.
  
**Voorbeeld:**
```csharp
namespace MarioAdventure
{
    class MarioAdventureGame
    {
    }
}
2. Methodenamen
Gebruik PascalCase voor methodenamen.
Methodebenamingen moeten beschrijven welke actie de methode uitvoert. Begin altijd met een werkwoord.
Voorbeeld:


static void StartGame() 
{
}

static void ShowInstructions() 
{
}
3. Variabelen en parameters
Gebruik camelCase voor lokale variabelen en methodparameters.
Kies beschrijvende namen die de betekenis van de variabele weergeven. Vermijd te korte of nietszeggende namen, zoals x of y, tenzij het gaat om veelgebruikte conventies (bijvoorbeeld in wiskundige formules).
Voorbeeld:


string userInput = Console.ReadLine();
int playerHealth = 100;
4. Commentaar
Schrijf commentaar in het Nederlands om de bedoeling van de code uit te leggen, vooral bij complexe logica of beslissingen.
Vermijd overbodig commentaar bij eenvoudige of vanzelfsprekende stukken code.
Voorbeeld:


// Deze methode start het spel en toont het hoofdmenu
static void MainMenu() 
{
}
5. Indentatie en witruimte
Gebruik altijd 4 spaties voor inspringing.
Voeg lege regels toe tussen methoden en logische blokken om de leesbaarheid te verbeteren.
Voorbeeld:


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
Voer altijd invoervalidatie uit wanneer de gebruiker keuzes maakt. Bij ongeldige invoer moet de methode opnieuw worden aangeroepen.
Geef duidelijke foutmeldingen weer voor de gebruiker.
Voorbeeld:


if (keuze != "1" && keuze != "2" && keuze != "3")
{
    Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
    MainMenu();  // Herhaal de methode
}
7. Gebruik van return statements
Gebruik return om de verdere uitvoering van een methode te stoppen na een fout of ongeldige invoer. Vermijd onnodige code-uitvoering.
Voorbeeld:


if (keuze != "1" && keuze != "2")
{
    Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
    World1_1();
    return;  // Stop verdere uitvoering
}
8. Taalgebruik in het spel
Consistentie is belangrijk, ook in het taalgebruik. Als het spel een bepaalde toon of stijl hanteert (zoals grof taalgebruik), moet dit consequent doorgevoerd worden in de spelteksten en dialogen.
9. Gebruik van constanten
Gebruik constanten voor waarden die vaak in de code voorkomen om de leesbaarheid en het onderhoud te verbeteren.
Voorbeeld:


const string exitMessage = "Het spel wordt afgesloten. Tot ziens!";
Console.WriteLine(exitMessage);
10. Structuur en organisatie
Houd de structuur van het project overzichtelijk door gerelateerde methoden en logica samen te groeperen in dezelfde klasse of namespace.
Methoden die een vergelijkbare taak uitvoeren, moeten bij elkaar worden gehouden.
Deze conventies zorgen ervoor dat de code overzichtelijk en consistent blijft, wat de samenwerking en uitbreiding van het project vergemakkelijkt.

perl
Copy code

Met dit `.md`-bestand kunnen jouw codeconventies eenvoudig worden gedocumenteerd en gedeeld met andere ontwikkelaars die aan het project werken.
