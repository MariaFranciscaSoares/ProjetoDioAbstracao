namespace ProjetoJogoRpg.src.Entities
{
  public class Comedy : Menu
  {
    public Comedy(string Name, int Year, string Genre)
    {
      this.Name = Name;
      this.Year = Year;
      this.Genre = Genre;
    }

   public override string Synopsis()
    {
        return "Sofrendo com a partida de Edward, Bella encontra conforto em Jacob, que tem o próprio segredo.";
  
    }

  }
}
