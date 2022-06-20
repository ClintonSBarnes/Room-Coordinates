{
    Random random = new Random();
    bool adjacent;
    int adjacentCounter = 0;
    int minRandomValue = 1;
    int maxRandmoValue = 10;

    Coordinates[] coordinates = new Coordinates[5];

    for (int i = 0; i < coordinates.Length; i++)
    {
        coordinates[i] = new Coordinates(random.Next(minRandomValue, maxRandmoValue), random.Next(minRandomValue, maxRandmoValue));
       
    }

    for (int i = 0; i < coordinates.Length; i++)
    {
        adjacent = false;
        adjacentCounter = 0;

        if (adjacentCounter == 0)
        {
            if (coordinates[i].CoordAdjcent(coordinates[i], coordinates[0]) == true)
            { adjacentCounter++; }
            if (coordinates[i].CoordAdjcent(coordinates[i], coordinates[1]) == true)
            { adjacentCounter++; }
            if (coordinates[i].CoordAdjcent(coordinates[i], coordinates[2]) == true)
            { adjacentCounter++; }
            if (coordinates[i].CoordAdjcent(coordinates[i], coordinates[3]) == true)
            { adjacentCounter++; }
            if (coordinates[i].CoordAdjcent(coordinates[i], coordinates[4]) == true)
            { adjacentCounter++; }
        }
        if (adjacentCounter > 1)
        {
            adjacent = true;
        }
        else adjacent = false;

        Console.WriteLine($"{coordinates[i].GetX(coordinates[i])}, {coordinates[i].GetY(coordinates[i])}, {adjacent}");
    }


}




public struct Coordinates
{
    private double X { get; init; }
    private double Y { get; init; }

    public Coordinates(double x, double y)
    {
        Coordinates coord = new Coordinates();
        this.X = x;
        this.Y = y;

    }

    public bool CoordAdjcent(Coordinates first, Coordinates second)
    {
        bool holder = false;

        if (first.X == second.X - 1 || first.X == second.X + 1 || first.X == second.X)
        {
            if (first.Y == second.Y - 1 || first.Y == second.Y + 1 || first.Y == second.Y)
            { 
               holder =  true;
            }

            return holder;
        }
        else return holder;
    }


    public double GetX(Coordinates coord)
    {
        return coord.X;

    }

    public double GetY(Coordinates coord)
    {
        return coord.Y;
    }





}