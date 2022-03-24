using System.Collections;

namespace ChampionsLeagueLibrary;

public enum FootballClub
{
    None,
    FCPorto,
    Arsenal,
    RealMadrid,
    Chelsea,
    Barcelona
}

// TODO: Vytvořte statickou třídu FootballClubInfo

public static class FootballClubInfo {
    // TODO: Vytvořte veřejnou konstatu int Count, která vrací počet hodnot (položek) ve výčtovém typu FootballClub
    //public const int Count = Enum.GetValues(typeof(FootballClub)).Length;
    public const int Count = 6;

    // TODO: Vytvořte veřejnou statickou vlastnost IEnumerable Items, která disponuje pouze operací get
    // - pomocí enumerátoru vraťte všechny položky ve výčtovém typu FootballClub (od None až po Barcelona)
    public static IEnumerable Items => Enum.GetValues(typeof(FootballClub));

    // TODO: Vytvořte veřejnou statickou metodu string GetName
    // - parametr FootballClub footballClub
    // - metoda vrací řetězcové vyjádření pro každou položku výčtového typu
    // None -> "", FCPorto -> "FC Porto", Arsenal -> "Arsenal", RealMadrid -> "Real Madrid"
    // Chelsea -> "Chelsea", Barcelona -> "Barcelona"
    // - jinak je vrácen prázdný řetězec
    public static string GetName(FootballClub footballClub) {
        string name = Enum.GetName(typeof(FootballClub), footballClub);
        if (name == "FCPorto") return "FC Porto";
        if (name == "RealMadrid") return "Real Madrid";
        if (name == "None") return "";
        return name;
    }

    // Konec třídy FootballClubInfo
}