namespace Modelos;

public class Produto : Pessoa
{
    string codigo;
    string estoque;

    public string Getcodigo ()
    {
        return codigo;
    }
    public void Setcodigo (string cod)
    {
        codigo=cod;
    }

     public string Getestoque ()
    {
        return estoque;
    }
    public void Setestoque (string est)
    {
        estoque=est;
    }
    
}