namespace Modelos;
public class Vendas 
{
    string produto;
    string quantidade;
    string lucro;
    string cliente;
    string id;
    


    public string Getproduto ()
    {
        return produto;
    }
    public void Setproduto (string pr)
    {
        produto=pr;
    }

   

    public string Getquantidade ()
    {
        return quantidade;
    }
    public void Setquantidade (string qu)
    {
        quantidade=qu;
    }

   

    public string Getlucro ()
    {
        return lucro;
    }
    public void Setlucro (string lu)
    {
        lucro=lu;
    }

    

    public string Getcliente ()
    {
        return cliente;
    }
    public void Setcliente(string cl)
    {
        cliente=cl;
    }

    

    public string Getid ()
    {
        return id;
    }
    public void Setid (string i)
    {
        id=i;
    }

}