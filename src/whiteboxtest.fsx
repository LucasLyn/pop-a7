//
module rotate

type Board = list<char>
type Position = int

let Board = (rotate.create 4u)

// Begin white-box test rotate library functions;
printfn ""
printfn ""
printfn ""
printfn "White-box test;"
printfn "Unit        | Branch | Condition      | Input | Expected output"
printfn "_______________________________________________________________"
printfn "Create      | 1      | n>1u && n<=5u  |       |                "
printfn "            | 1a     | True           | 4u    | 4x4 Board      "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" Board
            (Board = ['a'; 'b'; 'c'; 'd'; 'e'; 'f'; 'g'; 'h'; 'i';
            'j'; 'k'; 'l'; 'm'; 'n'; 'o'; 'p'])

printfn ""
printfn "_______________________________________________________________"
printfn "            | 1b     | False          |  6u  | []              "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (rotate.create 6u)
            ((rotate.create 6u) = [])



printfn ""
printfn "_______________________________________________________________"
printfn "Board2Str   | 2      | (acc.Length/2)+1 mod 0 |      |         "
printfn "            | 2a     | True           | 2u  | 'a b \nc d'      "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (rotate.board2Str
            (rotate.create 2u)) (rotate.board2Str
            (rotate.create 2u) = "a b\nc d\n")

printfn ""
printfn "_______________________________________________________________"
printfn "            | 2b     | False          |      | End newlining   "
printfn "_______________________________________________________________"



printfn ""
printfn "_______________________________________________________________"
printfn "validRotation | 3      | p mod = 0        |      |             "
printfn "              | 3a     | True           |p = 0 & n = 2u | False"
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (rotate.validRotation
            (rotate.create 2u) 0) ((rotate.validRotation
            (rotate.create 2u) 0) = false)

printfn ""
printfn "_______________________________________________________________"
printfn "            | 3b       | False          |p = 1 & n = 2u | True "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (rotate.validRotation
            (rotate.create 2u) 1) ((rotate.validRotation
            (rotate.create 2u) 1) = true)



printfn ""
printfn ""
printfn "_______________________________________________________________"
printfn "rotate      | 4      |rotate Board p = Board |       |         "
printfn "            | 4a     | True             | b=4u & p=5 | True    "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (rotate.rotate Board 5)
            ((rotate.rotate Board 5) = (rotate.rotate Board 5))

printfn ""
printfn "_______________________________________________________________"
printfn "            | 4b     | False            |b=4u & p=4 | False    "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (rotate.rotate Board 4)
            ((rotate.rotate Board 4) <> (rotate.rotate Board 5))


printfn ""
printfn "" // BEGIN HERE
printfn "_______________________________________________________________"
printfn "scramble    | 5      | m > 0u           |            |         "
printfn "            | 5a     | True             | m = 1u     | True    "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (rotate.scramble Board 1u)
            (((rotate.scramble Board 1u) = Board) = false) 

printfn ""
printfn "_______________________________________________________________"
printfn "            | 5b     | False            | m = 0u    | False    "
printfn "_______________________________________________________________"
printfn "Actual output: %A | Condition met? %A" (rotate.scramble Board 0u)
            ((rotate.scramble Board 0u) = Board) 


printfn ""
printfn ""
printfn "rotate.solved does not have any branches, and thus we can't run a test"