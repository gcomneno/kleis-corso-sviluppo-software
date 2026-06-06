# Pre-test C#

## Obiettivo

Questa esercitazione serve per ripassare i concetti C# studiati finora.

Non è un test ufficiale.

È una palestra di ripasso.

## Istruzioni

Per ogni domanda scegli una sola risposta corretta.

Le soluzioni commentate sono nel file separato:

- [SOLUZIONI_CSHARP.md](./SOLUZIONI_CSHARP.md)

---

# Domande

## 1. A cosa serve `Console.WriteLine()`?

A. A leggere un valore da tastiera  
B. A stampare testo andando a capo  
C. A convertire una stringa in numero  
D. A creare un array  

## 2. Qual è la differenza principale tra `Console.Write()` e `Console.WriteLine()`?

A. `Write()` stampa e va a capo, `WriteLine()` no  
B. `Write()` non va a capo, `WriteLine()` sì  
C. Sono identici  
D. `WriteLine()` legge input utente  

## 3. Cosa restituisce `Console.ReadLine()`?

A. Sempre un `int`  
B. Sempre un `bool`  
C. Una stringa oppure `null`  
D. Un array  

## 4. Quale tipo useresti per un numero intero?

A. `string`  
B. `bool`  
C. `int`  
D. `double[]`  

## 5. Quale tipo useresti per un valore vero/falso?

A. `bool`  
B. `int`  
C. `string`  
D. `char[]`  

## 6. Quale tipo useresti per testo?

A. `int`  
B. `string`  
C. `double`  
D. `bool`  

## 7. Cosa fa `int.Parse()`?

A. Converte una stringa in intero, ma può generare errore  
B. Stampa un numero  
C. Legge un array  
D. Crea una stringa vuota  

## 8. Perché `int.TryParse()` è più sicuro con input utente?

A. Perché non accetta numeri  
B. Perché evita eccezioni e restituisce `true` o `false`  
C. Perché stampa automaticamente il risultato  
D. Perché crea un ciclo `for`  

## 9. Cosa rappresenta `out number` in `int.TryParse(input, out number)`?

A. Il valore convertito viene scritto nella variabile `number`  
B. La variabile viene cancellata  
C. Il programma termina  
D. Il valore viene stampato a video  

## 10. A cosa serve `if`?

A. A ripetere codice sempre  
B. A eseguire codice solo se una condizione è vera  
C. A creare un metodo  
D. A dichiarare un array  

## 11. A cosa serve `else`?

A. A gestire il caso alternativo quando l'`if` è falso  
B. A creare una variabile  
C. A leggere input  
D. A ordinare un array  

## 12. Quando può essere utile `switch`?

A. Quando devo confrontare un valore con più casi possibili  
B. Quando devo creare sempre un array  
C. Quando devo stampare solo una riga  
D. Quando devo evitare tutti i controlli  

## 13. A cosa serve un ciclo `for`?

A. A ripetere codice un numero controllato di volte  
B. A dichiarare una costante  
C. A creare un namespace  
D. A convertire stringhe  

## 14. A cosa serve un ciclo `while`?

A. A ripetere codice finché una condizione resta vera  
B. A stampare sempre andando a capo  
C. A creare una classe  
D. A dichiarare un tipo  

## 15. Qual è una caratteristica del `do while`?

A. Il blocco viene eseguito almeno una volta  
B. Non esegue mai il blocco  
C. Serve solo per gli array  
D. Non usa condizioni  

## 16. A cosa serve `foreach`?

A. A iterare sugli elementi di una collezione senza gestire manualmente l'indice  
B. A leggere una stringa da tastiera  
C. A convertire un numero  
D. A creare un metodo statico  

## 17. Cos'è un array?

A. Una collezione di valori dello stesso tipo  
B. Una singola stringa obbligatoria  
C. Un metodo senza parametri  
D. Un errore di compilazione  

## 18. Cosa significa `int[] numbers = new int[10];`?

A. Crea un array di 10 interi  
B. Crea una stringa lunga 10 caratteri  
C. Crea 10 metodi  
D. Crea un ciclo infinito  

## 19. Qual è il primo indice di un array in C#?

A. 1  
B. 0  
C. -1  
D. Dipende dal nome dell'array  

## 20. Se un array ha lunghezza 10, qual è l'ultimo indice valido?

A. 10  
B. 9  
C. 11  
D. 1  

## 21. A cosa serve `numbers.Length`?

A. A conoscere quanti elementi contiene l'array  
B. A cancellare l'array  
C. A convertire l'array in stringa  
D. A stampare tutti gli elementi automaticamente  

## 22. A cosa serve un metodo?

A. A raggruppare codice riutilizzabile con una responsabilità chiara  
B. A nascondere sempre gli errori  
C. A evitare del tutto le variabili  
D. A creare solo output grafico  

## 23. Cosa sono i parametri di un metodo?

A. Valori passati al metodo per farlo lavorare  
B. Errori del compilatore  
C. Nomi obbligatori dei file  
D. Solo commenti  

## 24. Cosa indica il tipo di ritorno di un metodo?

A. Il tipo di valore restituito dal metodo  
B. Il colore dell'output  
C. Il numero di righe del file  
D. Il nome del progetto  

