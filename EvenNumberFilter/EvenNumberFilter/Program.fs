module Program

let listOfNumbers = [ 994; 551; 386; 79; 850; 155; 466; 953; 903; 17; 930; 344; 805; 898; 744 ]

type overallGoal = int list -> unit

type user =
  {
    UserName : string
    Password : string
  }

type userThatHasBeenLogged = user

type loggingInFunctionSig = user -> userThatHasBeenLogged -> user


let functiontest number number2 = ()


listOfNumbers
|> List.filter (fun number -> (number % 2) = 0)
|> List.iter (fun number -> printfn "%i" number)