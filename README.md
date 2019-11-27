oe-lussen-oefeningen-start
# Oefeningen op lussen
In deze solution zitten verschillende projecten. 
De opdrachten zijn te lezen op de GUI en/of in commentaar in de code behind
Om een bepaald project op te starten:
- Selecteer het project
- Klik erop met de rechter muisknop
- Kies *Set as StartUp project*
# Oefening Lotto
Bij deze oefening hoort wat meer uitleg.
##	Doelstelling
We simuleren een Lotto-trekking en het raden van de getrokken getallen.

Het aantal te raden getallen en het hoogste getal kan gekozen worden via comboboxen.
##	Opstarten
- De listbox met het aantal getallen wordt opgevuld met de getallen van 1 – 6.
- De listbox met het hoogste getal wordt opgevuld met de getallen van 1 – 45.
- In elk van de lijsten wordt het eerste element geselecteerd.
##	Methodes
### GeefWillekeurigeGetallen
Op basis van 
- het aantal te raden getallen, 
- het hoogste te raden getal en 
- een parameter die aangeeft of de getallen uniek moeten zijn, 
wordt een array met getallen opgevuld.

De aangemaakte array wordt gesorteerd en daarna geretourneerd.
### RaadGetallen
Op basis van een array met getallen en een max. getal wordt gepoogd om de reeks van de getallen te raden.

M.a.w. de computer maakt telkens een array aan met hetzelfde aantal elementen als de doorgegeven array, rekening houdend met het max. getal. Deze array wordt dan vergeleken met de te raden array.

Het aantal pogingen wordt bijgehouden.

Er wordt een list van strings opgebouwd met de gegokte getallen (gescheiden door koppeltekens). 

Deze list wordt geretourneerd.
### RadenKan
Deze methode zal op basis van een parameter die aanduidt of raden toegelaten is de buttons btnTrekking en btnRaden in- of uitschakelen.
##	Event Handler Methodes
### btnTrekking
- Verzamelt de nodige info om GeefWilleKeurigeGetallen te kunnen callen. 
- Daarna wordt deze button uitgeschakeld en btnRaden ingeschakeld.
### btnRaden
- Verzamelt de nodige info om RaadGetallen te kunnen callen. 
- De return wordt toegevoegd aan lstTrekkingen.
- Daarna wordt deze button ingeschakeld en btnRaden uitgeschakeld.