## 25. Cosa significa `void`?

A. Il metodo non restituisce un valore  
B. Il metodo restituisce sempre `int`  
C. Il metodo è vietato  
D. Il metodo crea un array  

## 26. Cosa fa `return`?

A. Restituisce un valore e può terminare il metodo  
B. Stampa sempre a video  
C. Legge input utente  
D. Crea una variabile globale  

## 27. A cosa serve l'operatore ternario `condizione ? valore1 : valore2`?

A. A scrivere condizioni semplici in forma compatta  
B. A creare tre array  
C. A sostituire sempre tutti gli `if`  
D. A leggere tre valori da tastiera  

## 28. Quando è meglio evitare il ternario?

A. Quando la logica è complessa o poco leggibile  
B. Sempre, è vietato  
C. Solo con le stringhe  
D. Solo dentro un array  

## 29. Cosa significa validare l'input?

A. Controllare che il valore inserito dall'utente sia accettabile  
B. Fidarsi sempre dell'utente  
C. Stampare il valore senza controlli  
D. Convertire tutto in `bool`  

## 30. Cosa significa validazione semantica?

A. Controllare che il valore abbia senso per il problema  
B. Controllare solo che il programma compili  
C. Cambiare il colore del testo  
D. Usare sempre `Parse`  

## 31. Nell'esercizio del triangolo, perché i lati negativi non vanno accettati?

A. Perché non hanno senso come lunghezze geometriche  
B. Perché C# non supporta numeri negativi  
C. Perché `int` non può essere negativo  
D. Perché `Console.ReadLine()` li cancella  

## 32. A cosa serve una costante come `const int MAX_ELEMENTS = 10;`?

A. A dare un nome chiaro a un valore che non deve cambiare  
B. A creare un metodo  
C. A leggere input  
D. A rendere il programma più lento  

## 33. Perché è utile un `Main` leggibile?

A. Per capire il flusso generale del programma come una storia  
B. Per nascondere tutto il codice  
C. Per evitare i metodi  
D. Per usare solo variabili globali  

## 34. Cosa significa top-down design?

A. Dividere un problema grande in problemi più piccoli  
B. Scrivere tutto nel `Main`  
C. Partire dagli errori del compilatore  
D. Evitare i nomi descrittivi  

## 35. Perché metodi piccoli sono utili?

A. Perché hanno responsabilità più chiare e sono più leggibili  
B. Perché C# vieta metodi lunghi  
C. Perché non possono avere parametri  
D. Perché non possono restituire valori  

## 36. Cosa significa naming leggibile?

A. Usare nomi che spiegano l'intenzione del codice  
B. Usare nomi casuali molto brevi  
C. Usare solo lettere singole  
D. Scrivere tutto in maiuscolo sempre  

## 37. Quale nome è più leggibile per un metodo che calcola la media?

A. `x()`  
B. `DoStuff()`  
C. `CalculateAverage()`  
D. `AAA()`  

## 38. Cosa significa separare le responsabilità?

A. Ogni funzione dovrebbe avere un compito chiaro e limitato  
B. Tutto deve stare nello stesso metodo  
C. Il codice non deve usare metodi  
D. Gli input non devono essere controllati  

## 39. Quali funzioni sono più vicine alla business logic?

A. `CalculateAverage`, `CalculateMinimum`, `ContainsValue`  
B. `Console.WriteLine` e basta  
C. `Console.ReadLine` e basta  
D. Il nome del file `.csproj`  

## 40. Cosa succede se una funzione genera un errore non gestito?

A. Il flusso normale si interrompe e il programma termina con errore  
B. Il programma continua sempre senza problemi  
C. L'errore viene ignorato automaticamente  
D. Il metodo diventa una stringa  

## 41. Qual è il vantaggio di `ContainsValue(data, value)`?

A. Rende chiara l'intenzione: verificare se un valore è presente  
B. Nasconde l'array al compilatore  
C. Crea automaticamente una media  
D. Cancella i duplicati  

## 42. Perché `CalculateMinimum()` e `CalculateMaximum()` sono simili?

A. Entrambe scorrono l'array e aggiornano un valore corrente  
B. Entrambe leggono input da tastiera  
C. Entrambe stampano soltanto testo  
D. Entrambe creano una form HTML  

## 43. Perché non sempre conviene eliminare subito ogni duplicazione?

A. Perché un'astrazione prematura può rendere il codice più difficile  
B. Perché la duplicazione è sempre obbligatoria  
C. Perché C# non permette astrazioni  
D. Perché i metodi non possono essere riutilizzati  

## 44. Cosa significa che le stringhe sono immutabili?

A. Una stringa non viene modificata direttamente: spesso si crea una nuova stringa  
B. Una stringa non può mai essere stampata  
C. Una stringa è sempre vuota  
D. Una stringa è un numero intero  

## 45. Qual è una differenza introduttiva tra value type e reference type?

A. I value type contengono direttamente il valore, i reference type puntano a un oggetto  
B. Sono esattamente la stessa cosa  
C. I reference type sono sempre numeri  
D. I value type sono sempre stringhe  

---

## Soluzioni

Le soluzioni commentate sono nel file:

- [SOLUZIONI_CSHARP.md](./SOLUZIONI_CSHARP.md)
