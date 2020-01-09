

namespace The_Ray_Tracer_Challenge
{
    public class PointLight
    {


        public Tuple Position { get; set; }
        public Tuple ColorIntensity { get; set; }
       

        public PointLight()
        {
                Position = new Tuple(0,0,0,1);
                ColorIntensity = new Tuple(0,0,0,0);
        }
        public PointLight(Tuple pos, Tuple colorIntensity)
        {
            Position = pos;
            ColorIntensity = colorIntensity;
        }

    }
}
