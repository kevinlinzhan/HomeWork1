using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork1.Models
{
    [MetadataType(typeof(客戶資料MetaData))]
    public partial class 客戶資料MetaData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 客戶資料MetaData()
        {
            this.客戶銀行資訊 = new HashSet<客戶銀行資訊>();
            this.客戶聯絡人 = new HashSet<客戶聯絡人>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "{0} 的長度至少必須為 {2} ~ {1} 個字元。", MinimumLength = 3)]
        public string 客戶名稱 { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "{0} 的長度必須為 {1} 個字元。", MinimumLength = 8)]
        public string 統一編號 { get; set; }
        [Required]
        [StringLength(12, ErrorMessage = "{0} 的長度至少必須為 {2} ~ {1} 個字元。", MinimumLength = 8)]
        public string 電話 { get; set; }
        [Required]
        [StringLength(12, ErrorMessage = "{0} 的長度至少必須為 {2} ~ {1} 個字元。", MinimumLength = 8)]
        public string 傳真 { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "{0} 的長度至少必須為 {2} ~ {1} 個字元。", MinimumLength = 10)]
        public string 地址 { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }
}