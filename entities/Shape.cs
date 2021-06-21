using abstraticb.entities.enums;



namespace abstraticb.entities


{
   public abstract class Shape
    {
        public Color Color{get;set;}


        public Shape(Color color){


            Color = color;

        }

       public abstract double Area();

    }
}
