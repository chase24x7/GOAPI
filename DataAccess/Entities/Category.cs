using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Category
    {
        public Category()
        {
        }

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ParentCategoryId { get; set; }
        public string Keyword { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string IsActive { get; set; }
        public string Piority { get; set; }

        #endregion //Properties
    }
}
