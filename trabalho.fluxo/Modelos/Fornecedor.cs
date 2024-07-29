namespace Modelos;

public class Fornecedor : Pessoa
{
    string CNPJ;
    string email;

    public string GetCNPJ ()
    {
        return CNPJ;
    }
    public void SetCNPJ (string cnpj)
    {
       CNPJ=cnpj;
    }

     public string Getemail ()
    {
        return email;
    }
    public void Setemail (string e)
    {
       email=e;
    }
    
}