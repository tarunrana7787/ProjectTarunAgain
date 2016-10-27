namespace ProjectTarunAgain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GameTable")]
    public partial class GameTable
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WeekNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Team1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Team2 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string GameName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Team1Score { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Team2Score { get; set; }
    }
}
