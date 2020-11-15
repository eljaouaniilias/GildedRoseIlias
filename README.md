# GildedRoseIlias
This repository contains a .NET Framework 4.5 (C#) solution based on the refactoring of the **'Gilded Rose'** kata by Emilie Bache. <br>
The solution consists of a test project (NUnit), a library project (angry goblin's untouched code) and a console application. <br>

## Refactoring
I chose to start by extracting the class that wasn't to be edited and put it in an independent library project.<br><br> I then created a test project for the existing implementation. I created a test for each scenario described in the requirements of the kata and got them all to pass.<br><br>
I went on by creating an extension class for the unchangeable *Item* class in my console application so that I could add an *UpdateSelf* method that would allow each item to update itself on a more readable manner.<br><br>

I finally created an exception for when an unknown item is added in the list. 

## Requirements
- .NET Framework 4.5
- Visual Studio 

## Getting Started
1. Clone this repository to your workspace
2. Open the solution (.sln) file 
3. Build the solution
4. Start the console application

## References
Emily Bache's Gilded Rose kata: [https://github.com/emilybache/GildedRose-Refactoring-Kata](https://github.com/emilybache/GildedRose-Refactoring-Kata, "https://github.com/emilybache/GildedRose-Refactoring-Kata")
