public class CartaoDebito
{
    public CartaoDebito()
    {
        Bandeira = BandeiraCartao.Visa;
    }
    public string Numero { get; set; }
    //public string Bandeira { get; set; }
    public BandeiraCartao Bandeira { get; set; } // o tipo de dado é "BandeiraCartao" porque o usário pode digitar qualquer coisa diferente do necessario
    public DateTime Vencimento { get; set; }
    public string Portador { get; set; }
    public string Cvv { get; set; }
}

public enum BandeiraCartao // "enum" uma lista que o usuário pode usar
{
    Visa,
    Mastercard,
    Amex,
    Elo
}