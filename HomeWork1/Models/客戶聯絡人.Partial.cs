using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork1.Models
{
    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 : IValidatableObject
    {
        private CustomerEntities db = new CustomerEntities();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(db.客戶聯絡人.Where(c => c.Email == Email).FirstOrDefault() != null)
            {
                yield return new ValidationResult("email重覆", new string[] { "Email"});
            }
        }
    }

    public partial class 客戶聯絡人MetaData
    {
        public int Id { get; set; }
        public int 客戶Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "{0} 的長度至少必須為 {2} ~ {1} 個字元。", MinimumLength = 3)]
        public string 職稱 { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "{0} 的長度至少必須為 {2} ~ {1} 個字元。", MinimumLength = 2)]
        public string 姓名 { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [RegularExpression("\\d{4}-\\d{6}", ErrorMessage = "手機格式不正確( e.g. 0911-111111 )")]
        public string 手機 { get; set; }
        [Required]
        [StringLength(12, ErrorMessage = "{0} 的長度至少必須為 {2} ~ {1} 個字元。", MinimumLength = 8)]
        public string 電話 { get; set; }

        public virtual 客戶資料 客戶資料 { get; set; }
    }
}