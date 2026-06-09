namespace Demo_WebApplication.Codes
{
    public class Repository<T>
    {
        public void Add(T product)
        {
            // Code to add product to database
        }
        public void Update(T product)
        {
            // Code to update product in database
        }
        public void Delete(T product)
        {
        }
        public T Get(int id)
        {
            // Code to get product by id from database
            return default(T);
        }
    }
}
