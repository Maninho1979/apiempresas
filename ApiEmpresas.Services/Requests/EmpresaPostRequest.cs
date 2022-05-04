using System.ComponentModel.DataAnnotations;

namespace ApiEmpresas.Services.Requests
{     
    /// <summary>
/// class pra modelagem de requisição e cadastro de empresa
/// </summary>
    public class EmpresaPostRequest
    {
        [Required(ErrorMessage = "Informe o nome fantasia.")]
        public string? NomeFantasia { get; set; }

        [Required(ErrorMessage = "Informe a razão social.")]
        public string? RazaoSocial { get; set; }

        [Required(ErrorMessage = "Informe o cnpj.")]
        public string? Cnpj { get; set; }
    }
}
