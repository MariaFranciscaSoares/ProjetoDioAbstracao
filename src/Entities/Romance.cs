
namespace ProjetoJogoRpg.src.Entities
{
  public class Romance : Menu
  {
    
    public Romance(string name, int year, string genre)
    {
      this.Name = name;
      this.Year = year;
      this.Genre = genre;

      Name = "A Saga Crepúsculo - Lua Nova";
      Year = 2009;
      Genre = "Romance";
    }
    public override string Synopsis()
    {
        return "Sofrendo com a partida de Edward, Bella encontra conforto em Jacob, que tem o próprio segredo.";
  
    }

    

  }
}

// H.E.P.A.
// HERANÇA 
// ENCAPSULAMENTO 
// POLIMORFISMO 
// ABSTRAÇÃO 