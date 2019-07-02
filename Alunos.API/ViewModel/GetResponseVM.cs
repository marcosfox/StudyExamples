using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alunos.API.ViewModel
{
    public class GetResponseVM
    {
        public List<AlunoResponseVM> Alunos { get; set; }
        public string ErroMensagem { get; set; }

        public GetResponseVM()
        {
            Alunos = new List<AlunoResponseVM>();
        }
    }
}
