using System.ComponentModel.DataAnnotations;

namespace RazorDisplayEditorTemplates.DemoMvcApp.Controllers
{
    [DisplayColumn("FullName")]
    public class ChildModel {
        [Required, StringLength(25)]
        public string FirstName { get; set; }
 
        [Required, StringLength(25)]
        public string LastName { get; set; }
 
        [ScaffoldColumn(false)]
        public string FullName {
            get {
                return FirstName + " " + LastName;
            }
        }
    }
}