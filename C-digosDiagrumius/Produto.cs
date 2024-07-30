namespace CdigosDiagrumius;

public class Produto{
        Int64 Id;
        String produto;
        String Preco;
    
    public Produto()
    {
        
    }

    private void SetId(Int64 i)
    {
        Id = i;
    }

    public Int64 GetId()
    {
        return Id;
    }

    private void SetProduto(String pt)
    {
        produto = pt;
    }

    public string GetProduto()
    {
        return produto;
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