//here goes the main method
class Score {
    public string name;
    public int points;
    public int level;
    public bool EarnedStar() => (points / level) > 1000;
}

//other classes and enumerations can go here