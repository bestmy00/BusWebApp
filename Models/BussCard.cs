using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolBussWebApp.Models
{
    public class BussCard
    {
        [DisplayName("관리번호")]
        public int Seq { get; set; }
        [DisplayName("버스라인코드")]
        [StringLength(6)]
        public string Buss_Code { get; set; }
        [DisplayName("버스라인이름")]
        [StringLength(20)]
        public string Buss_Line { get; set; }
        [DisplayName("발급번호")]
        [StringLength(6)]
        public string Issu_Numb { get; set; }
        [Key]
        [DisplayName("카드고유번호")]
        [StringLength(10)]
        public string Card_Uuid { get; set; }
        [DisplayName("문제카드")]
        [StringLength(8)]
        public string Card_Prob { get; set; }
        [DisplayName("카드상태")]
        [StringLength(8)]
        public string Card_Stat { get; set; }

    }
}
