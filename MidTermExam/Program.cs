using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExam
{
    public class MidTermCode
    {
        static void Main(string[] args)
        {
            // Variables
            int userChoice;
            string enterNumber;
            do
            {
                // Give Options To User What User Want.

                Console.WriteLine("--------------------Start MidTerm Exam----------------------");
                Console.WriteLine("Choose Option Which You Want");
                Console.WriteLine("1.Enter Screen Dimensions:-");
                Console.WriteLine("2.Exit");
                enterNumber = Console.ReadLine();
            } while (!int.TryParse(enterNumber, out userChoice) || (userChoice < 1) || (userChoice > 2));

            MidTermCode midTermCode = new MidTermCode();

            // Switch Case For Method Calling and Checking

            switch (userChoice)
            {
                case 1:
                    midTermCode.UserEnterNumber();
                    break;

                case 2:
                    return;

                default:
                    Console.WriteLine("Please Select Right Option...");
                    break;
            }
            Console.ReadKey();
        }


        // UserEnerNumber Method...
        public void UserEnterNumber()
        {
            // Variables for width of screen
            int screenWidth;
            string userWidth;
            do
            {
                Console.WriteLine("------------------------------------------");
                Console.Write(" Enter Width Of Screen(Must In Integer): ");
                userWidth = Console.ReadLine();
            } while (!int.TryParse(userWidth, out screenWidth) || (screenWidth <= 0));

            // Variables for Height of screen

            int screenHeight;
            string userHeight;
            do
            {

                Console.Write("Enter Height Of Screen(Must In Integer): ");
                userHeight = Console.ReadLine();
            } while (!int.TryParse(userHeight, out screenHeight) || (screenHeight <= 0));

            // Variable for DaigonalSize of Screen

            int screenDiagonalSize;
            string userDiagonalSize;
            do
            {
                Console.Write("Enter DiagonalSize Of The Screen (Must In Integer):");
                userDiagonalSize = Console.ReadLine();
            } while (!int.TryParse(userDiagonalSize, out screenDiagonalSize) || (screenDiagonalSize <= 0));

            Console.WriteLine("\n");
            Console.WriteLine("------------Answer----------");
            Console.WriteLine("\n");

            // Function Call

            PixelCalc.DiagonalSize(screenWidth, screenHeight);
            PixelCalc.PPI();
            PixelCalc.DotPitch(screenDiagonalSize);

        }

    
    }
}
