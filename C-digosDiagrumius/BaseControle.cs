using System.Diagnostics.CodeAnalysis;

namespace Diagamas;

public class BaseControle{

    public virtual void Criar(Objeto o)
    {

    }

    public virtual void Analizar(Objeto o)
    {

    }

    public virtual Objeto Ler(Int64 Id)
    {
        return null;
    }

    public virtual void Apagar(Int64 Id)
    {
        
    }
}