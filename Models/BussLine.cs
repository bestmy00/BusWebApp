using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolBussWebApp.Models
{
    public class BussLine
    {
        [Key]
        [DisplayName("순번")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Seq { get; set; }

        [DisplayName("버스년도")]
        [StringLength(4)]
        public string Schl_Year { get; set; }

        [DisplayName("버스학기")]
        [StringLength(1)]
        public string Schl_Shtm { get; set; }

        [DisplayName("버스라인코드")]
        [StringLength(6)]
        public string Buss_Code { get; set; }

        [DisplayName("버스라인이름")]
        [StringLength(20)]
        public string Buss_line { get; set; }

        [DisplayName("버스요금")]
        [Column(TypeName = "decimal(18, 0)")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public decimal Buss_Fees { get; set; }
    }
}
