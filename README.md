# Dagboksappen

Dagboksappen är en enkel dagboksapplikation där du kan skriva, spara och läsa dagboksanteckningar.

## Så här kör du appen

1. Klona eller ladda ner projektet till din dator.
2. Öppna projektet i Visual Studio.
3. Bygg projektet (Ctrl+Shift+B).
4. Starta applikationen genom att trycka på F5 eller klicka på "Starta"-knappen.

Appen kräver .NET 8.0 eller senare.

## I/O

Input:

Vad har du på hjärtat idag?
Hej dagboken. Idag har jag skrivit ett jättebra program som ingen kommer använda.

Output:

Alla dagboksinlägg:

2025-09-28
(14:25) Hej dagboken. Idag har jag skrivit ett jättebra program som ingen kommer använda.
(14:26) Men det gör inget så länge jag får VG.

## Reflektion

I början använde jag en List<DiaryEntry> för att lagra dagboksinläggen i med en DateTime och
en textsträng i DiaryEntry, men i sista committen när allt annat var klart och jag vill lägga
till en raderingsfunktion, så insåg jag att det var mycket enklare att bara använda en
Dictionary<DateTime, DiaryEntry> där DateTime är nyckeln. Då kan jag enkelt ta bort inlägg
samt appenda ny text (+ klockslag) till ett befintligt inlägg utan att skapa ett helt nytt
objekt som läggs in i en lista.

Jag har använt mig av filhantering bara en gång förut, och jag känner mig inte alls hemma
med varken det eller Dictionary, så det har varit en utmaning att få ihop allt. Jag fick brottas
med syntaxen en del, och tog hjälp av Copilot, men till slut verkar det ha blivit relativt
stabilt. Jag lade även till error log-hantering i sista committen.