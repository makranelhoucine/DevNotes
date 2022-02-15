namespace ExtensionMethods.Extensions
{
    public class Target
    {
        private string? _Id;

        protected string Id 
        {
            get 
            {
                return this._Id;
            }
            set
            {
                this._Id = value.Trim();
            } 
        }

        public string GetId() => this.Id;

        public Target(string id)
        {
            this.Id = id;
        }

        internal class InternalTarget
        {
            protected class ProtectedSubClass
            {

            }
        }
    }
}