﻿module Program
(*
For some reason, Deli’s love using excel sheets! They want us to consume json sent by their undocumented api and convert the data into a csv file.
- Consumes json from a mocked endpoint
- Prints all fields of each item in a csv format

Sample Json
{
  "Users" : [
    { "UserId" : "42", "Name" : "Jeremy", "FavoriteDeliItem" : "Relative" }
  ]
}
*)
open FSharp.Data

type usersFromApi = JsonProvider<"""
  {
  "Users" : [
    { "UserId" : "42", "Name" : "Jeremy", "FavoriteDeliItem" : "Relative" }
  ]
}"""
>

let printHeader () =
  printfn "UserId,Name,FavoriteDeliItem"

let printUserToConsole (user : usersFromApi.User) =
  printfn "%i,%s,%s" user.UserId user.Name user.FavoriteDeliItem

let data = MockDAL.getUsers ()
let parsedData = data |> usersFromApi.Parse

printHeader()

parsedData.Users
|> Array.sortBy (fun user -> user.UserId)
|> Array.iter printUserToConsole


