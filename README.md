# Overview
Simple timer for Pomodoro and timed block practice sessions.

# Installation
## Prerequisites
`CountdownTimer` requires the [.Net Framework, version 4.5](https://www.microsoft.com/en-au/download/details.aspx?id=30653)
or higher. This should be available on most Windows systems. If not, you can download it [here](https://www.microsoft.com/en-au/download/details.aspx?id=30653).

On Linux and Mac you require a recent [Mono runtime](http://www.mono-project.com/download/).
Follow the Mono installation instructions for your system.

## Installation
There is no installer, simply unpack the binary archive somewhere and run `CountdownTimer.exe`.
To uninstall, simply delete the entire directory that you created.

# Usage
The timer functions should be self-explanatory. A rich set of options (including the preset button times) can be configured by right-clicking and selecting `Properties` from the context menu.
The settings are saved to a file in the application directory, so the user must have write permission for that location.
You can reset to the default options with the `Reset` button on the options form.

## Using Sequences
The timer supports loading sequences of timer values. This was initially
developed to support randomised music practice sessions, but it could be used
for anything (such as the timer sequences used for following the Pomodoro
Technique).

Timer sequences can be loaded from a CSV file, with the following columns:
* Name (string): a free-text label for the sequence item
* Category (string): another free-text field
* Tempo (string): free-text. For randomised music practice sessions, this gets
  the tempo in beats per minute.
* Notes (string): free-text notes describing the item.
* Duration (int): The timer duration in integer minutes. This is the actual
  value used to drive the timer sequence.

Sequences can be loaded from a CSV file. Additionally, if you have my [Practice
Randomiser](https://github.com/DC23/practice-randomiser) Python application
installed and configured, you can use it to automatically generate randomised
practice sessions.

## Pomodoro Technique Sequences
Clicking the `Pomodoro` button will populate the sequence grid with a pomodoro
sequence following the canonical 3 short, 1 long break pattern. The durations
are currently hard-coded.

# Development
Compilation is straightforward in both Visual Studio and MonoDevelop. Just use a recent version and the solution file.

# Attributions
The apple icon is from the Buuf icon set by Mattahan, available at
http://mattahan.deviantart.com/art/Buuf-37966044 under a Creative Commons
Attribution-NonCommercial-ShareAlike 2.5 License.
