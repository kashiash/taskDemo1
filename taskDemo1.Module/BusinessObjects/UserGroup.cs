using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace taskDemo1.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class UserGroup : BaseObject
    {
        public UserGroup(Session session) : base(session)
        { }


        string groupName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string GroupName
        {
            get => groupName;
            set => SetPropertyValue(nameof(GroupName), ref groupName, value);
        }

        [Association]
        public XPCollection<ApplicationUser> Users
        {
            get
            {
                return GetCollection<ApplicationUser>(nameof(Users));
            }
        }
    }
}
