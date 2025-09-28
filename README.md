# Dagboksappen

Dagboksappen �r en enkel dagboksapplikation d�r du kan skriva, spara och l�sa dagboksanteckningar.

## S� h�r k�r du appen

1. Klona eller ladda ner projektet till din dator.
2. �ppna projektet i Visual Studio.
3. Bygg projektet (Ctrl+Shift+B).
4. Starta applikationen genom att trycka p� F5 eller klicka p� "Starta"-knappen.

Appen kr�ver .NET 8.0 eller senare.

## I/O

Input:

Vad har du p� hj�rtat idag?
Hej dagboken. Idag har jag skrivit ett j�ttebra program som ingen kommer anv�nda.

Output:

Alla dagboksinl�gg:

2025-09-28
(14:25) Hej dagboken. Idag har jag skrivit ett j�ttebra program som ingen kommer anv�nda.
(14:26) Men det g�r inget s� l�nge jag f�r VG.

## Reflektion

I b�rjan anv�nde jag en List<DiaryEntry> f�r att lagra dagboksinl�ggen i med en DateTime och
en textstr�ng i DiaryEntry, men i sista committen n�r allt annat var klart och jag vill l�gga
till en raderingsfunktion, s� ins�g jag att det var mycket enklare att bara anv�nda en
Dictionary<DateTime, DiaryEntry> d�r DateTime �r nyckeln. D� kan jag enkelt ta bort inl�gg
samt appenda ny text (+ klockslag) till ett befintligt inl�gg utan att skapa ett helt nytt
objekt som l�ggs in i en lista.

Jag har anv�nt mig av filhantering bara en g�ng f�rut, och jag k�nner mig inte alls hemma
med varken det eller Dictionary, s� det har varit en utmaning att f� ihop allt. Jag fick brottas
med syntaxen en del, och tog hj�lp av Copilot, men till slut verkar det ha blivit relativt
stabilt. Jag lade �ven till error log-hantering i sista committen.