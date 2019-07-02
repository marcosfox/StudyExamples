using Alunos.Core.Interface.Repository;
using Alunos.Core.Models;
using Alunos.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alunos.Infrastructure.Repository
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        private UniversidadeContext _db;

        public AlunoRepository(UniversidadeContext db) : base(db)
        {
            _db = db;
        }

        public IQueryable<Aluno> getByIdOrName(Aluno objAlunoFilter)
        {
            return ((IQueryable<Aluno>)_db.Set<Aluno>()).Where(x => 
            (x.NomAluno.Contains(objAlunoFilter.NomAluno) || objAlunoFilter.NomAluno == null) ||
            (x.NumSeqAluno == objAlunoFilter.NumSeqAluno || objAlunoFilter.NumSeqAluno == 0));
        }
    }
}
