﻿using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WebAPIREST.Models;

namespace WebAPIREST.Dto
{
    public class TelefoneDto
    {
        public int Id_telefone { get; set; }
        [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
        public required string Tipo { get; set; }
        [Required(ErrorMessage = "O campo Numero é obrigatório.")]
        public required string Numero { get; set; }
        public int PessoaId { get; set; }
    }
}
