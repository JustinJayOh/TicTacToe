# TicTacToe
2 Player TicTacToe Game

@author Justin Oh
@email jjoh1993@gmail.com
@version 2/17/2019

2 Players take turns placing X and O pieces on a 3x3 2D grid. Players continue
to take turns and place pieces until a player has 3 pieces connected in a row, column, or
diagonally. A new game can be started by pressing the "New Game" button.

Form1.cs class driven by Grid and Player class.
Instead of implementing the tictactoe map with a 2D array, I used a magic square
of integers to mark each space in the square.
For more information: https://en.wikipedia.org/wiki/Magic_square

The grid class is a static class and has a list of magic square integers as its field, and provides
methods to check if the grid contains a piece, to remove a piece,
and reset the grid/map.

The player class has a list of pieces, or magic square integers as its field,
and provides methods to set a piece, check for a win, and clear pieces.
Once a player sets a piece, it is removed from the static list field from the grid class
and added to the player object's list of pieces.
