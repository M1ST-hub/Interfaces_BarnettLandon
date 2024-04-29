namespace Interfaces_BarnettLandon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calls play game method
            Game myGame = new Game("T", "FPS", "Apex Legends");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();
            //Calls play movie method
            Movie myMovie = new Movie("R", "Action/Comedy", "Bullet Train");
            Console.WriteLine(myMovie.Describe()); 
            myMovie.PlayMovie();
        }
    }
}