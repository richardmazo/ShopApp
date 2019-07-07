namespace ShopApp.UIForms.Infrastructure
{
    using ShopApp.UIForms.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
