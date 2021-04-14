using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolBussWebApp.Models
{
    public class BussAtnd
    {
        [Key]
        [DisplayName("신청년도")]
        [StringLength(4)]
        public string Schl_Year { get; set; }

        [Key]
        [DisplayName("신청학기")]
        [StringLength(1)]
        public string Schl_Shtm { get; set; }

        [DisplayName("버스라인코드")]
        [StringLength(6)]
        public string Buss_Code { get; set; }

        [Key]
        [DisplayName("신청학번")]
        [StringLength(10)]
        public string Stnt_Numb { get; set; }

        [DisplayName("신청자연락처")]
        [StringLength(16)]
        public string Stnt_Hand { get; set; }

        [DisplayName("신청일자")]
        [StringLength(8)]
        public string Aply_Date { get; set; }

        [DisplayName("신청번호")]
        [Column(TypeName = "decimal(18, 0)")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        public decimal Aply_Numb { get; set; }

        [DisplayName("신청금액")]
        [Column(TypeName = "decimal(18, 0)")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        [DefaultValue(0)]
        public decimal Aply_Amnt { get; set; }

        [DisplayName("비고")]
        [StringLength(255)]
        public string Remk_Text { get; set; }

        [DisplayName("입력일자")]
        [StringLength(10)]
        public string Inpt_Date { get; set; }

        [DisplayName("수정일자")]
        [StringLength(10)]
        public string Updt_Date { get; set; }

        [DisplayName("신청상태코드")]
        [StringLength(6)]
        public string Aply_Stat { get; set; }

        [DisplayName("신청타입코드")]
        [StringLength(6)]
        public string Aply_Type { get; set; }

    }
}
