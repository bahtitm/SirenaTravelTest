namespace SirenaTravelTest.Services
{
    public static class AccountantServies
    {
        public static double CalculationBetweenPoints(Point p1, Point p2) 
        {
         
          var step= Math.Sqrt(Math.Pow((double)p1.X - (double)p2.X, 2) + Math.Pow((double)p1.Y - (double)p2.Y, 2));
          return Math.Abs(step);
        }
    }
   public  class Point
    {
        public Point(double? lon, double? lat )
        {
            Y=lon;
            X=lat;
            
        }
        public double? Y { get; set; }
        public double? X { get; set; }


    }
}
