namespace CdigosDiagrumius;

public class Funcionario{
        Int64 Id;
        String Nome;
        String Email;
        String Senha;
    public Funcionario()
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

    private void SetNome(String n)
    {
        Nome = n;
    }

    public string GetNome()
    {
        return Nome;
    }

    private void SetEmail(String e)
    {
        Email = e;
    }

    public string GetEmail()
    {
        return Email;
    }


    private void SetSenha(String s)
    {
        Senha = s;
    }

    public string GetSenha()
    {
        return Senha;
    }
}