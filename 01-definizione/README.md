# Documento di Definizione
Membri del Gruppo:


[@jacopofavat](https://github.com/JacopoFavat) - [@marcocarazita](https://github.com/marcocarazita)


## Identificazione dei bisogni esposti nella traccia

Il Nostro progetto è  basato sulla creazione di un'applicazione desktop (WPF) che possa  controllare l'autenticità e la completezza di un file, attraverso l'utilizzo del metodo checksum **SHA256** e la **Firma Digitale PGP**.
L'applicazione permetterà la navigazione all'interno del filesystem, in modo tale che l'utente possa indicare il file da validare, possa apprendere la stringa la quale rappresenta il checksum **SHA256** e successivamente immettere la chiave di **dominio pubblico PGP** del file indicato prima, in modo tale da ottenere la verifica della firma digitale e infine segnalare all'utente se si dovessero verificare errori all'interno del processo di controllo e di conseguenza descriverne dettagliatamente il problema riscontrato.


## Descrizione delle risposte tecnologiche ai bisogni individuati

- Per la stesura del codice utilizzeremo **Visual Studio 2019**.
- Per lavorare con la chiave PGP utilizzeremo la libreria di Visual Studio "System.Security.Cryptography;".
- Per il **Co-Working** utilizzeremo il sito web open source **GitHub**, con l'annessa estensione del software **GitHub Desktop**, in modo tale da poter lavorare entrambi simultaneamente all'interno del progetto.
- Per la parte grafica abbiamo individuato dei canali YouTube che propongono tutorial grafici riguardanti WPF, i quali si chiamano "**[CodeCracks](https://www.youtube.com/channel/UCiZ818fpn8OGBWu1f95NEHQ)**" e "**[VectoArt](https://www.youtube.com/c/VectoArt)**". 
- Per quanto riguarda la **Firma Digitale PGP** abbiamo capito che essa utilizza la cifratura a chiave pubblica in modo tale da proteggere i file di dati e i messaggi, permettendo di comunicare in modo sicuro con chiunque, senza bisogno di canali sicuri per lo scambio delle chiavi.
- Riguardo allo **[SHA-256](https://docs.microsoft.com/it-it/dotnet/api/system.security.cryptography.sha256?view=net-6.0)** abbiamo appreso che esso è una diversa funzione di hash, solitamente i produttori di software rilasciano l'elenco ufficiale dei propri hash su i loro siti, così nel caso scaricassimo il file ed eseguissimo la funzione di hash, potremmo verificarene l'autenticità ed evitare un file manomesso o danneggiato.


## Identificazione delle carenze (gap) nelle conoscenze rilevati nei membri del gruppo

Il Gruppo presenta delle carenze comuni e dovrà approfondire i seguenti punti:

- Apprendere il metodo del checksum **SHA256** e della **Firma Digitale PGP**.
- Capire come integrare all'interno dell'applicazione desktop la navigazione nel filesystem.
- Approfondire la creazione della parte grafica di WPF, poichè  il gruppo si trova  ad un livello base riguardo ad essa.


## Indicazione e organizzazione delle informazioni che si useranno per rispondere ai bisogni e colmare i gap di conoscenza

Il Gruppo per colmare i gap di conoscenza, andrà ad utilizzare i documenti informativi forniti da Microsoft (**Microsoft.DOC**) riguardanti lo sviluppo desktop WPF e usufruirà anche delle informazioni fornite da Microsoft.DOC per apprendere al meglio la firma digitale PGP e il metodo del checksum SHA256. Successivamente per le parti grafiche sono stati individuati dei corsi di spiegazione step-by-step su YouTube molto forniti e articolati, di canali come ad esempio quelli citati precedentemente.
Per problematiche generali consulteremo siti web open source come "**[GitHub](https://github.com/)**" e "**[StackOverflow](https://stackoverflow.com/)**", in modo tale da risolvere velocemente e correttamente i problemi. 