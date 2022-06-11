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
    //if 
    

}