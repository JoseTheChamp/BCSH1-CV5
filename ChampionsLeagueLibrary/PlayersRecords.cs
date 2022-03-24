namespace ChampionsLeagueLibrary;

// TODO: Vytvořte třídu PlayersCountChangedEventArgs (dědící z EventArgs)
// - vlastnost int OldCount
// - vlastnost int NewCount
public class PlayersCountChangedEventArgs : EventArgs {

    public int OldCount { get; set; }
    public int NewCount { get; set; }
}
// TODO: Vytvořte delegát pro událost PlayersCountChangedEventHandler (využijte výše definované event args)
public delegate void PlayersCountChangedEventHandler(object sender, PlayersCountChangedEventArgs e);
// TODO: Vytvořte třídu PlayersRecords
public class PlayersRecords {
    // TODO: Vytvořte atribut players typu Player[]
    public Player[] players;

    // TODO: Vytvořte vlastnost Count (pouze pro čtení), která vždy vrací aktuální velikost pole players
    public int Count => players.Length;
    // TODO: Vytvořte událost PlayersCountChanged (PlayersCountChangedEventHandler)
    public event PlayersCountChangedEventHandler PlayersCountChanged;
    // TODO: vytvořte indexer [int index], který umožňuje získat Player? z pole (pouze operace get)
    // - get - pokud je index neplatný, je vráceno null; jinak je vrácen objekt z pole
    public Player? this[int i]
    {
        get {
            if (!(i >= 0 && i < Count))
            {
                return null;
            }
            return players[i];
        }
    }
    // TODO: Vytvořte bezparametrický konstruktor
    // - inicializujte pole players na pole délky 0
    public PlayersRecords() { 
        players = new Player[0];
    }

    // TODO: Vytvořte metodu void Add(Player player)
    // - zvětšete velikost pole o jeden prvek
    // - na poslední index v poli je vložen nový hráč (player)
    // - vyvolejte událost PlayersCountChanged s příslušnými argumenty

    public void Add(Player player) { 
    Player[] nPlayers = new Player[Count + 1];
        if (Count == 0)
        {
            nPlayers[0] = player;
        }
        else { 
        nPlayers[Count] = player;
        Array.Copy(players, 0, nPlayers, 0, nPlayers.Length - 1);
        }
        players = nPlayers;
        PlayersCountChanged?.Invoke(this, new PlayersCountChangedEventArgs() { OldCount = Count - 1, NewCount = Count });
    }

    // TODO: Vytvořte metodu void Delete(int index)
    // - pokud je index neplatný - metoda nedělá nic
    // - odeberte vybraného hráče z pole, pole setřeste (posuňte hráče z vyšších indexů, tak aby byla zaplněna (null) mezera; zachovejte pořadí hráčů)
    // - zmenšete velikost pole o 1 prvek
    // - vyvolejte událost PlayersCountChanged s příslušnými argumenty

    public void Delete(int index) {
        if (!(index >= 0 && index < Count))
        {
            return;
        }
        Player[] nPlayers = new Player[Count - 1];
        for (int i = 0; i < nPlayers.Length; i++)
        {
            if (i >= index)
            {
                nPlayers[i] = players[i+1];
                continue;
            }
            nPlayers[i] = players[i];
        }
        players = nPlayers;
        PlayersCountChanged?.Invoke(this, new PlayersCountChangedEventArgs() { OldCount = Count + 1, NewCount = Count });
    }

    // TODO: Vytvořte metodu bool FindBestClubs(...)
    // - výstupní parametr FootballClub[] clubs
    // - výstupní parametr int goalCount
    // - pokud je pole players prázdné - pak - clubs: prázdné pole, goalCount: 0, metoda vrací false
    // - sečtěte počty gólů podle klubů
    // - najděte maximální počet gólů a uložte jej do goalCount
    // - najděte všechny kluby, které mají celkově goalCount gólů a uložte je do clubs
    // - vraťte true

    public bool FindBestClubs(out FootballClub[] clubs, out int goalCount) {
        if (Count == 0)
        {
            clubs = new FootballClub[0];
            goalCount = 0;
            return false;
        }

        Dictionary<FootballClub, int> sumByClub = SumByClubs();

        KeyValuePair<FootballClub, int> maxGoalCount = sumByClub.MaxBy(pair => pair.Value);

        int clubsLenght = 0;

        FootballClub[] bestClubs = new FootballClub[FootballClubInfo.Count];
        foreach (KeyValuePair<FootballClub, int> sum in sumByClub)
        {
            if (sum.Value == maxGoalCount.Value)
            {
                bestClubs[clubsLenght++] = sum.Key;
            }
        }

        clubs = bestClubs;
        goalCount = maxGoalCount.Value;
        return true;
    }

    private Dictionary<FootballClub, int> SumByClubs()
    {
        Dictionary<FootballClub, int> sumByClub = new Dictionary<FootballClub, int>();

        foreach (Player player in players)
        {
            if (!sumByClub.ContainsKey(player.Club))
            {
                sumByClub.Add(player.Club, 0);
            }

            sumByClub[player.Club] += player.GoalCount;
        }

        return sumByClub;
    }

}

    // Konec třídy PlayerRecords