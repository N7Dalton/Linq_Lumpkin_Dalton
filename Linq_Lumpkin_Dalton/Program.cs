// See https://aka.ms/new-console-template for more information
using Linq_Lumpkin_Dalton;
//game array
Game[] games = new Game[]
{
    //good games
    new Game("Minecraft", 'E', "Action-Adventure"),
    new Game("Apex", 'T', "FPS"),
    new Game("Hell Let Loose", 'M', "FPS"),
    new Game("CSGO 2", 'M', "FPS"),
    new Game("Portal", 'T', "Action-Adventure"),
    new Game("Spiderman(PS4)", 'T', "Action-Adventure"),
    new Game("OverWatch", 'T', "FPS"),
    new Game("Skate 3", 'T', "Action-Adventure"),
    new Game("Super Mario Galaxy", 'E', "Action-Adventure")
};
//from where select malarky
var shortGames = from game in games
                 where game.Title.Length < 9
                 select $"Game Title: {game.Title.ToUpper()}";

foreach (var game in games)
{
    Console.WriteLine(game);
}

var minecraft = games.Where(game => game.Title == "Minecraft")
 .Select(game => $"Title: {game.Title}, ESBR: {game.Esbr}, Genre: {game.Genre}");

Console.WriteLine(minecraft.FirstOrDefault());
//from where and select junk
var eAction = from game in games
             where game.Esbr == 'T'
             select game.Title;

Console.WriteLine("E Rated Action Games:");
//love foreach loops <3
foreach (var game in eAction)
{
    Console.WriteLine(game);
}
//from where select stuff
var eRatedAction = from game in games
                   where game.Esbr == 'E' && game.Genre.Contains("Action")
                   select game.Title;

        
