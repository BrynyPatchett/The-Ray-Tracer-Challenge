

namespace The_Ray_Tracer_Challenge
{
    class Projectile
    {
        public static long GlobalId = 0;

        public Tuple Position { get; set; }
        public Tuple Velocity { get; set; }

        public long Id { get; set; }


        public Projectile(Tuple pos, Tuple velo)
        {
            Position = pos;
            Velocity = velo;
            Projectile.setID(this);

        }
        private static void setID(Projectile p){
           p.Id = GlobalId ++;
        }

    }
}
