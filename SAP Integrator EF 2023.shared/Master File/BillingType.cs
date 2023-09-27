using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SAP_Integrator_MVP_EF.shared
{
    public class BillingType
    {
        private int id;
        private string name;
        private string description;
        private int sAP_ObjectCode;

        [DisplayName("Billing Type Id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Desciption is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 50 characters")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        [DisplayName("SAP Object Code")]
        public int SAP_ObjectCode
        {
            get { return sAP_ObjectCode; }
            set { sAP_ObjectCode = value; }
        }

    }
}