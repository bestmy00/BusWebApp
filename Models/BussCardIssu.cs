using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Security.Permissions;

namespace SchoolBussWebApp.Models
{
    public class BussCardIssu
    {
        [Key]
        [DisplayName("발급년도")]
        [StringLength(4)]
        public string Issu_Year { get; set; }

        [Key]
        [DisplayName("발급학기")]
        [StringLength(1)]
        public string Issu_Shtm { get; set; }

        [DisplayName("버스라인코드")]
        [StringLength(6)]
        public string Buss_Code { get; set; }

        [Key]
        [DisplayName("학번")]
        [StringLength(10)]
        public string Stnt_Numb { get; set; }

        [DisplayName("성명")]
        [StringLength(20)]
        public string Korn_Name { get; set; }
        
        [DisplayName("발급번호")]
        [StringLength(6)]
        public string Issu_Numb { get; set; }

        [DisplayName("보증금액")]
        [Column(TypeName = "decimal(18, 0)")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public decimal Dpst_Amnt { get; set; }

        [DisplayName("버스금액")]
        [Column(TypeName = "decimal(18, 0)")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public decimal Buss_Fees { get; set; }

        [DisplayName("수납총액")]
        [Column(TypeName = "decimal(18, 0)")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public decimal Regi_Amnt { get; set; }
        
        [DisplayName("발급일자")]
        [StringLength(10)]
        public string Issu_Date { get; set; }

        [DisplayName("발급구분")]
        [StringLength(6)]
        public string Issu_Type { get; set; }

        [DisplayName("발급상태")]
        [StringLength(6)]
        public string Issu_Stat { get; set; }

        [DisplayName("최종상태일자")]
        [StringLength(10)]
        public string Stat_Date { get; set; }
    }
}
