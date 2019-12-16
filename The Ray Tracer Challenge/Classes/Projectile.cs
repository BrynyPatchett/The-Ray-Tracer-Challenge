

namespace The_Ray_Tracer_Challenge
{
    class Projectile
    {


        public Tuple Position { get; set; }
        public Tuple Velocity { get; set; }


        public Projectile(Tuple pos, Tuple velo)
        {
            Position = pos;
            Velocity = velo;
        }

    }
}
