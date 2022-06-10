//Create a class team with teamName string, and noOfPlayers int.
public class team
{
    public string teamName { get; set; }
    public int noOfPlayers { get; set; }

    public team(string teamName, int noOfPlayers)
    {
        this.teamName = teamName;
        this.noOfPlayers = noOfPlayers;
    }

    //member function to AddPlayer(count) to the team.
    public void AddPlayer(int count)
    {
        noOfPlayers += count;
    }

    //member function to RemovePlayer(count) to the team. it takes integer count as parameter. and removes count number of players from the team.
    //if decreasing makes noOfPlayers negative, then this method should return false; else decrease noOfPlayers by count and return true.

    public bool RemovePlayer(int count)
    {
        if (noOfPlayers - count < 0)
        {
            return false;
        }
        else
        {
            noOfPlayers -= count;
            return true;
        }
    }
}

//create a class Subteam inherits team class. constructor should take 2 parameters teamName and noOfPlayers. and calls base class constructor with 2 parameters.
public class Subteam : team
{
    public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers)
    {
    }

    //
}