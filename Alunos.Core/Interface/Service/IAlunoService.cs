
using Alunos.Core.Models;
using System.Linq;

namespace Alunos.Core.Interface.Service
{
    public interface IAlunoService
    {
        IQueryable<Aluno> getAll();
    }
}
