using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork1.Models
{
    [MetadataType(typeof(客戶銀行資訊MetaData))]
    public partial class 客戶銀行資訊MetaData
    {
        public int Id { get; set; }
        public int 客戶Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "{0} 的長度至少必須為 {2} ~ {1} 個字元。", MinimumLength = 3)]
        public string 銀行名稱 { get; set; }
        [Required]
        [Range(1000, 9000, ErrorMessage = "{0} 的值至少必須為 {1} ~ {2} 數字。")]
        public int 銀行代碼 { get; set; }
        [Required]
        [Range(1000, 9000, ErrorMessage = "{0} 的值至少必須為 {1} ~ {2} 數字。")]
        public Nullable<int> 分行代碼 { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "{0} 的長度至少必須為 {2} ~ {1} 個字元。", MinimumLength = 3)]
        public string 帳戶名稱 { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "{0} 的長度至少必須為 {2} ~ {1} 個字元。", MinimumLength = 5)]
        public string 帳戶號碼 { get; set; }
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}