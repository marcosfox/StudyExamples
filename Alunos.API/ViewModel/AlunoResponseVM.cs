using System;
using System.Collections.Generic;
using System.Text;

namespace Alunos.API.ViewModel
{
    public class AlunoResponseVM
    {
        public int idAluno { get; set; }
        public string NomeAluno { get; set; }
        public string CPF { get; set; }
        public bool Ativo { get; set; }
    }
}
