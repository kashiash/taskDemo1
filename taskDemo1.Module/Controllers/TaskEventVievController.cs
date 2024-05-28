using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using taskDemo1.Module.BusinessObjects;

namespace taskDemo1.Module.Controllers
{
    public class TaskEventVievController : ViewController<ListView>
    {
        SimpleAction testAction;
        public TaskEventVievController() : base()
        {
            TargetObjectType = typeof(TestEvent);
            // Target required Views (use the TargetXXX properties) and create their Actions.
            testAction = new SimpleAction(this, $"{GetType().Name}.{nameof(testAction)}", DevExpress.Persistent.Base.PredefinedCategory.Edit)
            {
                ImageName = "BO_Skull",
                Caption = "Ognia"
            };
            testAction.Execute += action_Execute;

        }
        private void action_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            // Execute your business logic (https://docs.devexpress.com/eXpressAppFramework/112737/).
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
    }

}
