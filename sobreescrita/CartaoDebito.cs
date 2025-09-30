public class CartaoDebito : Cartao
{
    public override void Debitar(decimal valor)
    {
        Console.WriteLine($"Compra {valor:c} realizada no cartão de débito.");
    }
}