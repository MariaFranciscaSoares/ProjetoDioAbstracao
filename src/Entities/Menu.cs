

namespace ProjetoJogoRpg.src.Entities
{
  public abstract class Menu
  {
    public Menu(string Name, int Year, string Genre)
    {
      this.Name = Name;
      this.Year = Year;
      this.Genre = Genre;
    }
    public Menu()
    {

    }
    public string Name;
    public int Year;
    public string Genre;

    public override string ToString()
    {
      return this.Name + " " + this.Year + " " + this.Genre;
    }
    public virtual string Synopsis()
    {
      return "Synopsis the film ";
    }

  }

  }

