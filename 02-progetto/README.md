# Documento di Progetto
Membri del Gruppo:


[@jacopofavat](https://github.com/JacopoFavat) - [@marcocarazita](https://github.com/marcocarazita)

## Stesura del progetto iniziale, racconto di come si andrà a realizzare la soluzione
Inizialmente andremo a creare un nuovo progetto WPF.netcore in linguaggio C# all'interno del programma Visul Studio 2019 precedentemente citato nel [Documento di Definizione](https://github.com/ItisMajo-2021-4DINFO-Informatica/4di-2022-progetto-valida-download-animali/blob/main/01-definizione/README.md). Di partenza l'utente dovrà importare il file da analizzare tramite il [filesystem](https://www.codeproject.com/Articles/1236588/File-System-Controls-in-WPF-Version-III) e per far si che questa azione avvenga andremo ad utilizzare la classe "[openfiledialog](https://docs.microsoft.com/it-it/dotnet/desktop/wpf/windows/how-to-open-common-system-dialog-box?view=netdesktop-6.0)" che verrà integrata all'interno di un bottone facile da visualizzare per l'utente. Ovviamente in caso di importo errato di un file, l'utente sarà avvisato tramite un allert e sarà invitato a reimportarne un altro, la procedura si ripeterà se il file sarà di nuovo reinserito errato. Succesivamente dovrà essere confrontato lo SHA256 cdel file imporatto con quello originale  e anche la firma PGP. Infine l'esito di verifica verrà stampato all'interno di una label rilasciando tutte le informazioni legate al rapporto eseguito.

## Organizzazione del lavoro, suddivisione della realizzazione in fasi, stima della durata e ruoli dei membri del gruppo
Il lavoro sarà organizzato nel seguente modo:
 
 [@marcocarazita](https://github.com/marcocarazita) lavorerà sulla parte grafica e alla modalità di calcolo del metodo del **checksum** utilizzando le risorse citate precedentemente nel [Documento di Definizione](https://github.com/ItisMajo-2021-4DINFO-Informatica/4di-2022-progetto-valida-download-animali/blob/main/01-definizione/README.md), si stima una settimana di lavoro per portare a termine la crazione dell'interfaccia grafica del progetto WPF.
 
 [@jacopofavat](https://github.com/JacopoFavat) scriverà il codice dietro al filesystem e realizzerà la parte relativa all'openfiledialog, è stimato un tempo di realizazzione del lavoro relativo a 7 giorni

## Documentazione del processo di realizzazione, attraverso appunti e commenti significativi alle versioni rilasciate su GitHub (commit)

## Documentazione dei collegamenti e relazioni tra ciò che si sta realizzando e le informazioni di riferimento (teoria della materia, altre materie, soluzioni già esistenti)


