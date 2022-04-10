namespace Infrastructure
{
    public class ContextFactory
    {
        public StorageContext Create()
        {
            return new StorageContext();
        }
    }
}