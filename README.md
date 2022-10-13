1	Cel projektu
 
Celem projektu jest ułatwienie zarządzania szkoleniami BHP oraz ułatwienie drukowania zaświadczeń z odbytego szkolenia. Ogólną zasadą jest aby system był aplikacja desktopową, działającą w kanwie klient- serwer. System będzie zawierał moduły:

	1.	MDP - moduł danych pracodawcy, oddziałów.
	2.	MDR - moduł danych pracowników.
	3.	MSB - moduł zarządzania szkoleniami,
	4.	MPR - moduł drukowania zaświadczeń.
	5.	MIB - moduł dostępnych prezentacji.

System będzie gromadził dane przy pomocy bazy SQL przechowywanej na serwerze bazodanowym MS SQL Serwer 2019. Podstawowym założeniem jest ochrona danych osobowych więc system będzie dostosowany           do wymagań RODO oraz wymagań ochrony danych osobowych i tajemnic danego przedsiębiorstwa.                  W pierwszej wersji będzie w module MPR wdrożony uzgodniony format dyplomów i zaświadczeń, przewiduje się w ko- lejnych wersjach dodanie modułów ustawień systemowych oraz wzorów dyplomów. System będzie pracował pod platformą Microsft Windows 10 wzwyż. Poniżej zamieszczono diagram przypadków użycia wersji 1.0.

2. Funkcjonalności

Podstawową funkcjonalnością systemu ma być możliwość gromadzenia i zarządzania danymi z przeprowa- dzonych szkoleń pracowników oraz możliwość efektywnego i szybkiego drukowania zaświadczeń. Poszczególne funkcjonalności modułów

	1.	MDP - zadaniem realizowanym przez moduł będzie gromadzenie i aktualizowanie danych o obsługiwanych przedsiębiorstwach, ich oddziałach i podstawowych danych kontaktowych. Moduł będzie dosto sowany do nowych zasad przechowywania i gromadzenia danych osobowych RODO.
	2.	MDR - moduł gromadzenia danych o pracownikach danego obsługiwanego przedsiębiorstwa wraz z danymi kontaktowymi, moduł będzie dostosowany do nowych zasad przechowywania                               i gromadzenia danych osobowych RODO. Realizacja modułu przebiegać będzie przy pomocy dwóch okien, ”dodaj Firmę” oraz ”dodaj Pracownika”. Aby dodać pracownika należy uprzednio zaktualizować bazę o nową firmę w sytuacji kiedy nie ma jeszcze w bazie.
	3.	MSB - moduł zarządzania szkoleniami,
	4.	MPr - moduł drukowania zaświadczeń.
	5.	MIB - moduł dostępnych prezentacji

3. Założenia i uwarunkowania 

W projekcie założono iż program będzie obsługiwał bazę sql na MS SQL Server 2019 (licencja Comunity). Program napisany ma być w języku C#. Kluczowe jest aby aplikacja pracowała w trybie klient-server (lokalnie i zdalnie) tj. baza ma być zaimplementowana na zdalnym serwerze Ubuntu Server 20.04 (licencja open source). Programem IDE do produkcji oprogramowania będzie Visual Studio 2019 (licencja community).

	1.	baza firm,
	2.	baza pracowników,
	3.	baza szkoleń

Główne cechy:, Poniżej przedstawiono opis poszczególnych modułów:


	1.	MDP - zadaniem realizowanym przez moduł będzie gromadzenie i aktualizowanie danych o obsługiwanych przedsiębiorstwach, ich oddziałach i podstawowych danych kontaktowych. Moduł będzie dostosowany do nowych zasad przechowywania i gromadzenia danych osobowych RODO. Implementację modułu w postaci diagramu przedstawiono na rysunku poniżej. Poniżej zamieszczono implementację w postaci wzoru okna aplikacji
	2.	MDR - moduł gromadzenia danych o pracownikach danego obsługiwanego przedsiębiorstwa wraz z danymi kontaktowymi, moduł będzie dostosowany do nowych zasad przechowywania i gromadzenia danych osobowych RODO. Realizacja modułu przebiegać będzie przy pomocy dwóch okien,” dodaj Firmę” oraz ”dodaj Pracownika”. Aby dodać pracownika należy uprzednio zaktualizować bazę o nową firmę w sytuacji kiedy nie ma jeszcze w bazie. Poniżej implementacja                w postaci diagramu oraz projektów okien.


Założenia związane z oprogramowaniem realizowane będą przy użyciu:

(a)	MS SQL Server 2019 w wersji Communinity - serwer bazy danych
(b)	Visual Studio 2019 w wersji Communinity - IDE C
(c)	Diagram Designer - w wersji open source - oprogramowanie do projektowanie diagramów
(d)	DiagraIO - w wersji open source - oprogramowanie do projektowania diagramów UML
(e)	oprogramowanie do testowania aplikacji NUnit oraz XUnit - w wersji open soruce. (f) Ubuntu Server 20.04 - Server bazy danych open source
Wymagania sprzętowe do realizacji zdania wykonano dla najbardziej wymagającego programu do re- alizacj projektu tj. Program Visual Studio 2019 można instalować i uruchamiać w następujących sys- temach operacyjnych (zalecane są wersje 64-bitowe; architektura ARM nie jest obsługiwana)

