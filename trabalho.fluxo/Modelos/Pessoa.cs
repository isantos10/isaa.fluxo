namespace Modelos;
public class Pessoa
{
 string Nome;
 string Endereço;
 string telefone;
 int id;

public string GetNome ()
    {
        return Nome;
    }
    public void SetNome (string n)
    {
        Nome=n;
    }
    public string GetEndereço ()
    {
        return Endereço;
    }
    public void SetEndereço (string e)
    {
        Endereço=e;
    }
    public string Gettelefone ()
    {
        return telefone;
    }
    public void Settelefone (string t)
    {
        telefone=t;
    }
    public int GetId ()
    {
        return id;
    }
    public void SetID (int i)
    {
        id=i;
    }

}




 