using Alunos.Core.Interface.Repository;
using Alunos.Core.Interface.Service;
using Alunos.Core.Models;
using Alunos.Infrastructure.EF;
using Alunos.Infrastructure.Repository;
using System;
using System.Linq;

namespace Alunos.Service
{
    public class AlunoService : IAlunoService
    {
        private IAlunoRepository _alunoRepository;

        public AlunoService(UniversidadeContext db)
        {
            _alunoRepository = new AlunoRepository(db);
        }

        public IQueryable<Aluno> getAll()
        {
            return _alunoRepository.GetAll();
        }

        public IQueryable<Aluno> getByIdOrName(Aluno objAluno){
            return _alunoRepository.getByIdOrName(objAluno);
        }
    }
}
