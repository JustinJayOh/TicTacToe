using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public static class Grid
    {

        //Fields
        static List<int> piece = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

        // Methods
        public static void RemovePiece(int x)
        {
            if (ContainsPiece(x))
            {
                piece.Remove(x);
            }
        }

        public static Boolean ContainsPiece(int x)
        {
            if (piece.Contains(x))
            {
                return true;
            }
            return false;
        }

        public static void ResetPiece()
        {
            piece.Clear();
            for (int i = 1; i < 10; i++)
            {
                piece.Add(i);
            }
        }

        
    }
}
