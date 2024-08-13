using LiteDB;

namespace Modelos;

public class Materiaprima 
{
    string nome { get; set; }
    string telefone { get; set; }
    string endereço { get; set; }
    string quantidade { get; set; }
    
    [BsonId]
    int ID { get; set; }

}