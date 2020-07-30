# Evaluation task
### Evaluation task for BuutCamp Agile: C# class.

Aloitin tehtävän tekemisen luomalla Car luokan ja sinne muuttujia mitä arvelin tarvitsevani.
Tämän jälkeen loin metodeja joita tarvin tehtävän suorittamiseen. Metodit olivat karkeita luonnoksia vasta tässä vaiheessa.

Seuraavaksi aloin veistämään valikko toimintoa käyttäjälle pähkäiltäväksi mitä haluaisi tehdä autolla.
Tämän toteutin switch casella. Tässä vaiheessa myös ajattelin että käyttäjä voisi syöttää tietoja autolle, joten muutin
aikaisemmin tekemiäni metodeja.

Aloin miettimään että voisin suurentaa projektia minkä seurauksena tein TestDataGenerator luokan.
Ajatuksena oli että käyttäjä saa sattumanvaraisen auton sattumanvaraisilla arvoilla jonka TestDataGenerator luo.
Seuraavaksi tein Car luokaan taulukkoja auton tietoja varten josta TestDataGenerator poimii sattumanvaraisesti car oliolle.

Tämän jälkeen muokkasin Car luokan metodeja lisää ja lisäsin ehtoja sekä rajoitteita käyttäjälle konsoli valikon pyörittämiseen.
Lopuksi koristelin ohjelmaa konsoli väreillä.

#### Ohjelman rakenteeksi tuli seuraavaa:
Program - pääohjelma joka käynnistää valikon/menun  
MenuUi - valikkorakenne ja kutsuu asioita car luokasta  
Car - Palauttaa menulle näytettäviä asioita   
TestDataGenerator - Hakee tietoja Car-luokasta ja car luokka kutsuu sitä
