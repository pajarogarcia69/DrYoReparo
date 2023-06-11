using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrYoReparo.Shared.Entities
{
    public class OrderService
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string EquipmentType { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string Brand { get; set; } = null!;

        public DateTime DateIncome { get; set; }

        public DateTime DateWithdrawal { get; set; }

        [Required]
        [MaxLength(30)]
        public string NameOwner { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string LastnameOwner { get; set; } = null!;

        public int Phone { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(200)]
        public string Diagnosis { get; set; } = null!;

        [MaxLength(200)]
        public string CommentTechnical { get; set; } = null!;

        [MaxLength(15)]
        public string RepairStatus { get; set; } = null!;

        public float RepairValue { get; set; }
    }
}
