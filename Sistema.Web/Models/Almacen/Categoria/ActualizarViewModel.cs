﻿using System.ComponentModel.DataAnnotations;

namespace Sistema.Web.Models.Almacen.Categoria
{
    public class ActualizarViewModel
    {
        [Key]
        public int idcategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe tener mas de 50 caracteres, ni menos de 3 caracteres")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }
    }
}
