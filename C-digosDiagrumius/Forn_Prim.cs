namespace CdigosDiagrumius;

public class Forn_Prim{
    Int64 Id;
    String Fornecedor;
    String MateriaPrima;
     String Preco;
    public Forn_Prim()
    {
        
    }

    private void SetId1(Int64 i)
    {
        Id = i;
    }

    public Int64 GetId1()
    {
        return Id;
    }

    private void SetFornecedor(String f)
    {
        Fornecedor = f;
    }

    public string GetFornecedor()
    {
        return Fornecedor;
    }

    private void SetMateriaPrima(String mp)
    {
        MateriaPrima = mp;
    }

    public string GetMateriaPrima()
    {
        return MateriaPrima;
    }


    private void SetPreco(String p)
    {
        Preco = p;
    }

    public string GetPreco()
    {
        return Preco;
    }
}