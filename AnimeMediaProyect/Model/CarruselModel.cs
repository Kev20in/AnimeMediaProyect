namespace AnimeMediaProyect
{
    public class CarruselList{
    public string Title  { get; set; }
    public CarruselItem[] List { get; set; }
    }

    public class CarruselItem{
    public string Image  { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    }
}