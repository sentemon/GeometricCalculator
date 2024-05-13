using System;
using GeometryCalculator;

namespace Shapes 
{
    // Circle class is a subclass of TwoDimensionalShape class
    public class Circle : TwoDimensionalShape
    {
        private readonly double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        // IfCircle method is called when the user chooses Circle
        public static void CircleChosen()
        {
            string enterRadius = "Enter the radius of the circle: ";
            Features.WriteMessage(enterRadius);

            try
            {
                double radius = double.Parse(Console.ReadLine());
                Circle circle = new Circle(radius);

                string choiceMessage = "Do you want to calculate the area or perimeter of the circle or both? (Area: a | Perimeter: p | Both: b)";
                Features.WriteMessage(choiceMessage);
                string choice = Console.ReadKey().Key.ToString().ToLower();

                if (choice == "a")
                {
                    string areaMessage = $"\nThe area of the circle is {circle.Area()}";
                    Features.WriteMessage(areaMessage);
                }
                else if (choice == "p")
                {
                    string perimeterMessage = $"\nThe perimeter of the circle is {circle.Perimeter()}";
                    Features.WriteMessage(perimeterMessage);
                }
                else if (choice == "b")
                {
                    string areaMessage = $"\nThe area of the circle is {circle.Area()}";
                    Features.WriteMessage(areaMessage);

                    string perimeterMessage = $"The perimeter of the circle is {circle.Perimeter()}";
                    Features.WriteMessage(perimeterMessage);
                }
                else
                {
                    string invalidChoice = "\nInvalid input. Please enter a valid choice.";
                    Features.WriteMessage(invalidChoice);
                }
            }
            
            catch (Exception e)
            {
                string errorMessage = $"\nError: {e.Message}";
                Features.WriteMessage(errorMessage);

                string enterValidNumber = "Please enter a valid number.";
                Features.WriteMessage(enterValidNumber);
                
                CircleChosen();
            }
        }
    }
}