// Consiste num programa simples onde o se tem um assinatura, e dependendo dos dias que irá expirar a mesma, o console mostra uma mensagem diferente.

Random random = new Random();
int diasAteExpirar = random.Next(12);
int porcentagemDeDesconto = 0;

if (diasAteExpirar <= 10){

    if ((diasAteExpirar <= 5) && (diasAteExpirar > 1)){

        porcentagemDeDesconto = 10;
        Console.WriteLine($"\nSua Assinatura expira em {diasAteExpirar} dias.\nRenove agora e receba {porcentagemDeDesconto}% de desconto!");

    } else if (diasAteExpirar == 1){

        porcentagemDeDesconto = 20;
        Console.WriteLine($"\nSua Assinatura expira em um dia! \nRenove agora e receba {porcentagemDeDesconto}% de desconto!");

    } else if (diasAteExpirar == 0){

        Console.WriteLine("\nSua Assinatura expirou.");
    }else {

        Console.WriteLine("\nSua Assinatura irá se expirar em breve. Renove agora!");
    }
}
