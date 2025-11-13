### Exercici 6
Has de crear un sistema que generi mapes on les caselles tenen propietats diferents segons la posició de la seva fila i columna (no segons el valor emmagatzemat). Les regles es basen en si les posicions són parells o senars.


1. #### Array Unidimensional (Tropes): 
Crea un array de 10 elements que representi una fila de caselles on es despleguen tropes.
 - Les posicions parells (0, 2, 4...) són "Zones Defensives" (imprimeix Q).
 - Les posicions senars (1, 3, 5...) són "Zones d'Atac" (imprimeix X).
2. #### Matriu Bidimensional (Mapa):
Crea una matriu 5x5 que representi el terreny de joc.
 - Si fila i columna són parells: "Torre de Guaita" (imprimeix T).
 - Si fila i columna són senars: "Cova Amagada" (imprimeix o).
 - Altres casos: "Terreny Neutral" (imprimeix Y).
3. #### Jagged Array (Regions):
Crea un jagged array amb 3 files, on la primera fila té 4 columnes, la segona 2 i la tercera 3.
 - Posicions on fila + columna és senar: "Recurs Extra" (imprimeix V).
 - Posicions on fila + columna és parell: "Terreny Buit" (imprimeix -).
