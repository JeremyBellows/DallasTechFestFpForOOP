module MockDAL

  let getUsers () =
    """
      {         "Users" : [                     { "UserId" : 42, "Name" : "Jeremy", "FavoriteDeliItem" : "Relative" },                     { "UserId" : 9001, "Name" : "Shawn", "FavoriteDeliItem" : "Groovy Smoothie" },                     { "UserId" : 56, "Name" : "Brad", "FavoriteDeliItem" : "Deluxe Nomitizer" },                     { "UserId" : 776, "Name" : "Mira", "FavoriteDeliItem" : "Pop" },                     { "UserId" : 57, "Name" : "Natalya", "FavoriteDeliItem" : "Ham Sandwich" },                     { "UserId" : 88, "Name" : "Takar", "FavoriteDeliItem" : "PB&J" },                     { "UserId" : 92, "Name" : "Vralai", "FavoriteDeliItem" : "Nothing" }                                       ]       }
    """