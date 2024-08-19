namespace Basic.Models
{
  public class Repository
  {
    private static readonly List<Bootcamp> _bootcamps = new();
    static Repository()
    {
      _bootcamps = new List<Bootcamp>(){
        new Bootcamp() { Id = 1,
                         Title = "Full-Stack",
                         Description = "Başladı.",
                         Image = "1.jpg",
                         Tags =new string[]{"Html", "Web Geliştirme"},
                         isActive = true,
                         isHome = true
        },

        new Bootcamp() { Id = 2,
                         Title = "Game",
                         Description = "Başladı.",
                         Image = "2.png",
                         Tags =new string[]{"Oyun", "Web Geliştirme"},
                         isActive = true,
                         isHome = true
        },

        new Bootcamp() { Id = 3,
                         Title = "Mobil",
                         Description = "Başladı.",
                         Image = "3.jpg",
                         Tags =new string[]{"Html", "Mobil"},
                         isActive = false,
                         isHome = false
        },
      };
    }
    public static List<Bootcamp> Bootcamps
    {
      get
      {
        return _bootcamps;
      }
    }
    public static Bootcamp? GetById(int? id)
    {
      return _bootcamps.FirstOrDefault(b => b.Id == id);
    }
  }
}