using Alunos.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alunos.Core.Interface.Repository
{
    public interface IAlunoRepository : IBaseRepository<Aluno>
    {
        IQueryable<Aluno> getByIdOrName(Aluno objAlunoFilter);
    }
}
