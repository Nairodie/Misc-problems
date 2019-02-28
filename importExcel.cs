using System;
using System.Web;
using ImportExcel.Class;
using System.ComponentModel.DataAnnotations;


namespace ImportExcel.Models
{
    public class ImportExcel
    {
        [Required(ErrorMessage = "Please select file")]
        [FileExt(Allow = ".xls,.xlsx", ErrorMessage = "Only excel file")]
        public HttpPostedFileBase File { get; set; }
    }
}
