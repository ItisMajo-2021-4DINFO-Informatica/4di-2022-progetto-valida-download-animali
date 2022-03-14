# Documento di Progetto
Membri del Gruppo:


[@jacopofavat](https://github.com/JacopoFavat) - [@marcocarazita](https://github.com/marcocarazita)

## Stesura del progetto iniziale, racconto di come si andrà a realizzare la soluzione
Inizialmente andremo a creare un nuovo progetto **WPF.netcore** in linguaggio _C#_ all'interno del programma **Visual Studio 2019** precedentemente citato nel [Documento di Definizione](https://github.com/ItisMajo-2021-4DINFO-Informatica/4di-2022-progetto-valida-download-animali/blob/main/01-definizione/README.md). Di partenza l'utente dovrà importare il file da analizzare tramite il [filesystem](https://www.codeproject.com/Articles/1236588/File-System-Controls-in-WPF-Version-III) e per far si che questa azione avvenga andremo ad utilizzare la classe "[openfiledialog](https://docs.microsoft.com/it-it/dotnet/desktop/wpf/windows/how-to-open-common-system-dialog-box?view=netdesktop-6.0)" che verrà integrata all'interno di un bottone facile da visualizzare per l'utente. Ovviamente in caso di importo errato di un file, l'utente sarà avvisato tramite un **allert** e sarà invitato a reimportarne un altro, la procedura si ripeterà se il file sarà di nuovo reinserito errato. Succesivamente dovrà essere confrontato lo **SHA256** del file importato con quello originale e anche la **firma PGP**. Infine l'esito di verifica verrà stampato all'interno di una **label** rilasciando tutte le informazioni legate al rapporto eseguito.

## Organizzazione del lavoro, suddivisione della realizzazione in fasi, stima della durata e ruoli dei membri del gruppo
Il lavoro sarà organizzato nel seguente modo:
 - [@marcocarazita](https://github.com/marcocarazita) lavorerà prima sulla parte grafica e successivamente alla modalità di calcolo del metodo del **checksum**, utilizzando le risorse citate precedentemente nel [Documento di Definizione](https://github.com/ItisMajo-2021-4DINFO-Informatica/4di-2022-progetto-valida-download-animali/blob/main/01-definizione/README.md).Si stima **_una settimana_** di lavoro per portare a termine la crazione dell'interfaccia grafica del progetto **WPF**.
 - [@jacopofavat](https://github.com/JacopoFavat) inizialmente scriverà il codice dietro al filesystem e in seguito realizzerà la parte relativa all'**openfiledialog**. Inoltre con l'aiuto del compagno di gruppo andrà a realizzare la **Verifica della Firma Digitale**. Il tempo stimato per la realizazzione del lavoro è di **_10 giorni_**.
- Infine tutto il gruppo andrà ad eseguire un controllo dettagliato del prodotto finale per far si che non siano presenti _errori_ e/o _malfunzionamenti_ interni.

## Documentazione del processo di realizzazione, attraverso appunti e commenti significativi alle versioni rilasciate su GitHub (commit)
Come citato in precedenza nel [Documento di Definizione](https://github.com/ItisMajo-2021-4DINFO-Informatica/4di-2022-progetto-valida-download-animali/blob/main/01-definizione/README.md), utilizzeremo il sito web open source **"[GitHub](https://github.com/)"** e la sua realitiva applicazione **GitHub Desktop**, la quale verrà utilizzata per uploadare tutte le versione aggiornate dei file tramite i commit, che saranno forniti di nome del file alla quale verrà associato il numero della versione di aggiornamento. All'interno del singolo commit sarà disponibile la descrizione delle modifiche apportate ad ogni singola consegna.

## Documentazione dei collegamenti e relazioni tra ciò che si sta realizzando e le informazioni di riferimento (teoria della materia, altre materie, soluzioni già esistenti)
Collegamenti con:
- **_Inglese_**: Per reperire informazioni più precise nelle dispense online e per facilitare la ricerca all'interno del **filesystem** in inglese.
- **_Informatica (teoria)_**: Usufruiremo delle spiegazioni del Professore [Marcello Bozzi](https://github.com/bozzimarcello), in merito alla chiave PGP e al calcolo del checksum SHA256.

Per la parte rigurdante il calcolo dello SHA256 di un file uploadato dal filesystem ci andremo ad ispirare al[sito web](https://emn178.github.io/online-tools/sha256_checksum.html) in questione, che sarà la nostra base di riferimento.

Per la sezione riguardante la chiave PGP, come per il calcolo del checksum, ci andremo ad ispirare al seguente [programma](https://www.igolder.com/pgp/generate-key/) web open source in modo tale da avere un solido riferiemento a cui ispirarci.