   public class Team 
   {
        public string teamName {get;set;}
        public int noOfPlayers {get;set;}
        public Team(string team, int players)
        {
            teamName = team;
            noOfPlayers = players; 
        }
        
        public void AddPlayer(int count)
        {
            noOfPlayers += count;
        }
        
        public bool RemovePlayer(int count)
        {
            if(noOfPlayers<=0) 
                return false;
            else 
            {
                noOfPlayers -= count;
                return true;
            }
        }
    }

    public class Subteam : Team {
        
        public Subteam(string teanName, int noOfPlayer)
        {
            base.Team(string teanName, int noOfPlayer);
        }
        
        public void ChangeTeamName(string name)
        {
            base.teamName = name;
        }
        
    }