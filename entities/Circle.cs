using System;
using abstraticb.entities.enums;
using abstraticb.entities;


namespace abstraticb.entities
{
    public class Circle: Shape
    {
        public double Radium{get;set;}

        public Circle(Color color,double radium):base(color){

            Radium = radium;


        }

        public override double Area()
        {
            return Math.PI * Radium * Radium;

        }





    }
}
