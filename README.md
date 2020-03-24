#  MINESWEEPER
[LINK DO APLIKACJI](https://files.catbox.moe/9f53wt.apk)

## Działanie
![https://cdn.discordapp.com/attachments/426455823426912277/692001190631964702/Screenshot_2020-03-24-14-23-59-234_a.b.c.jpg](https://cdn.discordapp.com/attachments/426455823426912277/692001190631964702/Screenshot_2020-03-24-14-23-59-234_a.b.c.jpg)Na ekranie rozgrywki klikamy w nieodkryte pola z nadzieją, że nie trafimy na wygenerowaną minę. 

![https://cdn.discordapp.com/attachments/426455823426912277/692001190329843793/Screenshot_2020-03-24-14-24-14-390_a.b.c.jpg](https://cdn.discordapp.com/attachments/426455823426912277/692001190329843793/Screenshot_2020-03-24-14-24-14-390_a.b.c.jpg)Przy odkrywaniu pola możemy trafić na pola:
- puste;
- z cyframi od 1 do 8 (oznaczającego ile bomb znajduje się na polach sąsiadujących);
- minę;
Dzięki kafelkach z cyframi możemy obliczyć gdzie znajduje się mina.
![](https://media.discordapp.net/attachments/426455823426912277/692001189717475379/Screenshot_2020-03-24-14-24-28-221_a.b.c.jpg?width=974&height=468)Trafienie na bombę powoduje naszą przegraną i jesteśmy zmuszeni zacząć od początku.

![](https://media.discordapp.net/attachments/426455823426912277/692004978134351932/unknown.png?width=755&height=468)Celem gry jest odkrycie wszystkich pól oprócz pól z bombami.

## Unity3D
Do stworzenia aplikacji wykorzystałem silnik UNITY i skryptów w języku C#.
Silnik oferuje proste budowanie aplikacji na wiele platform jednak przyznam się, że zbudowanie aplikacji na system Android przysporzyło mi więcej problemów niż samo pisanie aplikacji. Spowodowane to było problemem wykrycia SDK przez Unity. Oprogramowanie przystosowane jest do tworzenia gier więc wyzwanie nie było za trudne. Wystarczyło jedynie poznanie zasad działania silnika.

## TODO
- ~~losowe generowanie min;~~
- ~~odkrywanie pól;~~
- ~~zliczanie min na pola sąsiadujących;~~
- ~~automatyczne odkrywanie pól;~~
- komunikaty WYGRANA PRZEGRANA;
- Przycisk reset;
- Generowanie bomb po odkryciu pierwszego pola;
