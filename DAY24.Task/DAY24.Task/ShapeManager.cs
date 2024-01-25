using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY24.Task
{


    //Shapes
 //- GetCircleCount() - shapes arrayindeki circle-larin sayini qaytarir
 //- GetCircles() - shapes arrayindeki circle-lardan ibaret yeni bir arrray qaytarir(circle arrayi)
 //- GetTotalCircleAreas() - shapes arrayindeki circle-larin sahelerinin cemini qaytarir
 //- GetSquareCount() - shapes arrayindeki width ve height deyerleri beraber olan rectangle-larin sayini qaytarir
 //- AddShape() - gonderilen shape deyerini shapes arrayine elave edir.
    internal class ShapeManager
    {
        Shape[] shapes = new Shape[0];

        public int GetCircleCount()
        {
            int count = 0;  
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                    count++;
            }
            return count;
        }

        public Circle[] GetCircles()
        {
            int count = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                    count++;
            }

            Circle[] circles = new Circle[count];

            int index = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                {
                    circles[index] = (Circle)shapes[i];
                    index++;
                }
            }

            return circles;

        }

        public double GetTotalCircleAreas()
        {
            double totalArea = 0;
            
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Circle)
                    totalArea += shapes[i].CalculateArea();
            }
            return totalArea;   
        }

        public int GetSquareCount()
        {
            int count = 0;  
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Rectangle)
                {
                    Rectangle rect = (Rectangle)shapes[i];
                    if (rect.Width == rect.Length)
                        count++;

                }
            }
            return count;

        }

        public void AddShape(Shape shape)
        {
            Array.Resize(ref shapes, shapes.Length+1);
            shapes[shapes.Length-1] = shape;
            Console.WriteLine("New shape added !");

        }




    }
}
