

namespace AnimeMediaProyect
{
    public class CarruselServices{

    public List<CarruselList> GetCarrusel()
    {
        var list = new List<CarruselList>();
        var item = new CarruselItem[]{
            new CarruselItem{
            Image = "https://imgsrv.crunchyroll.com/cdn-cgi/image/format=auto,width=480,height=720,fit=contain,quality=85/catalog/crunchyroll/f446d7a2a155c6120742978fb528fb82.jpe",
            Name = "Frieren: Más allá del final del viaje",
            Description = "La maga Frieren formaba parte del grupo del héroe Himmel, quienes derrotaron al Rey Demonio tras un viaje de 10 años y devolvieron la paz al reino.",
            Url = "../Frieren.url"
        },
        new CarruselItem{
            Image = "https://imgsrv.crunchyroll.com/cdn-cgi/image/format=auto,width=480,height=720,fit=contain,quality=85/catalog/crunchyroll/5e7f533c3b4f46244ca228af62e83dfa.jpe",
            Name = "Solo Leveling",
            Description = "La maga Frieren formaba parte del grupo del héroe Himmel, quienes derrotaron al Rey Demonio tras un viaje de 10 años y devolvieron la paz al reino",
            Url = "../Frieren.url"
        },
        new CarruselItem{
            Image = "https://imgsrv.crunchyroll.com/cdn-cgi/image/format=auto,width=480,height=720,fit=contain,quality=85/catalog/crunchyroll/5e7f533c3b4f46244ca228af62e83dfa.jpe",
            Name = "Solo Leveling",
            Description = "La maga Frieren formaba parte del grupo del héroe Himmel, quienes derrotaron al Rey Demonio tras un viaje de 10 años y devolvieron la paz al reino",
            Url = "../Frieren.url"
        }
        };
      
        var carrusel = new CarruselList{
            Title = "NEW RELEASES",
            List = item
        };

        list.Add(carrusel);
        return list;
    }
    }
}