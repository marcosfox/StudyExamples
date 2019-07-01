using System;
using System.Collections.Generic;

namespace Alunos.Core.Models
{
    public partial class Aluno
    {
        public int NumSeqAluno { get; set; }
        public string NomAluno { get; set; }
        public string NomAbreviado { get; set; }
        public string EndEmail { get; set; }
        public string NomPai { get; set; }
        public string NomMae { get; set; }
        public string IndSexo { get; set; }
        public int? IndEstadoCivil { get; set; }
        public DateTime? DtNascimento { get; set; }
        public int? CodPais { get; set; }
        public int? CodMunicipioNatural { get; set; }
        public string CpfAluno { get; set; }
        public string NumTelefCelular { get; set; }
        public string NumTelefone { get; set; }
        public string NumIdentidade { get; set; }
        public string SglUfIdent { get; set; }
        public string SglOrgaoEmissor { get; set; }
        public DateTime? DtEmissaoIdent { get; set; }
        public string NumTituloEleitor { get; set; }
        public string SglUfTitulo { get; set; }
        public string NumZonaTitulo { get; set; }
        public string NumSecaoTitulo { get; set; }
        public string NumCertifMilitar { get; set; }
        public string SglUfCertifMilitar { get; set; }
        public string SglEmissorCertifMilitar { get; set; }
        public string NumSenhaCartao { get; set; }
        public DateTime? DtInsercao { get; set; }
        public DateTime? DtValidadeCartao { get; set; }
        public string IndPossuiDeficiencia { get; set; }
        public DateTime? DtLimiteDeficiencia { get; set; }
        public string IndInadimplente { get; set; }
        public string TxtCidadeNaturalSca { get; set; }
        public string CodUsuarioLog { get; set; }
        public DateTime? DtAtualizaLog { get; set; }
        public string TxtIpLog { get; set; }
        public string TxtIdPassaporte { get; set; }
        public string EndEmailEstacio { get; set; }
        public string TxtSenhaEmailEstacio { get; set; }
        public int? IdInstituicaoMig { get; set; }
        public string EndEmailLyceum { get; set; }
        public string NumIdentidadeAnt { get; set; }
        public string NumPassaporte { get; set; }
        public int? NumIdAlunoInep { get; set; }
        public string IndCorRaca { get; set; }
        public string Profissao { get; set; }
        public DateTime? DtAtCadastral { get; set; }
        public string NomSocial { get; set; }
        public DateTime? DtConfirmaEmail { get; set; }
    }
}
