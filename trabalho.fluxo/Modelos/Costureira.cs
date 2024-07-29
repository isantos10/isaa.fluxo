namespace Modelos;
public class Costureira : Pessoa
{
    string CPF;
    string CNPJ;

    public string GetCPF ()
    {
        return CPF;
    }
    public void SetCPF (string cnpj)
    {
        CNPJ=cnpj;
    }
    
}