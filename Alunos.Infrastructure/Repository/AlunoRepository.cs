using Alunos.Core.Interface.Repository;
using Alunos.Core.Models;
using Alunos.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alunos.Infrastructure.Repository
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(UniversidadeContext db) : base(db)
        {

        }
    }
}
