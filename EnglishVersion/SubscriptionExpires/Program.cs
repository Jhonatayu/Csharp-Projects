Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10){

    if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1)){

        discountPercentage = 10;
        Console.WriteLine($"\nYour subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");

    } else if (daysUntilExpiration == 1){

        discountPercentage = 20;
        Console.WriteLine($"\nYour subscription expires within a day! \nRenew now and save {discountPercentage}%!");

    } else if (daysUntilExpiration == 0){

        Console.WriteLine("\nYour subscription has expired.");
    }else {

        Console.WriteLine("\nYour subscription will expire soon. Renew now!");
    }
}
