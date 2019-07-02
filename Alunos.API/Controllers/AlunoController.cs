using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alunos.API.ViewModel;
using Alunos.Core.Interface.Service;
using Alunos.Core.Models;
using Alunos.Infrastructure.EF;
using Alunos.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alunos.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private IAlunoService _alunoService;

        public AlunoController(UniversidadeContext db)
        {
            _alunoService = new AlunoService(db);
        }

        [HttpGet]
        public GetResponseVM Get()
        {
            GetResponseVM vm = new GetResponseVM();

            try
            {
                vm = convertToVM(_alunoService.getAll());
            }
            catch (Exception ex)
            {
                vm.ErroMensagem = ex.Message;
            }

            return vm;
        }
        [HttpPut]
        public GetResponseVM Put([FromBody] FilterAlunoVM vmAluno)
        {
            GetResponseVM vm = new GetResponseVM();

            try
            {
                vm = convertToVM(_alunoService.getByIdOrName(convertVMToModel(vmAluno)));
            }
            catch (Exception ex)
            {
                vm.ErroMensagem = ex.Message;
            }

            return vm;
        }

        #region methods
        private GetResponseVM convertToVM(IQueryable<Aluno> alunos)
        {
            GetResponseVM vm = new GetResponseVM();

            try
            {
                foreach (var aluno in alunos)
                    vm.Alunos.Add(new AlunoResponseVM
                    {
                        idAluno = aluno.NumSeqAluno,
                        NomeAluno = aluno.NomAbreviado,
                        CPF = aluno.CpfAluno,
                        Ativo = aluno.DtAtCadastral > DateTime.Now.AddMonths(-6)
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return vm;
        }
        private Aluno convertVMToModel(FilterAlunoVM vmAluno)
        {
            GetResponseVM vm = new GetResponseVM();

            try
            {
                    return new Aluno
                    {
                        NumSeqAluno = vmAluno.Id,
                        NomAluno = vmAluno.Nome
                    };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion methods

    }
}