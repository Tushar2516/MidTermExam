using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExam
{
    public static class PixelCalc
    {
        // Private variables declare

        private static double diagonal;
        private static double ppi;
        private static double dotPitch;
        
        // PPI...

        public static void PPI()
        {
            ppi = diagonal / 10;
            Console.WriteLine("PPI Is:- {0}", ppi);
        }

        // DaigonalSize...
        public static void DiagonalSize(int width, int height)
        {
            diagonal = Math.Sqrt((width * width) + (height * height));

            Console.WriteLine("Diaogonal In Pixel Is:- {0}", diagonal);
        }

        // DotPitch...
        public static void DotPitch(int diagonalSize)
        {
            dotPitch = (diagonalSize / diagonal) * (25.4);
            Console.WriteLine("DotPitch Is:- {0}", dotPitch);
        }
    }
}
