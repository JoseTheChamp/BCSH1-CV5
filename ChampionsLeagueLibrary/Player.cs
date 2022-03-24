namespace ChampionsLeagueLibrary;

// TODO: Vytvořte třídu Player

public class Player {
    // TODO: Vytvořte vlastnosti
    // - string Name
    // - FootballClub Club
    // - int GoalCount
    public string Name { get; set; }
    public FootballClub Club { get; set; }
    public int GoalCount { get; set; }
    // TODO: Vytvořte parametrický konstruktor (name, club, goalCount)
    public Player(string name, FootballClub club, int goalCount)
    {
        Name = name;
        Club = club;
        GoalCount = goalCount;
    }

    public override string? ToString()
    {
        return "Jméno: " + Name + ", Klub: " + FootballClubInfo.GetName(Club) + ", Góly: " + GoalCount;
    }
    //  Konec třídy Player
}

