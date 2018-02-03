namespace MarsRoverkata
{
    public class BidimensionalCoordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public BidimensionalCoordinates() : this(0, 0) { }

        public BidimensionalCoordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void ModifyX(int units)
        {
            X += units;
        }

        public void ModifyY(int units)
        {
            Y += units;
        }
    }
}