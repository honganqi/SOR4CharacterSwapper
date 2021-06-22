# Changelog
All notable changes to this project will be documented in
this file.

## 2.0.1 - 2021/06/18 19:18 GMT+08:00
### Changed
* updated the How-To section
### Fixed
* "Swap minibosses with minibosses only" randomizer checkbox
now works as intended (thanks Bragdras and VGamer)
* fixed issue where the app window "teleports" when coming


## 2.0.0 - 2021/06/17 06:07 GMT+08:00
### Added
* added a "Swap minibosses with minibosses only" checkbox
which is enabled and considered only if the
"Ignore minibosses" checkboxes is not checked
* added a button to show and hide the list of replacements
* added a notice if there are swaps that haven't been
applied yet
* added How-To button and section
* added links to pages and channels
### Changed
* revamped the entire user interface
* randomizing will no longer apply the changes automatically.
The "Apply changes" button has to be used for the swaps to be
applied.
* set Mariah as a miniboss
* set B.T. (boss) as a boss
* set Dunphy (electro) as a regular enemy
* set Goro (alt) as a regular enemy
* set Ralphy as a regular enemy
### Removed
* removed the "Display randomized set on Replacement List"
checkbox
* removed the prompt to display swaps when loading a swap file


## 1.2.2 - 2021/06/09 21:44 GMT+08:00
### Added
* app now indicates the filename of a swap setting if one was
loaded
### Changed
* upon loading a swap settings file, app will now ask if you
want the swapped characters to show up on the list (mostly
for streamers and content creators)
### Fixed
* fixed bug where "Reset" button still leaves swaps in
memory when used (thanks Bragdras)
* fixed bug where characters in the swap list before
randomization are still included in the randomization

## 1.2.1 - 2021/06/06 21:42 GMT+08:00
### Fixed
* finally fixed issues when doing swaps with a modified
bigfile with existing swaps
* fixed bug where randomizing does not work when "Display
randomized set on Replacement List" checkbox is not checked

## 1.2.0 - 2021/06/06 03:37 GMT+08:00
### Added
* this app now requires an additional file named
"SOR4CharacterExplorer.dll" in the same folder as this app
* added all the remaining characters who are not yet possible
to meet in the game as of SOR4 v5 (Tetsu, Tora, Ralphy, etc.)
* these are excluded from randomization but can be swapped
manually
* allowed typing in the character list to filter through the
list
* added a Miniboss tag to the characters
(Commissioner Stage 7, Shiva Spirit, Koobo and Baabo robots,
Goro and Dokuja karate guys, etc.)
* added a checkbox to allow ignoring minibosses in the
randomization process
* added a "Swap bosses with bosses only" checkbox which is
enabled and considered only if the "Ignore Bosses" checkboxes
is not checked
* added tooltips to "Ignore Bosses" and "Ignore Minibosses"
checkboxes to see list of characters
* added thumbnails to the characters in the Replacement List
* app now remembers the last known path of the bigfile
### Changed
* changed size and position of the thumbnails
* other miscellaneous text and notification improvements and
fixes

## 1.1.2 - 2021/05/31 22:49 GMT+08:00
### Added
* added thumbnails for each character
* added Sand (Stage 11 police officer with riot shield and
taser)

## 1.1.1 - 2021/05/31 12:32 GMT+08:00
### Changed
* renamed Georgia to Caramel

## 1.1.0 - 2021/05/30 23:37 GMT+08:00
### Added
* added checkbox to "Display randomized set in Replacement
List" (thanks Shad)
* added "Ignore bosses" checkbox and is enabled by default.
Too many issues show up when bosses are swapped; e.g. they stop
moving when they're supposed to change phases/super
### Changed
* changed "Allow duplicates" prompt into a "Prevent duplicates"
checkbox (thanks Shad)
* changed item positioning
* "Replace bosses with other bosses only" checkbox is enabled by
default
* excluded the SOR2 bosses to the randomization pool, proved too
difficult. If I'm just too noob to beat them normally, please
let me know so I can decide if they're ok to be included again.
### Fixed
* fixed bug where characters who were changed (original) were
still being replaced when randomization is run

## 1.0.7 - 2021/05/28 23:44 GMT+08:00
### Added
* added confirmation message box upon clicking Randomize buttons
* added choice to allow duplicates of randoms during
randomization (e.g. Galsia-Jonathan, Donovan-Jonathan,
Koobo-Jonathan, etc.)
### Changed
* exempted playable characters and bosses from the randomizer to
help prevent softlocking the game at some points
* changed the Big Ben included in the swapper
### Fixed
* fixed swap list where display is broken when a swap is removed

## 1.0.6 - 2021/05/28 04:53 GMT+08:00
### Added
* added "Restore From Original v5 bigfile" function to make
backing up and restoring bigfile files easier
### Fixed
* fixed "Reset" logic and function

## 1.0.5 - 2021/05/27 23:03 GMT+08:00
* initial release