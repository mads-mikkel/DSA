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

Et problem har karakter af være et træ, når der er en *rod*, og denne rod forgrener sig til grene, som igen forgrener sig hver især til flere grene, osv., dog ikke uendeligt:

![alt text][tree]

[tree]: https://upload.wikimedia.org/wikipedia/commons/2/24/Nonac_16_Noyer_novembre_2013.jpg "Træ med mange grene, der har grene, der har grene..." 

Tilbagesporing betyder, blot at man går tilbage præcis den vej man kom. Man kunne forestille sig, at man er et egern i træet der leder efter en nød. Først går man op ad stammen og ud på en gren, men finder ikke nøden. I stedet for at gå ned på jorden igen, for at prøve en ny gren, går man tilbage ad den gren man er på, og ud på en ny gren - og så videre og så videre. Lad os antage at man finder nøden efter at have besøgt ni grene. I stedet for at gå ned af træet når nøden er fundet, går egernet tilbage til de besøgte grene, i den modsatte rækkefølge de blev besøgt i første gang. Og i stedet for at ud på hver gren, nøjes egernet bare med at kigge ud på grenen og ægre sig over, at nøden ikke blev fundet her. Egernet går videre til næste gren, kigger ud ad den, ægrer sig igen, og går videre. Da egernet kom ned ad træet, blev den glad igen, da den jo havde fundet en nød.


> Rekursion implementeres med en base case og en rekursiv case

En *base case* stopper rekursionen. En *rekursiv case* kalder funktionen (metoden) fra funktionen selv. Der skal altid være mindst én base case, og mindst én rekursiv case.

Se denne video:

<a href="http://www.youtube.com/watch?feature=player_embedded&v=AfBqVVKg4GE
" target="_blank"><img src="http://img.youtube.com/vi/AfBqVVKg4GE/0.jpg" 
alt="Recursion for Beginners: A Beginner's Guide to Recursion" width="240" height="180" border="10" /></a>

## Opgaver
<ol>
 <li> Lav et program der beregner 
</ol>