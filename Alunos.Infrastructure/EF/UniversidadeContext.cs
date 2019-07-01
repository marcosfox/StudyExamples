using System;
using Alunos.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Alunos.Infrastructure.EF
{
    public partial class UniversidadeContext : DbContext
    {
        public UniversidadeContext(DbContextOptions<UniversidadeContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Aluno> TbAluno { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            #region Alunos
            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.HasKey(e => e.NumSeqAluno)
                    .HasName("PK__tbAluno__1CC24700C603430B");

                entity.ToTable("tbAluno", "sia");

                entity.Property(e => e.NumSeqAluno).HasColumnName("NUM_SEQ_ALUNO");

                entity.Property(e => e.CodMunicipioNatural).HasColumnName("COD_MUNICIPIO_NATURAL");

                entity.Property(e => e.CodPais).HasColumnName("COD_PAIS");

                entity.Property(e => e.CodUsuarioLog)
                    .HasColumnName("COD_USUARIO_LOG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CpfAluno)
                    .HasColumnName("CPF_ALUNO")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DtAtCadastral)
                    .HasColumnName("DT_AT_CADASTRAL")
                    .HasColumnType("date");

                entity.Property(e => e.DtAtualizaLog)
                    .HasColumnName("DT_ATUALIZA_LOG")
                    .HasColumnType("date");

                entity.Property(e => e.DtConfirmaEmail)
                    .HasColumnName("DT_CONFIRMA_EMAIL")
                    .HasColumnType("date");

                entity.Property(e => e.DtEmissaoIdent)
                    .HasColumnName("DT_EMISSAO_IDENT")
                    .HasColumnType("date");

                entity.Property(e => e.DtInsercao)
                    .HasColumnName("DT_INSERCAO")
                    .HasColumnType("date");

                entity.Property(e => e.DtLimiteDeficiencia)
                    .HasColumnName("DT_LIMITE_DEFICIENCIA")
                    .HasColumnType("date");

                entity.Property(e => e.DtNascimento)
                    .HasColumnName("DT_NASCIMENTO")
                    .HasColumnType("date");

                entity.Property(e => e.DtValidadeCartao)
                    .HasColumnName("DT_VALIDADE_CARTAO")
                    .HasColumnType("date");

                entity.Property(e => e.EndEmail)
                    .HasColumnName("END_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndEmailEstacio)
                    .HasColumnName("END_EMAIL_ESTACIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndEmailLyceum)
                    .HasColumnName("END_EMAIL_LYCEUM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdInstituicaoMig).HasColumnName("ID_INSTITUICAO_MIG");

                entity.Property(e => e.IndCorRaca)
                    .HasColumnName("IND_COR_RACA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndEstadoCivil).HasColumnName("IND_ESTADO_CIVIL");

                entity.Property(e => e.IndInadimplente)
                    .HasColumnName("IND_INADIMPLENTE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndPossuiDeficiencia)
                    .HasColumnName("IND_POSSUI_DEFICIENCIA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndSexo)
                    .HasColumnName("IND_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NomAbreviado)
                    .HasColumnName("NOM_ABREVIADO")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NomAluno)
                    .HasColumnName("NOM_ALUNO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NomMae)
                    .HasColumnName("NOM_MAE")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NomPai)
                    .HasColumnName("NOM_PAI")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NomSocial)
                    .HasColumnName("NOM_SOCIAL")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumCertifMilitar)
                    .HasColumnName("NUM_CERTIF_MILITAR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumIdAlunoInep).HasColumnName("NUM_ID_ALUNO_INEP");

                entity.Property(e => e.NumIdentidade)
                    .HasColumnName("NUM_IDENTIDADE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumIdentidadeAnt)
                    .HasColumnName("NUM_IDENTIDADE_ANT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumPassaporte)
                    .HasColumnName("NUM_PASSAPORTE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumSecaoTitulo)
                    .HasColumnName("NUM_SECAO_TITULO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NumSenhaCartao)
                    .HasColumnName("NUM_SENHA_CARTAO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefCelular)
                    .HasColumnName("NUM_TELEF_CELULAR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelefone)
                    .HasColumnName("NUM_TELEFONE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTituloEleitor)
                    .HasColumnName("NUM_TITULO_ELEITOR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumZonaTitulo)
                    .HasColumnName("NUM_ZONA_TITULO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Profissao)
                    .HasColumnName("PROFISSAO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SglEmissorCertifMilitar)
                    .HasColumnName("SGL_EMISSOR_CERTIF_MILITAR")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SglOrgaoEmissor)
                    .HasColumnName("SGL_ORGAO_EMISSOR")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SglUfCertifMilitar)
                    .HasColumnName("SGL_UF_CERTIF_MILITAR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SglUfIdent)
                    .HasColumnName("SGL_UF_IDENT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SglUfTitulo)
                    .HasColumnName("SGL_UF_TITULO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TxtCidadeNaturalSca)
                    .HasColumnName("TXT_CIDADE_NATURAL_SCA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TxtIdPassaporte)
                    .HasColumnName("TXT_ID_PASSAPORTE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TxtIpLog)
                    .HasColumnName("TXT_IP_LOG")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TxtSenhaEmailEstacio)
                    .HasColumnName("TXT_SENHA_EMAIL_ESTACIO")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
            #endregion Alunos
        }
    }
}
