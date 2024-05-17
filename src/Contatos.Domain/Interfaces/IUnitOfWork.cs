using System.Threading.Tasks;

namespace Contatos.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        //essa interface vai ser usada para efetivar a persistência, dando um SaveCHanges
        Task Commit();
    }
}