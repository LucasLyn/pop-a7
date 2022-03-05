// Part of the module "rotate".
module rotate


// Define a type "Board" as a char list.
type Board = list<char>


// Define a type "Position" as an int.
type Position = int



///<summary>Creates an n*n matrix as a board</summary>
///<param name = "n">Size of board to be created</param>
///<returns>A board with side length n</returns>
val create : n:uint -> Board


///<summary>Converts a board to string</summary>
///<param name = "b">A board to convert</param>
///<returns>A string converted from a board</returns>
val board2Str : b:Board -> string


///<summary>Checks of a rotation is valid</summary>
///<param name = "b">A board to check within</param>
///<param name = "p">A position on the board to rotate from</param>
///<returns>A bool for whether or not the attempted rotation is valid</returns>
val validRotation : b:Board -> p:Position -> bool


///<summary>Rotates from the given position</summary>
///<param name = "b">A board to check within</param>
///<param name = "p">A position on the board to rotate from</param>
///<returns>A new board after the block rotation</returns>
val rotate : b:Board -> p:Position -> Board


///<summary>Scrambles a board</summary>
///<param name = "b">A board to scramble</param>
///<param name = "m">Random legal rotations when scrambling</param>
///<returns>A scrambled board</returns>
val scramble : b:Board -> m:uint -> Board


///<summary>Checks if a board is solved</summary>
///<param name = "b">A board to check</param>
///<returns>A bool corresponding to if the board is solved</returns>
val solved : b:Board -> bool