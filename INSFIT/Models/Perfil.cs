﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSFIT.Models
{
    [Table("Usuarios")]
    public class Perfil
    {
        [Key]
        public int Id { get; set; }
    
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Informe um email válido")]
        public string Email { get; set; }
       
        public double Altura { get; set; }
   
        public double Peso { get; set; }
       // [Phone(ErrorMessage ="informe um numero válido")]
        public int Telefone { get; set; }
   
        
        public TipoUsuario Usuario { get; set; }

        public enum TipoUsuario
        {
            Aluno,
            Personal
        }

    }


}
