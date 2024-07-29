namespace Modelos;

public class Cliente : Pessoa
{
    string CPF;

    public string GetCPF ()
    {
        return CPF;
    }
    public void SetCPF (string cpf)
    {
        CPF=cpf;
    }
    
}