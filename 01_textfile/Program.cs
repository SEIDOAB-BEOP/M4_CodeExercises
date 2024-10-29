// See https://aka.ms/new-console-template for more information
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello, World!");

var _seeder = new csSeedGenerator();

Console.WriteLine("Boguslatin sentence");
System.Console.WriteLine(_seeder.LatinSentence);

Console.WriteLine("List of boguslatin sentence of random length");
var sentences = _seeder.LatinSentences(_seeder.Next(0,10));
Console.WriteLine(sentences.Count);
Console.WriteLine(sentences[0]);

/* Exercise
1. Create a text file in your MyDocuments folder, called myLatinBook.txt that contains 200 boguslatin paragraphs
   Each paragraph is speparated by two new line characters \n\n\n and consists of randomly between 4 and 50 sentences.
   Each sentence shall end with a single new line character \n

2. Set a header for each chapter consting of a chapter number, incremented correctly from chapter to chapter, 
   and 3 to 8 random latin words followed by two new line characters \n\n

3. Make a firstline header on the book with your name as author. The header should be captial characters.
   Add an ISBN numer to the book, assuming an isbn number is a GUID

   Below is a book example with two paragraph:

   NISL PRETIUM FUSCE ID VELIT
   By Martin Lenart
   
   ISBN: 6298C7B6-2769-4A84-B802-81492B333B3C

   Chapter 1: Nec ultrices dui sapien eget

   Habitant morbi tristique senectus et netus et malesuada fames. 
   Sed elementum tempus egestas sed sed risus pretium. 
   Non nisi est sit amet facilisis. 
   Tempus imperdiet nulla malesuada pellentesque elit. 
   

   Chapter 2: Libero enim sed faucibus

   Turpis in eu mi bibendum. 
   In fermentum et sollicitudin ac orci phasellus egestas tellus. 
   Nisl pretium fusce id velit ut tortor pretium.

*/
