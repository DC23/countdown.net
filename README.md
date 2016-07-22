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

Pomodoro Mode implements a basic Pomodoro timer, with configurable pomodoro and break times (both long and short breaks).
The ratio of long to short breaks is currently hard-coded but this may change in a future release.

# Future Plans
The current app started as a personal project for personal use. Thus the current code is a dogs breakfast of special-case logic.
Additionally, the GUI is quite inflexible. The high-level roadmap for changes includes:
- Refactoring to split the timer implementation from pomodoro implementation.
- Refactoring to split the UI from the timer implementations, with the ability to switch the user interface over an active timer or pomodoro. 
This will be used to implement cleaner interfaces for timer and pomodoro functions, as well as a more compact stealth-mode UI for running in 
"always on top" mode.
- A more dynamically resizable user interface rather than the current implementation, where resizing is quite pointless.
- Habitica integration for pomodoro mode. At a minimum there will be the ability to score a habit when a pomodoro is completed or cancelled.

# Attributions
The apple icon is from the Buuf icon set by Mattahan, available at  
http://mattahan.deviantart.com/art/Buuf-37966044 under a Creative Commons 
Attribution-NonCommercial-ShareAlike 2.5 License.