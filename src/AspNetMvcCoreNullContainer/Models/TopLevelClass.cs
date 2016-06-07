namespace AspNetMvcCoreNullContainer.Models
{
    public class TopLevelClass
    {
        public ChildClass Initialized { get; set; }

        public ChildClass NotInitialized { get; set; }

        public TopLevelClass()
        {
            this.Initialized = new ChildClass();
        }
    }
}