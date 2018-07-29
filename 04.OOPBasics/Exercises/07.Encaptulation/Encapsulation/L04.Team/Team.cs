using System.Collections.Generic;

public class Team
{
    private List<Person> firstTeam;
    private List<Person> reserveTeam;
    private string name;

    public IReadOnlyCollection<Person> FirstTeam
    {
        get { return firstTeam; }
    }

    public IReadOnlyCollection<Person> ReserveTeam
    {
        get { return reserveTeam; }
    }

    public Team(string name)
    {
        firstTeam = new List<Person>();
        reserveTeam = new List<Person>();
        this.name = name;
    }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
            firstTeam.Add(person);
        else
            reserveTeam.Add(person);
    }



}
