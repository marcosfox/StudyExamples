using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.API.ViewModel
{
    public class GetResponseVM
    {
        public List<GetResponseAlunosVM> Alunos { get; set; }
        public string ErroMensagem { get; set; }

        public GetResponseVM()
        {
            Alunos = new List<GetResponseAlunosVM>();
        }
    }
    public class GetResponseAlunosVM
    {
        public int idAluno { get; set; }
        public string NomeAluno { get; set; }
        public string CPF { get; set; }
        public bool  Ativo { get; set; }
    }
}
