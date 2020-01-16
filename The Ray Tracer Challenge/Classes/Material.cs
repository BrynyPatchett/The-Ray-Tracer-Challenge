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

       

        public Material()
        {
                Colour = new Tuple(1,1,1,0);
                Ambient = 0.1f;
                Diffuse = 0.9f;
                Specular = 0.9f;
                Shininess = 200.0f;

        }
        public Material(Tuple colour, float ambient,float diffuse,float specular,float shininess)
        {
                Colour = colour;
                Ambient = ambient;
                Diffuse = diffuse;
                Specular = specular;
                Shininess = shininess;
        }

        public static Tuple Lighting(Material m, PointLight light, Tuple position, Tuple eyeVec, Tuple normalVec, bool inShadow){

            Tuple colour;
            Tuple ambient;
            Tuple diffuse;
            Tuple specular;
            

            Tuple effective_colour = m.Colour * light.ColorIntensity;
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
