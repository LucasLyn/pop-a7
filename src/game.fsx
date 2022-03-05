// Part of the module "rotate".
module rotate

// Define types.
type Board = list<char>
type Position = int

printfn "Solve this board by writing a number corresponding to a 2x2 square\n
(upper-left corner) and pressing enter. Once the board is in\n
alphabetical order, you win!\n \n
Good luck!\n\n"

// Game that let's players rotate squares of 2x2 characters
let rec game (b:Board) =
    printfn "%A" (rotate.board2Str(b))
    if rotate.solved(b) then printfn "Congrats! You won!"
    else
        let input = System.Console.ReadLine()
        if rotate.validRotation(b) (int(input)) then
            game(rotate.rotate(b)(int(input)))
        else
            printfn "Sorry, invalid rotation. Please try again."
            game(b)
let rand = System.Random()
game(rotate.scramble(rotate.create(uint(System.Random().Next(2, 5)
            )))(uint(rand.Next(1, 500))))