(a) Windows 10 w wersji 1703 lub nowszej: Home, Professional, Education i Enterprise (wersje LTSC i S nie są obsługiwane) Windows Server 2019: Standard i Datacenter Windows 8.1 (z aktualiza- cją 2919355): Core, Professional i Enterprise Windows Server 2012 R2 (z aktualizacją 2919355): Essentials, Standard, Datacenter Windows 7 z dodatkiem SP1 (z najnowszymi aktualizacjami): Home Premium, Professional, Enterprise, Ultimate
Na potrzeby realizacji projektu posłużono się systemem operacyjnym Windows 10 zaktualizowanego do wersji Windows 11 - 21H1. Wymagania sprzętowe i programowe dla poprawnej pracy programu Szkolenia BHP

a)Procesor 1,8 GHz lub szybszy (zalecany czterordzeniowy lub lepszy). 2 GB pamięci RAM; zalecane 8 GB pamięci RAM (co najmniej 2,5 GB w przypadku uruchamiania na maszynie wirtualnej).
 
b)Miejsce na dysku twardym: minimalnie 800 MB, a maksymalnie 210 GB dostępnego miejsca     (w                  zależności od instalowanych funkcji); typowe instalacje wymagają 20–50 GB wolnego miejsca.
c)Szybkość dysku twardego: aby zwiększyć wydajność, system Windows i program Visual Studio należy zainstalować na dysku półprzewodnikowym (SSD).
d)Karta wideo obsługująca rozdzielczość ekranu co najmniej 720p (1280 x 720); program Visual Studio będzie działać najlepiej przy rozdzielczości WXGA (1366 x 768) lub wyższej.
Minimalne Wymagania dla aplikacji ”Szkolenia BHP”:
Sprzętowe i systemowe

a)Komputer z procesorem kompatybilnym z Pentium III lub wyższym, 2 GHz 2 GB pamięci RAM w przypadku instalacji program + serwer SQL, 1GB w przypadku instalacji samego programu,
b)Dysk: 5 GB wolnej przestrzeni na dysku systemowym (domyślnie C:)
c)Napęd DVD (w przypadku instalacji z płyty)
d)System operacyjny Windows 10; Windows 8.1; Windows 7 (łącznie z wersją Starter); Windows Server 2016, Windows Server 2019.
e)Drukarka pracująca w systemie Microsoft Windows.
f)Server bazy danych np. Ubuntu Server z implementacją Virtual Box 6.1


Programowe

(a)	Sieć Microsoft Windows - Ubuntu Server (możliwa praca jednostanowiskowa), Protokół sieciowy TCP/IP, Do instalacji programu konieczne są uprawnienia administratora systemu,
(b)	Minimalna, dopuszczalna przez instalator rozdzielczość ekranu to 1024768,
(c)	Wymagana minimalna 16 bitowa głębia kolorów (65 536 kolorów).


Konfiguracja SQL

(a)	Szkolenia BHP może pracować wyłącznie w oparciu o bazę Microsoft SQL Server 2012, 2014, 2016, 2017 lub 2019 (wersje 2008, 2008R2 2005 i 2000 nie są wspierane). Zaleca się stosowanie najnowszych poprawek Service Pack dla poszczególnych wersji.
(b)	Szkolenia BHP współpracuje z dowolną edycją serwera SQL: Express, Workgroup, Standard oraz Enterprise.
(c)	Do prawidłowej pracy na poziomie serwera konieczne jest ustawienie: układ sortowania (collation)
– Polish, case insensitive, accent sensitive (Polish CI AS) *.
(d)	Tryb uwierzytelnienia – mieszany (mixed mode).
(e)	Tryb zdalnego dostępu do bazy skonfigurowano na poniższym modelu pracującej sieci rodzaju gwiazdy. 

Skalowalność sprzętowa, wymagania minimalne/Wymagania zalecane
System Operacyjny	System operacyjny Windows 10, Windows Server 2016, Windows Server 2019.
Procesor	Procesor Intel Pentium 2GHZ lub AMD równorzędny
RAM	2GB
Rozdzielczość	1024x768
HDD	5GB

Wymagania sprzętowe dla MS SQL Server 2019 W projekcie założono instalację serwera baz danych na Ubuntu Server 20.04 w VirtualBox 4.10.
Poniżej przedstawiono minimalne wymagania sprzętowe Minimalne Wymagania sprzętowe


4. Kolejne wersje
W przyszłości przewiduje się usprawnienie aplikacji do pracy jako cześć systemu zarządzania bezpie- czeństwem zakładu. Docelowo aplikacja zostanie usprawniona o możliwości ewidencji badań lekarskich, wydruków skierowań, ewidencji wypadków w pracy i w drodze do pracy.
