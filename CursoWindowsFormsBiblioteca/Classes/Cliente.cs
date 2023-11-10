using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CursoWindowsFormsBiblioteca;
using Newtonsoft.Json;
using CursoWindowsFormsBiblioteca.DataBases;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Id é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Somente valores númericos!")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Máximo 6 digitos!")]
            public string Id { get; set; }
            [Required(ErrorMessage = "Nome é obrigatório!")]
            [StringLength(50, ErrorMessage = "Deve ter no máximo 50 caracteres")]
            public string Nome { get; set; }
            [StringLength(50, ErrorMessage = "Nome deve ter no máximo 50 caracteres")]
            public string NomePai { get; set; }
            [Required(ErrorMessage = "Nome da mãe é obrigatório!")]
            [StringLength(50, ErrorMessage = "Nome da mãe deve ter no máximo 50 caracteres")]
            public string NomeMae { get; set; }
            public bool NaoTemPai { get; set; }
            [Required(ErrorMessage = "Cpf é obrigatório!")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Cpf aceita Somente valores numéricos!")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 digitos")]
            public string Cpf { get; set; }
            [Required(ErrorMessage = "Genero é obrigatório!")]
            public int Genero { get; set; }
            [Required(ErrorMessage = "CEP obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Cep aceita somente valores numéricos!")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 digitos")]
            public string Cep { get; set; }
            [Required(ErrorMessage = "Logradouro é obrigatório!")]
            [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres")]
            public string Logradouro { get; set; }
            [Required(ErrorMessage = "Complemento é obrigatório!")]
            [StringLength(50, ErrorMessage = "Complemento deve ter no máximo 100 caracteres")]
            public string Complemento { get; set; }
            [Required(ErrorMessage = "Bairro é obrigatório!")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres")]
            public string Bairro { get; set; }
            [Required(ErrorMessage = "Cidade é obrigatório!")]
            [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres")]
            public string Cidade { get; set; }
            [Required(ErrorMessage = "Estado é obrigatório!")]
            [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres")]
            public string Estado { get; set; }
            [Required(ErrorMessage = "Telefone é obrigatório!")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Telefone aceita somente valores numéricos!")]
            public string Telefone { get; set; }
            public string Profissao { get; set; }
            [Required(ErrorMessage = "Renda familiar é obrigatório!")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda familiar deve ser positivo")]
            public double RendaFamiliar{ get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if(isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        //Se tiver mais de um erro, aqui vai ser pego os erros
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }    
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                
                if (this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome da mãe não pode ser igual ao nome do pai!");
                }
                if(this.NaoTemPai == false)
                {
                    if(this.NomePai == "")
                    {
                        throw new Exception("Nome do pai não pode ser vazio, quando a propriedade Pai desconhecida não estiver marcada!");
                    }
                }
                bool validaCpf = Cls_Uteis.Valida(this.Cpf);

                if(validaCpf == false)
                {
                    
                    throw new Exception("Cpf invalido!");
                }
            }

            #region "Crud do fichario"
            public void IncluirFichario(string conexao)
            {

                string clienteJson = Cliente.SerializarClasseUnit(this);
                Fichario f = new Fichario(conexao);
                if (f.status)
                {
                    f.Incluir(this.Id, clienteJson);
                    if (!(f.status))
                    {
                        throw new Exception(f.mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.mensagem);
                }
            }

            public Unit BuscarFichario(string id, string conexao)
            {
                Fichario f = new Fichario(conexao);
                if (f.status)
                {
                    string clienteJson = f.Buscar(id);
                    return Cliente.DesSerializarClasseUnit(clienteJson);
                }
                else
                {
                    throw new Exception(f.mensagem);
                }

            }

            public void AlterarFichario(string conexao)
            {
                string clienteJson = Cliente.SerializarClasseUnit(this);
                Fichario f = new Fichario(conexao);
                if (f.status)
                {
                    f.Alterar(this.Id, clienteJson);
                    if (!(f.status))
                    {
                        throw new Exception(f.mensagem);
                    }

                }
                else
                {
                    throw new Exception(f.mensagem);
                }
            }

            public void ApagarFichario(string conexao)
            {
                Fichario f = new Fichario(conexao);
                if (f.status)
                {
                   f.Apagar(this.Id); 
                    if (!(f.status))
                    {
                        throw new Exception(f.mensagem);
                    }

                }
                else
                {
                    throw new Exception(f.mensagem);
                }
            }

            public List<string> ListaFichario(string conexao)
            {
                Fichario f = new Fichario(conexao);
                if (f.status)
                {
                    List<string> todosJson = f.BuscarTodos();
                    return todosJson;
                }
                else
                {
                    throw new Exception(f.mensagem);
                }
            }

            #endregion
        }



        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static string SerializarClasseUnit(Unit unit)
        {
            //metodo para serialização 
            return JsonConvert.SerializeObject(unit); 
        }
        public static Unit DesSerializarClasseUnit(string vJson)
        {
            //metodo para desserialização 
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }
    }
}