module Solution

let listOfNumbers = [ 994; 551; 386; 79; 850; 155; 466; 953; 903; 17; 930; 344; 805; 898; 744 ]    

let printNumber number =
  printfn "%i" number

listOfNumbers 
|> List.filter (fun number -> number % 2 = 0)
|> List.iter printNumber