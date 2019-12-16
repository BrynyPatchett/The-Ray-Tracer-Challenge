

namespace The_Ray_Tracer_Challenge
{
    public class Environment
    {


        public Tuple Gravity { get; set; }
        public Tuple WindSpeed { get; set; }


        public Environment(Tuple grav, Tuple wind)
        {
            Gravity = grav;
            WindSpeed = wind;
        }

    }
}
