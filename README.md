# Lernperiode 6

## Fertiges Projekt

![BlueDragon](https://github.com/user-attachments/assets/0c12a3bc-0512-4f07-a347-a88948345df4)

- Grundprinzip
    - Am Anfang kann man in diesem Game eine Waffe aussuchen
    - Danach erscheinen immer wieder neue Gegner. Nach zehn besiegten Gegner gelangt man in die nächste Welt
    - Das Spiel ist zu Ende, wenn man stirbt oder alle Welten überlebt hat
- Items
    - Wenn man einen Gegner besiegt kann man einen Heilungstrank bekommen
    - Die Wahrscheinlichkeit liegt bei 20%
 
Viel Spass beim entdecken des Spiels, der Welten und den Gegnern ;)

## Grobplanung

- Ich möchte ein kleines textbasiertes Game mit ObjektOrientierterProgrammierung erstellen. Es soll einen Charakter geben, der Angreifen, Leben verlieren usw. kann. Es wird Verbündete, Händler und Gegner geben.

## Feinplanung

### 23.08.2024

- [x] Ich lese die Präsentation PR_4203 zum Thema "Zugriffsmodifizierung/Kapselung" von M320

- [x] Ich löse Auftrag LA_4213 zum Thema "Zugriffsmodifizierung/Kapselung" von M320

- [x] Ich lese die Präsentation zum Thema "Konstruktoren & Objekte init" PR_4204 von M320

- [x] Ich löse Auftrag LA_4205 "Konstruktoren & Objekte init" von M320

Heute habe ich die Aufträge, welche ich am 21.08.2024 nicht bearbeiten konnte, bearbeitet. Zuerst habe ich das Thema "Zugriffsmodifizierung/Kapselung" angeschaut. Nach der Pause habe ich das Thema "Konstruktoren & Objekte init" angeschaut. Am Schluss hatte ich noch Zeit übrig. In dieser Zeit habe ich mit Herrn Colic mein Repo und meine Projektidee für die Lernperiode 6 besprochen. (57 Wörter)

### 30.08.2024

- [x] Ich erstelle den Helden, zwei kleine Gegner und einen grossen Gegner

- [x] Ich erstelle drei verschiedene Waffen, auswelchen man am Start aussuchen kann

- [ ] Ich erstelle die ersten drei bis fünf Entscheidungen

- [x] Ich bearbeite Auftrag 0501 Barrierefreiheit Testen von M322

Heute habe ich mit meinem RPG gestartet. Ich habe für die Helden, die Gegner, die Schwerte und die Bögen Klassen erstellt. Ich habe auch schon mit dem Start des Games begonnen. Ich kam aber nicht so weit wie erwartet. Zum Schluss habe ich den Auftrag 0501 von M322 zusammen mit Szymon bearbeitet. (52 Wörter)

### 06.09.2024

- [x] Ich programmiere, dass man zwischen seinem Schwert und Bogen wechseln kann

- [x] Ich erstelle die ersten drei kämpfe

- [ ] Ich erstelle eine Heilen, Verteidigen und Flüchten Methode für die Heros

- [x] Ich bearbeite Auftrag 1714 Passwortmanager von M231

Heute habe ich das Kampfsystem meines RPGs erstellt. Man kann nun sagen womit man Angreifen möchte. Der Gegner hat kein Schwert und Bogen mehr, er hat nur noch eine Weapon, da dies einfacher ist zu programmieren. Es wird beim kämpfen sogar der Speed einbezogen, sodass wenn der langsamere stirbt bevor er in jener Runde angreifen kann, dem Schnelleren keine Leben mehr abziehen kann. Nach ein paar Fehlern bei der Anzeige habe ich noch zwei zusätzliche Kämpfe hinzugefügt. (77 Wörter)

### 13.09.2024

- [ ] Ich programmiere Spezialeffekte wie Verbrennung, Gift etc. (Wie in Pokémon)

- [x] Ich erweitere mein Game, um einen Heiltrank, welchen man mit einer gewissen Wahrscheinlichkeit erhält nachdem man gegen einen Gegner gekämpft hat

- [ ] Ich erstelle eine Methode, mitwelcher man Items verwenden kann und verwende diese in program.cs

- [x] Ich erstelle eine Entscheidung, welche bestimmt, ob man Unterwasser geht oder durch einen Wald

Heute habe ich eine Klasse für Heilitems erstellt. Nun erhält man mit einer Chance von 25% ein Heilitem, wenn man einen Gegner besiegt. Anschliessend habe ich eine Methode erstellt, welche ein Heilitem einsetzen kann. Allerdings gab es viele Fehler und einen konnte ich nicht selbst beheben, weshalb ich eine Email an Herrn Colic schreiben musste, ob er mir helfen könne. Zum Abschluss habe ich eine 2. und 3. Welt mit neuen Gegnern erstellt. (73 Wörter)

### 20.09.2024

- [x] Ich schaue, dass Problem in meinem Programm mit Herrn Colic an

- [x] Arvin und ich erstellen 4 Szenarien und 6 User Stories für das Projekt in M322

- [ ] Arvin und ich erstellen den Low-Fidelity Prototyp für das Projekt in M322

- [ ] Arvin und ich evaluieren den Low-Fidelity Protoyp für das Projekt in M322

Heute habe ich den Fehler aus meinem RPG beseitigt. Das Item "Leer" existiert nicht mehr. Es wird nun überprüft, ob ein Slot null ist oder nicht. Danach habe ich mit Arvin vier Szenarien und sechs User Stories erstellt. Im Anschluss haben Arvin und ich mit dem Low-Fidelity-Prototyp begonnen. Allerdings sind wir nicht fertig geworden. (54 Wörter)

### 27.09.2024

- [x] Wenn der Gegner angreift soll der Benutzer benachrichtigt werden, über erhaltenen Schaden. Es soll ersichtlich sein wer in welcher Reihenfolge angreift

- [x] Ich bearbeite die Klassen, sodass Schwert und Bogen von einer Waffenklasse, Heiltränke von einer Items Klasse und Heros und Enemies von einer Character Klasse erben und putze den Code

Heute habe ich vorallem meinen Code geputzt und den Code leserlich gemacht. Als erstes habe ich die Superklassen "Equipment", "Items" und "Character" erstellt. Nun sind Attribute wie Name, Beshchreibung und Power nicht mehr doppelt aufgeführt. Danach habe ich geschaut, das der Bildschirm im richtigen Moment geleert wird. Da ich am Schluss noch Zeit übrig hatte habe ich nach Fehlern gesucht und bei den Strings die Interpolation implementiert. (67 Wörter)

## Reflexion

Diese LP habe ich mit dem Nacharbeiten der Aufträge des M320 - OOP begonnen. Danach habe ich mich an ein eigenes Projekt gewagt, genauer gesagt das RPG Spiel Blue Dragon. Zuerst habe ich Helden, Gegner und Waffen erstellt. Dann habe ich das Kampfsystem erstellt. Anschliessend habe ich einen Heiltrank implementiert. Danach haben Arvin und ich am Projekt für M322 gearbeitet. Zum Abschluss habe ich den Code noch rausgeputzt und finalisiert.

Dieses Lernatelier hat sehr viel Spass gemacht, da ich zum ersten Mal ein interaktives und fantsievolles Spiel erstellen konnte. Eigentlich programmiere ich im Lernatelier immer die Ideen, die mir bei der Planung und dem Programmieren in den Sinn kommen. Sobald sich viele Aufträge aus den Modulen anhäufen bearbeite ich diese. (120 Wörter)
