
Dokumentacja Projektowa - Kalkulator kredytu hipotecznego

1.	Technologie i Narzędzia
Język Programowania
C#: Główny język programowania używany do implementacji logiki aplikacji.
Framework
.NET Framework: Platforma do budowy i uruchamiania aplikacji.
Biblioteki i Narzędzia
Windows Forms: Biblioteka do budowy graficznego interfejsu użytkownika (GUI).
Visual Studio: Zintegrowane środowisko programistyczne (IDE) używane do tworzenia, debugowania i uruchamiania aplikacji.
Git: System kontroli wersji używany do zarządzania kodem źródłowym.

2.	Opis Działania Aplikacji 
Obliczanie Harmonogramu Spłat:
Aplikacja umożliwia użytkownikowi wprowadzenie kwoty kredytu, RRSO oraz okresu kredytowania. 
Na podstawie tych danych generowany jest harmonogram spłat, który uwzględnia wszystkie raty zarówno w części kapitałowej i odsetkowej. Wyświetlając użytkownikowi całkowity koszt kredytu, sumę odsetek i wysokość raty.
Obsługa Nadpłat:
Użytkownik może wprowadzać zarówno nadpłaty jednorazowe, jak i cykliczne.
Harmonogram spłat jest aktualizowany w celu uwzględnienia nadpłat, a aplikacja przelicza pozostałe saldo do spłaty oraz koszty odsetek.
Tryb Edycji Nadpłat:
Aplikacja oferuje tryb edycji, w którym użytkownik może modyfikować nadpłaty dla poszczególnych rat bezpośrednio w harmonogramie.
Zmiany te są od razu odzwierciedlane w harmonogramie spłat oraz w głównym widoku aplikacji.
Interfejs Użytkownika
MainForm: Główny formularz aplikacji, gdzie użytkownik wprowadza dane dotyczące kredytu i nadpłat oraz przegląda podstawowe informacje o kredycie.
RepaymentScheduleForm: Formularz w zależności od przycisku go wywołującego wyświetla:
•	harmonogram spłat bazujący na podstawowych danych kredytu,
•	harmonogram spłat uwzględniający nadpłaty zdefiniowane dla kredytu,
•	harmonogram spłat w trybie edycji umożliwiający edycję nadpłat.

3.	Przepływ Działania
Wprowadzenie danych kredytowych: Użytkownik wprowadza kwotę kredytu, oprocentowanie oraz okres kredytowania w odpowiednich polach tekstowych na MainForm.
Kliknięcie przycisku "Oblicz" generuje harmonogram spłat i na jego podstawie oblicza i  wyświetla podstawowe informacje o kredycie takie jak całkowity koszt, suma odsetek.
Dodanie nadpłat: Użytkownik może wprowadzić kwotę nadpłaty jednorazowej lub cyklicznej. Po kliknięciu odpowiedniego przycisku „dodaj” harmonogram spłat oraz dane kredytu uwzględniające nadpłaty są aktualizowane.
Edycja nadpłat: Użytkownik otwiera RepaymentScheduleForm, gdzie może edytować nadpłaty dla poszczególnych rat. Zmiany są zapisywane i odzwierciedlane w głównym widoku aplikacji.

 
