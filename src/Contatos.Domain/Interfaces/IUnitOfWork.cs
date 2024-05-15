using System;
using System.Threading.Tasks;

namespace Contatos.Domain.Interfaces
{
    public interface IUnitOFWork
    {
        //essa interface vai ser usada para efetivar a persistência, dando um SaveCHanges
        Task Commit();
    }
}