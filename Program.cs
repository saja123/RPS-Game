namespace RPS_Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RPSGame game = new RPSGame("Saja");
                game.PlayGame();
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Thank you for playing");
            }
        }
    }
}
