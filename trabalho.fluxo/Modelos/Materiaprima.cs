namespace Modelos;

public class Materiaprima 
{
    string nome;
    string telefone;
    string endereço;
    string quantidade;
    int ID;

    public string GetNome ()
    {
        return nome;
    }
    public void SetNome (string n)
    {
        nome=n;
    }

    public string Gettelefone ()
    {
        return nome;
    }
    public void Settelefone (string t)
    {
        telefone=t;
    }

    public string Getendereço ()
    {
        return endereço;
    }
    public void Setendereço (string e)
    {
        endereço=e;
    }

    public string Getquantidade ()
    {
        return quantidade;
    }
    public void Setquantidade (string qua)
    {
        quantidade=qua;
    }

    public int GetID()
    {
        return ID;
    }
    public void SetID (int i)
    {
        ID=i;
    }
}