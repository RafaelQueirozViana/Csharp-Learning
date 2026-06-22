namespace loopingFunctions
{
    class Triangle
    {
        public double Aside;
        public double Bside;
        public double Cside;

        public double getArea()
        {

            double p = (Aside + Bside + Cside) / 2;
            double area = Math.Sqrt(p * (p - Aside) * (p - Bside) * (p-Cside) );


            return Aside * Bside * Cside;
        }

        

        
    }
} 

