# Changelog
All notable changes to this project will be documented in
this file.

## 4.2.0 - 2022/02/28 01:10:59 GMT+08:00
### Added
* Added a "Customizer" section for characters and tons of
related features
* Added a "CUSTOMIZATION List" panel which shows when the
user is on the Customizer screen and has chosen to show it
* Added QOL (quality-of-life) for swaps where if you click on
a swap on the swaps panel, it will preselect the originals and
the replacements accordingly
* Added a button which appears if an update is available.
Clicking on it will bring you to the download page. This button
will show you what the latest version is if it is newer than
the one you're currently using.
* Added "Enemy Speed Multiplier" field in the Difficulty section
* Added "swap saved" with the filename after saving a swap file
* Added placeholder text to all the fields in the Author section
* Added "Enemy Speedhack Multiplier" in the Difficulty screen
which affects how some enemies speeds change depending on the
situation
* Added a "Reset" button in the Difficulty section which resets
values to their default values based on your selected difficulty
* Added change markers to values in the Difficulty section to
indicate values which have changed from their default values
### Changed
* Changed button sizes and their layouts on the main window
to accommodate more
* The way the Swap List Panel now switches to the list of
customized characters when in the Customization screen and,
like before, the list of replacements when in the Swapper and
Randomizer screens
* Separated the Swapper and the Randomizer access buttons
* Custom difficulty is now permanently enabled
* Changed the Date/Time field in the Author section to save in
the UTC (Coordinated Universal Time) and would display the
date and time in the user's timezone and locale format
* The app now creates a backup upon launching the app for the
first time and if the opened bigfile is the currently supported
version by the app
* Added tooltips to various textboxes
* Transferred Ralphy and Dunphy from Regular to Regular+
### Fixed
* Fixed the Life Up Score fields not getting included in the 
Save Swap function
* Loading a swap file with custom Score Life Up requirements
will now load those numbers in the user interface
* Fixed a bug where it would still show that one swap was still
in the Swap List Panel if all swaps in a list were removed when
there was at least one item before
* Fixed the thumbnails of Deputy and Lieutenant incorrectly
swapped with each other
* Fixed the issue where the replacement counter is not reset to
0 before loading the lists if the "Clear List" button was
clicked or anything triggers it (like loading a swap file with
swap lists)
* Fixed the wrong display count of unique replacements when
a swap is removed

## 4.1.0 - 2021/12/25 02:06 GMT+08:00
### Added
* Added inputs in the Difficulty screen to enable modifying
the score requirement for extra lives in Stage Select
and Arcade game modes
* Added warning upon launching the app indicating the absence
of original copies of the "bigfile" and
"bigfile_rep7_13648_backup" files. If both are missing or modded,
it is suggested to get an original copies by having Steam
verify your game files.
### Fixed
* Made the app work properly with "v7-s r13648"

## 4.0.0 - 2021/11/10 23:26 GMT+08:00
### Added
* Added "Difficulty" category which lets you create and customize
new difficulty settings
* Added "Swap Author" category which lets you add additional 
ownership information to the mod you're creating
* Most of the "Swap Author" details will appear in-game
* Added a thumbnail for Barnaby (Elite) (thanks, Bragdras!)
### Changed
* The Load and Save buttons are now next to each other
* Swap files are now saved in binary file format
* The Load function will accept both old and new Swap formats
* Changed the "How-To" screen contents into a link to YouTube
tutorials
* Changed "Electra" (the yellow SOR4 Nora) to "Belle"
* Made the application taller to accomodate the new features
### Fixed
* Randomizer: Golden weapons are now included in the
randomization when the "Ignore" and "Isolate" checkboxes are
unchecked (thanks, VGamer!)
* Fixed Stiletto's and Queen's mistaken identities which almost
caused the end of the world
### Removed
* Removed the "Save Swap List" button from the List of
Replacements panel
* Removed the "Extract swap list" button
* Made it so that only the EXE file is needed to run
the Swapper; no more DLL files


## 3.1.5 - 2021/09/03 15:33 GMT+08:00
### Fixed
* REALLY, REALLY fixed the randomizer including (retro) bosses
even if "IGNORE" and "ISOLATE" BOSS checkboxes were enabled.
* The following retro characters are now considered Minibosses:
Commissioner (Stage 7), Abadede SOR2, Mr. X SOR2, Shiva SOR2,
Zamza SOR2, Abadede SOR1 (elite), Antonio SOR1 (elite),
Bongo SOR1 (elite), Mr. X SOR1 (elite), Souther SOR1 (elite)


## 3.1.0 - 2021/08/29 12:31 GMT+08:00
### Added
* Randomizer: added preset buttons for one-click randomization
experience (VERY experimental)
* Levels: added a checkbox to prevent Boss Rush getting
randomized into the Story Levels
### Changed
* "Prevent duplicates" checkboxes are now named
"Allow duplicates". It is still logically the same, but it is
now an opt-in instead of an opt-out.
* "Ignore" checkboxes are now under the "IGNORE" column
* "Swap __ with __ only" checkboxes are now under the "ISOLATE"
column
* Various UI changes
### Fixed
* FIXED RANDOMIZER INCLUDING BOSSES EVEN IF "IGNORE" AND
"BOSS WITH BOSS ONLY" CHECKBOXES WERE ENABLED
* Fixed issue of unexpected swaps/randoms when applying changes
on a bigfile with existing swaps. There's no need to restore the
bigfile anymore when applying another set of swaps/randoms.
* Weapons: "IGNORE" and "ISOLATE" checkboxes of Golden Weapons
both work now


## 3.0.0 - 2021/08/11 6:26 GMT+08:00
### Added
* capability to swap and randomize Items, Breakables and Levels
* filter function in the swap list
* sort function in the swap list
* categorization in the drop-down menus
* "Clear all swap lists" button to accommodate the new Items,
Breakables, and Levels
* Characters: Added a Regular+ difficulty category
* Characters: Added "Ignore Regular+" and "Swap regular+ with
regular+ only" checkboxes
* Items: "Ignore Goldens" checkbox to make the randomizer ignore
the golden weapons
* Items: "Prevent goldens being swapped with weapons" checkbox
to only allow them randomizing between themselves
* Breakables: "Mix 'em all up" button to allow destructive
breakables (e.g. barrels) to be randomized into garbage cans
### Changed
* made the app work with the July 15, 2021 v7 update of the game
* made the app work with the July 24, 2021 v7 update of the
update of the game (yes, the second one)
* renamed the app into "SOR4 Swapper" because it's not limited
to characters anymore
* the app now uses thumbnails which are pulled directly from
the game files
### Removed
* thumbnails which came with the app were removed


## 2.1.0 - 2021/07/14 00:34 GMT+08:00
### Added
* added function to extract the swap list from a modified
bigfile onto a swap file ("show list" after extracting to 
be able to save the swap file) (thanks Anthopants)

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