using System.ComponentModel.DataAnnotations;

namespace VarcalSysClient.Web.Models
{
    public class TicketTipoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}