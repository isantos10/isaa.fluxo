using LiteDB;

namespace Modelos;
public class Pessoa : Registro
{
  public string Nome { get; set; }
  public string Endereço { get; set; }
  public string CPF { get; set; }
  public string Email { get; set; }
  [BsonId]
  public int Id { get; set; }

}




