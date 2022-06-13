public class Rules{


    public int WhoWins(string p1c, string p2c){
        if(p1c == p2c){
            return 0;
        }
        else if(p1c == "S" && p2c == "P"){
            return 1;
        }
        else if(p1c == "P" && p2c == "R"){
            return 1;
        }
        else if(p1c == "R" && p2c == "S"){
            return 1;
        }
        else {
            return 2;
        }
    }

}