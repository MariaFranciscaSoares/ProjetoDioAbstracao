namespace ProjetoJogoRpg.src.Entities
{
  public class Thriller : Menu
  {
    public Thriller(string name, int year, string genre)
    {
      this.Name = name;
      this.Year = year;
      this.Genre = genre;
    }



    public override string Synopsis()
    {
      return "Sofrendo com a partida de Edward, Bella encontra conforto em Jacob, que tem o próprio segredo.";

    }



  }
}