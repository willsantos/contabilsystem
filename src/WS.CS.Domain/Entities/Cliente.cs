namespace WS.CS.Domain;

public class Cliente
{
  public Guid IdCliente { get; private set; }
  public int Codigo { get; private set; }
  public string NomeFantasia { get; private set; } = string.Empty;
  public DateTime CriadoEm { get; private set; }
  public DateTime? AlteradoEm { get; private set; }
  public DateTime? ApagadoEm { get; private set; }
  //lista de enderecos
  //Lista de contatos

  protected Cliente(int codigo, string nomeFansia)
  {
    IdCliente = Guid.NewGuid();
    Codigo = codigo;
    NomeFantasia = nomeFansia;
    CriadoEm = DateTime.UtcNow;
  }

}
