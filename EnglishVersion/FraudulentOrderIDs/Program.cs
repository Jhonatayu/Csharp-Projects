string[] orderIDs = ["B132", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
Console.WriteLine("");

foreach (string orderID in orderIDs){
    if (orderID.StartsWith("B")){
        Console.WriteLine(orderID);
    }
}