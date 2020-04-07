using System;


namespace The_Ray_Tracer_Challenge
{
    public class Material
    {


        public Tuple Colour { get; set; }
        public float Ambient { get; set; }
        public float Diffuse { get; set; }          
         
        public float Specular { get; set; }

        public float Shininess { get; set; }

        public float Reflective{ get; set; }   

        public float Transparency{ get; set; }   

        public float Refractive_index{ get; set; }

        public Pattern Pattern { get; set; }

       

        public Material()
        {
                Colour = new Tuple(1,1,1,0);
                Ambient = 0.1f;
                Diffuse = 0.9f;
                Specular = 0.9f;
                Shininess = 200.0f;
                Reflective = 0.0f;
                Transparency = 0.0f;
                Refractive_index = 1.0f;


        }
        public Material(Tuple colour, float ambient,float diffuse,float specular,float shininess,float reflective, float transparency, float refractive_index)
        {
                Colour = colour;
                Ambient = ambient;
                Diffuse = diffuse;
                Specular = specular;
                Shininess = shininess;
                Reflective = reflective;
                Transparency = transparency;
                Refractive_index = refractive_index;
        }

        public static Tuple Lighting(Material m,Shape Object, PointLight light, Tuple position, Tuple eyeVec, Tuple normalVec, bool inShadow){

            Tuple colour;
            Tuple ambient;
            Tuple diffuse;
            Tuple specular;
            colour = m.Colour;
            if(m.Pattern != null){
                colour = m.Pattern.PatternAtShape(Object,position);
            }

            Tuple effective_colour = colour * light.ColorIntensity;
            Tuple lightDirection = (light.Position - position).Normalise();

            ambient = effective_colour * m.Ambient;

            float lightDotNormal = Tuple.Dot(lightDirection,normalVec);


            if(lightDotNormal < 0){
                diffuse = new Tuple(0,0,0,0);
                specular = new Tuple(0,0,0,0);
            }
            else if(inShadow)
            {
                diffuse = new Tuple(0,0,0,0);
                specular = new Tuple(0,0,0,0);
            }
            
            else{
                diffuse = effective_colour * m.Diffuse * lightDotNormal;
                Tuple reflectV = Tuple.Reflect(-lightDirection, normalVec);
                float reflectDotEye = Tuple.Dot(reflectV,eyeVec);
                if(reflectDotEye <= 0){
                    specular = new Tuple(0,0,0,0);
                }else{
                    float pow = MathF.Pow(reflectDotEye,m.Shininess);
                    specular = light.ColorIntensity * m.Specular * pow;
                    
                }


            }


            return ambient + diffuse + specular;


        } 


    }
}
