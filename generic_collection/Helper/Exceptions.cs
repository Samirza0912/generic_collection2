using System;
namespace generic_collection.Helper
{
    public class Exceptions
    {
        public void CapacityLimitException(int count, int capacity)
        {
            if (count == capacity)
            {
                throw new Exception("Capacity limit is exceeded");
            }
        }
        public void ProductCountIsZero(int count)
        {
            throw new Exception("Product is out of stock");
        }
        public void NotFoundException(int? id)
        {
            if (id == null)
            {
                throw new Exception("Not Found 404");
            }
        }
    }
}
