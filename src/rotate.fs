// Part of the module "rotate".
module rotate

type Board = list<char>
type Position = int


// Create a board of size n
let create (n:uint) : Board =
    if n>1u && n<=5u then
        (List.init (int(n)*int(n)) (fun i -> char (97 + i)))
    else []


// Convert a given board b into a string
let  board2Str (b:Board) : string =
    let n = int (sqrt(float(b.Length)))
    List.fold (fun acc elm -> 
        acc + string(elm) +
            if ((acc.Length / 2) + 1) % n = 0 then
                "\n"   
            else    
                " "  
            ) "" b


// Check if a rotation is valid
let validRotation (b:Board) (p:Position) : bool =
    let n = int (sqrt(float(b.Length)))
    if p % n = 0 || p < 0 || p > (b.Length - n) then 
        false
    else   
        true


// Rotate a set of elements on the board
let rotate (b:Board) (p:Position) : Board =
    //let p1, p2, p3, p4 = p, p+1, p+int(n)+1, p+int(n)
    let n = int (sqrt(float(b.Length)))
    if validRotation(b)(p) then
        List.init b.Length (
            fun i ->
            if i = p - 1 then
                b.[(p - 1) + n]
            else if i = p then
                b.[p - 1]
            else if i = (p - 1) + n then
                b.[p + n]
            else if i = p + n then
                b.[p]
            else
                b.[i]
            )
    else
        b


// Scramble the board
let rec scramble (b:Board) (m:uint) : Board =
    let n = int (sqrt(float(b.Length)))
    if m > 0u then
        let rand = System.Random()
        let p = rand.Next (1, b.Length - n)
        if validRotation b p then
            let b2 = rotate b p
            scramble b2 (m - 1u)
        else
            scramble b (m)
    else b


// Check if board is solved
let solved (b:Board) : bool =
    let n = int (sqrt(float(b.Length)))
    b = create(uint n)
