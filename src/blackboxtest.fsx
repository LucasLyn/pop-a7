// Part of the module "rotate".
module rotate

// Define types
type Board = list<char>
type Position = int

// Difine placeholder values to x and lst
let b = rotate.create 3u


let compareString (s1:string) (s2:string) : bool =
    (s1.Equals(s2))


// Black-box test of rotate module functions.
// Begin create test;
printfn "Black-box test;"
printfn "Case | Exp. Output"
printfn "__________________"
printfn "n = %A | A 5x5 char matrix ([a, ..., y])" 5u
printfn "Output: | rotate.create: %A" (rotate.create 5u)
printfn "Exp. Output return: %A" ((rotate.create 5u).Length = 25)
printfn ""


printfn "n = %A | A 2x2 char matrix [a, b, c, d]" 2u
printfn "Output: | rotate.create: %A" (rotate.create 2u)
printfn "Exp. Output return: %A" ((rotate.create 2u).Length = 4)
printfn ""


printfn "n = %A | []" 1u
printfn "Output: | rotate.create: %A" (rotate.create 1u)
printfn "Exp. Output return: %A" ((rotate.create 1u).Length = 0)
printfn ""


printfn "n = %A | []" 0u
printfn "Output: | rotate.create: %A" (rotate.create 0u)
printfn "Exp. Output return: %A" ((rotate.create 0u).Length = 0)
printfn ""


printfn "n = %A | []" 10u
printfn "Output: | rotate.create: %A" (rotate.create 10u)
printfn "Exp. Output return: %A" ((rotate.create 10u).Length = 0)
printfn ""

printfn ""
printfn ""
printfn ""


// Begin board2Str test;
printfn "Case | Exp. Output"
printfn "__________________"
printfn "n = %A | 'a, b, c, d'" 2u
printfn "Output: | rotate.board2Str: %A" (rotate.board2Str (rotate.create 2u))
printfn "Exp. Output return: %A" (compareString (rotate.board2Str
            (rotate.create 2u)) "a b\nc d\n")
printfn ""


printfn "n = %A | ''" 1u
printfn "Output: | rotate.board2Str: %A" (rotate.board2Str (rotate.create 1u))
printfn "Exp. Output return: %A" (compareString (rotate.board2Str
            (rotate.create 1u)) "")
printfn ""


printfn "n = %A | ''" 0u
printfn "Output: | rotate.board2Str: %A" (rotate.board2Str (rotate.create 0u))
printfn "Exp. Output return: %A" (compareString (rotate.board2Str
            (rotate.create 0u)) "")
printfn ""


printfn "n = %A | ''" 10u
printfn "Output: | rotate.board2Str: %A" (rotate.board2Str (rotate.create 10u))
printfn "Exp. Output return: %A" (compareString (rotate.board2Str
            (rotate.create 10u)) "")
printfn ""

printfn ""
printfn ""
printfn ""


// Begin validRotation test;
printfn "Case | Exp. Output"
printfn "__________________"
printfn "p = %A & n = %A | true" 2 3u
printfn "Output: | rotate.validRotation: %A" (rotate.validRotation b 2)
printfn "Exp. Output return: %A" ((rotate.validRotation b 2) = true)
printfn ""


printfn "p = %A & n = %A | false" 3 3u
printfn "Output: | rotate.validRotation: %A" (rotate.validRotation b 3)
printfn "Exp. Output return: %A" ((rotate.validRotation b 3) = false)
printfn ""


printfn "p = %A & n = %A | false" -1 3u
printfn "Output: | rotate.validRotation: %A" (rotate.validRotation b -1)
printfn "Exp. Output return: %A" ((rotate.validRotation b -1) = false)
printfn ""

printfn ""
printfn ""
printfn ""


// Begin rotate test;
printfn "Case | Exp. Output"
printfn "__________________"
printfn "p = %A & n = %A | 'a, b, c, d, e, f, g, h, i'" 0 3u
printfn "Output: | rotate.rotate: %A" (rotate.board2Str (rotate.rotate b 0))
printfn "Exp. Output return: %A" (compareString (rotate.board2Str
            (rotate.rotate b 4)) "a b c\nd e f\ng h i\n")
printfn ""


printfn "p = %A & n = %A | 'a b c d h e g i f'" 4 3u
printfn "Output: | rotate.rotate: %A" (rotate.board2Str (rotate.rotate b 4))
printfn "Exp. Output return: %A" (compareString (rotate.board2Str
            (rotate.rotate b 4))"a b c\nd h e\ng i f\n")
printfn ""

printfn ""
printfn ""
printfn ""


// Begin scramble test;
printfn "Case | Exp. Output"
printfn "__________________"
printfn "m = %A | Not 'a, b, c, d, e, f, g, h, i'" 1u
printfn "Output: | rotate.scramble: %A" (rotate.scramble b 1u)
printfn "Exp. Output return: %A" ((compareString (rotate.board2Str
            (rotate.scramble b 1u)) "a b c \nd e f \ng h i \n") = false)
printfn ""


printfn "m = %A & n = %A| Not 'a, b, c, d, e, f, g, h, i'" 2u 3u
printfn "Output: | rotate.scramble: %A" (rotate.scramble b 2u)
printfn "Exp. Output return: %A" ((compareString (rotate.board2Str
            (rotate.scramble b 2u)) "a b c \nd e f \ng h i \n") = false) 
printfn ""


printfn "m = %A & n = %A | 'a, b, c, d, e, f, g, h, i'" 0u 3u
printfn "Output: | rotate.scramble: %A" (rotate.scramble b 0u)
printfn "Exp. Output return: %A" (compareString (rotate.board2Str
            (rotate.scramble b 0u)) "a b c\nd e f\ng h i\n")
printfn ""


printfn "m = %A & n = %A | Not 'a, b, c, d, e, f, g, h, i'" 10u 3u
printfn "Output: | rotate.scramble: %A" (rotate.scramble b 10u)
printfn "Exp. Output return: %A" ((compareString (rotate.board2Str
            (rotate.scramble b 10u)) "a b c \nd e f \ng h i \n") = false)
printfn ""

printfn ""
printfn ""
printfn ""


// Begin solved test;
printfn "Case | Exp. Output"
printfn "__________________"
printfn "m = None | true" 
printfn "Output: | rotate.solved: %A" (rotate.solved b)
printfn "Exp. Output return: %A" ((rotate.solved b) = true)
printfn ""


printfn "m = %A | true" 0u
printfn "Output: | rotate.solved: %A" (rotate.solved (rotate.scramble b 0u))
printfn "Exp. Output return: %A" ((rotate.solved (rotate.scramble b 0u)) =
            true)
printfn ""


printfn "m = %A | false" 1u
printfn "Output: | rotate.solved: %A" (rotate.solved (rotate.scramble b 1u))
printfn "Exp. Output return: %A" ((rotate.solved (rotate.scramble b 1u)) =
            false)
printfn ""


printfn "m = %A | false" 10u
printfn "Output: | rotate.solved: %A" (rotate.solved (rotate.scramble b 10u))
printfn "Exp. Output return: %A" ((rotate.solved (rotate.scramble b 1u)) =
            false)
printfn ""
