/*
public class Player
{
    public string Name { get; }
    public int Number { get; }
    public Player(string name, int number)
    {
        Name = name;
        Number = number;

    }
    public override bool Equals(object o)
    {
        if (o == null) return false;

        if (o.GetType() != GetType()) return false;

        Player oth = (Player)o;
        return Name.Equals(oth);
    }
    public override int GetHashCode()
    {
        return ToSting().GetHashCode();
    }
        

}
*/