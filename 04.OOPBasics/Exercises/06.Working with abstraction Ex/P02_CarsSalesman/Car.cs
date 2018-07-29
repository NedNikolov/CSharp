using System.Text;

public class Car
{
    private const string offset = "  ";

    public string model;
    public Engine engine;
    public int weight;
    public string color;

    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = -1;
        this.Color = "n/a";
    }

    public Car(string model, Engine engine, int weight)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = weight;
        this.Color = "n/a";
    }

    public Car(string model, Engine engine, string color)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = -1;
        this.Color = color;
    }

    public Car(string model, Engine engine, int weight, string color)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = weight;
        this.Color = color;
    }

    public string Model
    {
        get => model;
        set => model = value;
    }
    internal Engine Engine
    {
        get => engine;
        set => engine = value;
    }
    public int Weight
    {
        get => weight;
        set => weight = value;
    }
    public string Color
    {
        get => color;
        set => color = value;
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("{0}:\n", this.model);
        sb.Append(this.engine.ToString());
        sb.AppendFormat("{0}Weight: {1}\n", offset, this.weight == -1 ? "n/a" : this.weight.ToString());
        sb.AppendFormat("{0}Color: {1}", offset, this.color);

        return sb.ToString();
    }
}