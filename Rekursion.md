# REKURSION
Denne opgave knytter sig til følgende læringsmål:
* Jeg har viden om hvordan rekursion virker og adskiller sig fra iteration
* Jeg kan lave rekursive algoritmer

## Viden
> *"Alt hvad du kan med rekursion, kan du med en løkke og en stak"*

Rekursion løser problemer hvor begge disse betingelser er til stede:
<ol>
    <li>Problemet har karakter af at være et træ.
    <li>Problemet kræver tilbagesporing.
</ol>

Et problem har karakter af være et træ, når der er en *rod*, og denne rod forgrener sig til grene, som igen forgrener sig hver især til flere grene, osv., dog ikke uendeligt: [Træ med mange grene, der har grene, der har grene...](https://commons.wikimedia.org/wiki/Category:Quality_images_of_Juglans#/media/File:Nonac_16_Noyer_novembre_2013.jpg)

Tilbagesporing betyder, blot at man går tilbage præcis den vej man kom. Man kunne forestille sig, at man er et egern i træet der leder efter en nød. Først går man op ad stammen og ud på en gren, men finder ikke nøden. I stedet for at gå ned på jorden igen, for at prøve en ny gren, går man tilbage ad den gren man er på, og ud på en ny gren - og så videre og så videre. Lad os antage at man finder nøden efter at have besøgt ni grene. I stedet for at gå ned af træet når nøden er fundet, går egernet tilbage til de besøgte grene, i den modsatte rækkefølge de blev besøgt i første gang. Og i stedet for at ud på hver gren, nøjes egernet bare med at kigge ud på grenen og ærgre sig over, at nøden ikke blev fundet her. Egernet går videre til næste gren, kigger ud ad den, ærgrer sig igen, og går videre. Da egernet kom ned ad træet, blev den glad igen, da den jo havde fundet en nød.


> Rekursion implementeres med en base case og en rekursiv case

En *base case* stopper rekursionen. En *rekursiv case* kalder funktionen (metoden) fra funktionen selv. Der skal altid være mindst én base case, og mindst én rekursiv case.

Se denne video:

<a href="http://www.youtube.com/watch?feature=player_embedded&v=AfBqVVKg4GE
" target="_blank"><img src="http://img.youtube.com/vi/AfBqVVKg4GE/0.jpg" 
alt="Recursion for Beginners: A Beginner's Guide to Recursion" width="240" height="180" border="10" /></a>


## Opgaver
1. Lav et program der rekursivt beregner *n!* for *n* op til 14. Dit output skal se således ud:
```
1: 1
2: 2
3: 6
4: 24
5: 120
6: 720
7: 5040
8: 40320
9: 362880
10: 3628800
11: 39916800
12: 479001600
13: 1932053504
14: 1278945280
```
Her er anvendt en iteration, der for hver *n* kalder fakultetfunktionen og udskriver til konsollen. Signaturen på fakultetsfunktionen er 
```cs
int Faculty(int n)
```
Observér 14. iteration, hvad sker der mon her? Giv et bud og tilret koden, således output er korrekt for 21 iterationer.


 

## Ekstraopgaver
A. Tilret opgave 1 således at der kan foretages flere tusinde iterationer med korrekt output. *Hint: `System.Numerics`*.
