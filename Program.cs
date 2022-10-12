public interface GeoObject
{
    public double x { get; set; }
    public double y { get; set; }
    public string name { get; set; }
    public string desc { get; set; }
    public void GetInformation();
}
class River : GeoObject
{
    private double x_riv;
    private double y_riv;
    private string name_riv;
    private string desc_riv;
    private double flow_riv;
    private double len_riv;
    public double x { get => x_riv; set => x_riv = value; }
    public double y { get => y_riv; set => y_riv = value; }
    public string name { get => name_riv; set => name_riv = value; }
    public string desc { get => desc_riv; set => desc_riv = value; }
    public double flow { get => flow_riv; set => flow_riv = value; }
    public double len { get => len_riv; set => len_riv = value; }
    public void GetInformation()
    {
        Console.WriteLine($"X: {x}\nY: {y}\nName: {name}\nDescription: {desc}\nFlow: {flow}\nLength: {len}");
    }
}
class Mountain : GeoObject
{
    private double x_mount;
    private double y_mount;
    private string name_mount;
    private string desc_mount;
    private double peak_mount;
    public double x { get => x_mount; set => x_mount = value; }
    public double y { get => y_mount; set => y_mount = value; }
    public string name { get => name_mount; set => name_mount = value; }
    public string desc { get => desc_mount; set => desc_mount = value; }
    public double peak { get => peak_mount; set => peak_mount = value; }
    public void GetInformation()
    {
        Console.WriteLine($"X: {x}\nY: {y}\nName: {name}\nDescription: {desc}\nPeak: {peak}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        River river1 = new River();
        Mountain mountain1 = new Mountain();

        river1.x = 3;
        river1.y = 60;
        river1.name = "Amazon";
        river1.flow = 2;
        river1.len = 6992;
        river1.desc = "The longest river in the world";

        mountain1.x = 27;
        mountain1.y = 86;
        mountain1.name = "Everest";
        mountain1.peak = 8849;
        mountain1.desc = "The highest mountain in the world";

        Console.WriteLine("River:");
        river1.GetInformation();
        Console.WriteLine();

        Console.WriteLine("Mountain:");
        mountain1.GetInformation();

        Console.ReadKey(true);
    }
}