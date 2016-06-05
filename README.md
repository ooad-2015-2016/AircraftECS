# AircraftECS

1. Bilal Šehovic
2. Meliha Mešanovic
3. Dino Živojevic
4. Harun Dizdar


##Opis teme

AircraftECS je sistem za kontrolu okruženja aviona, kako unutrašnjeg tako
i vanjskog dijela letjelice. Sistem prati određen broj parametara koji se 
očitavaju sa senzora aviona, kao što su visina, brzina, položaj aviona, 
kurs, snaga motora, pravac (što se veže za spoljašnje parametre), kontrola 
toplote i pritiska, koncentracija kisika unutar aviona (unutrašnji parametri).

Svrha sistema je da pilotu omogući jednostavniju detekciju greške kao i
manuelnu regulaciju u slučaju otkazivanja sistema, što osigurava sigurniji let.
Automatska regulacija se odvija  preko sistema u avionu koji nakon što 
detektuje grešku vezanu za određeni proces preko regulatora upravlja 
izvršnim organima (ventilima, motorima...). U slučaju da je određeni 
dio sistema u kvaru, aplikacija daje uvid pilotu gdje je došlo do greške
i omogućava mu da manuelno upravlja sistemom u svrhu ispravljanja iste.


Potrebno je da pilot na početku unese željene vrijednosti parametara
nakon čega se pali sistem za automatsku regulaciju. Pilot je u mogućnosti
da u svakom trenutku prebaci kontrolu sistema sa automatskog na manuelni.




##Procesi

Potrebno je da pilot na početku leta unese željene parametre u aplikaciju
i uključi sistem za automatsku regulaciju. Nakon što senzori u slučaju greške
očitaju vrijednosti koje su izvan granica dozvoljenih, aplikacija aktivira alarm
i prikazuje koji dio sistema nije ispravan, na što pilot djeluje tako što prebaci
režim rada na mauelni. Bitno je napomenuti da je pilot u mogućnosti u svakom trenutku
manuelno upravljati procesima u sistemu, bez obzira da li postoji greška ili ne.
Uvid u stanje parametara preko aplikacije također ima i preostali dio posade aviona
u slučaju da je došlo do kvara na senzorima koji kontrolišu unutrašnje stanje letjelice
kao što su nedostatak kisika ili neregularnosti u kontroli pritiska i toplote, da posada 
može djelovati u interakciji sa putnicima van pilotske kabine. Takodjer aplikacija 
dozvoljava polijetanje aviona tek kada je svaki od putnika vezan sigurnosnim pojasom.



##Funkcionalnosti

* Provjera da li su svi putnici zavezani sigurnosnim pojasom i ovisno 
  od toga aplikacija daje signalizaciju i omogućava polijetanje aviona
* Mogućnost unosa željenih parametara sistema i očitanje tekućih
* Sistem provjerava stanje na senzorima
* Detektovanje greške u određenom dijelu sistema u slučaju neispravnosti
  parametara tj. pojavljivanja vrijednosti izvan dozvoljenog opsega
* Mogućnost odabira režima rada sistema (automatski ili manuelni)
* Paljenje alarma za slučaj neke neispravnosti




##Akteri

1. Pilot- Akter koji unosi željene parametre u aplikaciju i prati ispravnost parametara
   potrebnih za siguran let. Također ima mogućnost manuelnim upravljanjem ako je  to potrebno
2. Kopilot- Akter koji prati rad aplikacije i asistira pilotu. Ima mogućnost preuzeti upravljanje aplikacijom
   ako je to potrebno
3. Administrator leta- prati protokol za let i ima pristup aplikaciji samo u slučaju opasnosti
4. Stjuardese- Imaju mogućnost praćenja aplikacije, ali ne i pristup. Stjuardese u slučaju da nisu svi putnici vezani
   sigurnosnim pojasom i aplikacija ne dopušta početak leta, sugerišu putnicima na ispravku greške. Također u slučaju 
   neispravnosti vezanih za unutrašnji dio aviona, surađuju sa putnicima i rade na popravci situacije.


##Spisak zadataka za projekat

##1.Eksterni uredjaj

   Kao eksterni uredjaj koristen je Arduino UNO (Napon sa potenciometra se dovodi na analogni ulaz arduina, koji salje podatke
   aplikaciji i na osnovu prekoracene dozvoljene vrijednosti napona aplikacija prijavljuje gresku i pali diodu) - 
   - Kod u Visual studio: (https://github.com/ooad-2015-2016/AircraftECS/blob/master/Projekat/Official/Official%20projekat/Official/Views/PrikazParametara.xaml.cs)
   - Kod napisan u Arduino okruzenju: (https://github.com/ooad-2015-2016/AircraftECS/blob/master/Projekat/Official/Official%20projekat/Arduino_kod_za_projekat.txt)

##2.Validacija
   
   Validacija je ispostovana u okviru formi za unos posade, unos parametara i registraciju novih korisnika:
   - (https://github.com/ooad-2015-2016/AircraftECS/blob/master/Projekat/Official/Official%20projekat/Official/Views/UnosPosade.xaml.cs)
   - (https://github.com/ooad-2015-2016/AircraftECS/blob/master/Projekat/Official/Official%20projekat/Official/Views/UnosParametara.xaml.cs)
   - (https://github.com/ooad-2015-2016/AircraftECS/blob/master/Projekat/Official/Official%20projekat/Official/Views/Registracija.xaml.cs)

##3.Adaptive layout

   Samo na nekim formama je uradjen adaptive layout.
   - (https://github.com/ooad-2015-2016/AircraftECS/blob/master/Projekat/Official/Official%20projekat/Official/Views/UnosPosade.xaml)

4##.Video

   Video se moze pogledati [ovdje] (https://www.youtube.com/watch?v=q8Bvlak529k)

