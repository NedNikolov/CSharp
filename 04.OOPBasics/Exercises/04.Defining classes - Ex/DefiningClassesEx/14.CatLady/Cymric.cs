public class Cymric : Cat
{
    private double furLength;

    public Cymric(string breed, string name, double furLenght) : base(breed, name)
    {
        this.furLength = furLenght;
    }

    public override string ToString()
    {
        return $"{base.ToString()} {this.furLength:f2}";
    }
}