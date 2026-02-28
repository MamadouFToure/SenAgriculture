using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenAgriculture.Models
{
    public class Client: Utilisateur
    {
        [Required, MaxLength(100)]
        public string ProfessionClient { get; set; }
    }
}
