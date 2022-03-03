# Definizione
Membri del gruppo:


[@jacopofavat](https://github.com/JacopoFavat). [@marcocarazita](https://github.com/marcocarazita)

## Introduzione

Il Nostro progetto è  basato sulla creazione di un'applicazione desktop (WPF) che possa  controllare l'autenticità e la completezza di un file attraverso l'utilizzo del metodo checksum SHA256 e la firma digitale PGP.
L'applicazione permetterà la navigazione all'interno del filesystem in modo tale che l'utente possa indicare il file da validare, possa apprendere la stringa la quale rappresenta il checksum SHA256, successivamente immettere la chiave di dominio pubblico PGP del file indicato prima, in modo tale da ottenere la verifica della firma digitale e infine avvertire l'utente se si dovessero presentare errori all'interno del processo di controllo e di conseguenza descriverne dettagliatamanete il problema riscontrato.

#
- Per la stesura del codice utilizzeremo Visual Studio 2019 di Microsoft
- Per il Co-Working utilizzeremo il sito web open source GitHub e GitHub Desktop in modo tale da poter lavorare entrambi contemporaneamente sullo stesso progetto 
- Per la parte grafica abbiamo individuato un canale YouTube che propone tutorial grafici riguardanti WPF che si chiama" CodeCracks "
- Per quanto riguarda la firma digitale PGP abbiamo capito che essa utilizza la cifratura a chiave pubblica per proteggere i file di dati e i messaggi, permettendo di comunicare in modo sicuro con chiunque, senza bisogno di canali sicuri per lo scambio delle chiavi.
- Lo SHA-256 è una diversa funzione di hash, solitamente i produttori di software rilasciano l'elenco ufficiale dei propri hash su i loro siti, così nel caso scaricassimo il file ed eseguissimo la funzione di hash, potremmo verificarene l'autenticità ed evitare un file manomesso o danneggiato



Il gruppo ha delle carenze comuni e dovrà approfondire i seguenti punti:
- Approfondire la creazione della parte grafica di WPF poichè  il gruppo si trova  ad un livello base riguardo la parte grafica di WPF.
- Apprendere il metodo del checksum SHA256 e della firma digitale PGP.
- Capire come integrare all'interno dell'applicazione desktop la navigazione nel filesystem.
Il gruppo andrà ad utilizzare sicuramente  le informazioni fornite da Microsoft riguardo lo sviluppo desktop WPF, successivamente per la parte grafiche sono stati individuati dei corsi di spiegazione su YouTube molto forniti e articolati.
Per problematiche generali consulteremo siti web open source in modo tale da risolvere velocemente e correttamente la problematica