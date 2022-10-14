using GettersAndSetters;

Console.WriteLine("Getter and Setters");

Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
shrek.Rating = "R";
Console.WriteLine(shrek.Rating);
