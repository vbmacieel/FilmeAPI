using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Model.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatorio")]
        public string Diretor { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "O genero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(0, 600, ErrorMessage = "O filme deve ter entre 0 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
