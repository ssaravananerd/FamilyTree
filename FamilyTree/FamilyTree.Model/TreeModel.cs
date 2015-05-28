
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Model
{
    public class TreeModel
    {
        public string ID { get; set; }
        public bool IsParent { get; set; }
        public string ParentID { get; set; }
    }

    public class UserDetail
    {
        public string ID { get; set; }
        public string DisplayName { get; set; }
        public IList<string> SpouseIDs { get; set; }
        public string Gender { get; set; }
    }
}
