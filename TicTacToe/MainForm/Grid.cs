/** 
* @author Justin Oh
* @email jjoh1993@gmail.com
* @version 2/17/2019
*
* Grid class to hold all pieces remaining on grid.
*/

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
        
        /**
        * Removes piece from grid.
        * 
        * @param int x for magic square number corresponding to grid space.
        */
        public static void RemovePiece(int x)
        {
            if (ContainsPiece(x))
            {
                piece.Remove(x);
            }
        }
        
        /**
        * Returns true if grid contains piece.
        *
        * @param int x for magic sqaure number corresponding to grid space.
        * @return true if grid contains piece.
        */
        public static Boolean ContainsPiece(int x)
        {
            if (piece.Contains(x))
            {
                return true;
            }
            return false;
        }
        
        /**
        * Resets all pieces on grid.
        *
        */
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
