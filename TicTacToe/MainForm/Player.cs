/**
* @author Justin Oh
* @email jjoh1993@gmail.com
* @version 2/17/2019
*
* Defines a player object with game pieces as a field. 
* Provides methods to set a piece, check for a win, and clear pieces from grid.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Player
    {

        // Fields
        public List<int> pieces = new List<int>();

        /** 
         * Method called when a piece is placed on the MainForm. 
         * Places a player's piece on that grid location.
         * 
         * @param int x for magic square number
         * @return Boolean if piece was successfully added.
         * */
        public Boolean SetPiece(int x)
        {
            if (!Grid.ContainsPiece(x))
            {
                return false;
            }
            Grid.RemovePiece(x);
            pieces.Add(x);
            return true;
        }

        /**
         * Checks if player wins.
         * Magic square ints sum to 15.
         * 
         * @return Boolean if player won
         * */
         public Boolean CheckWin()
        {
            pieces.Sort();
            for (int i = 0; i < pieces.Count - 2; i++)
            {
                int l = i + 1;
                int r = pieces.Count - 1;
                while (l < r)
                {
                    if (pieces[i] + pieces[l] + pieces[r] == 15)
                    {
                        return true;
                    }
                    else if (pieces[i] + pieces[l] + pieces[r] < 15)
                    {
                        l++;
                    }
                    else
                    {
                        r--;
                    }
                }
            }
            return false;
        }

        /** 
         * Clears players pieces and restores map pieces.
         * 
         * */
         public void ClearPieces()
        {
            pieces.Clear();
            Grid.ResetPiece();
        }


    }
}
