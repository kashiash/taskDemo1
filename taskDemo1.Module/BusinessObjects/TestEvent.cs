using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace taskDemo1.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class TestEvent : Event
    {
        public TestEvent(Session session) : base(session)
        { }


        string notes;
        UserGroup assignedToGroup;
        ApplicationUser assignedTo;

        public ApplicationUser AssignedTo
        {
            get => assignedTo;
            set => SetPropertyValue(nameof(AssignedTo), ref assignedTo, value);
        }


        public UserGroup AssignedToGroup
        {
            get => assignedToGroup;
            set => SetPropertyValue(nameof(AssignedToGroup), ref assignedToGroup, value);
        }

        [Association]
        public XPCollection<ApplicationUser> Readers
        {
            get
            {
                return GetCollection<ApplicationUser>(nameof(Readers));
            }
        }

        [Size(SizeAttribute.Unlimited)]
        public string Notes
        {
            get => notes;
            set => SetPropertyValue(nameof(Notes), ref notes, value);
        }

        [Action(Caption = "Set Time", ImageName = "BO_Skull", AutoCommit = true)]
        public void AddNotes()
        {
            Notes = Notes + $" {DateTime.Now}";
        }
    }
}
