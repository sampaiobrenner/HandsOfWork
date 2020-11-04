namespace HandsOfWork.Entities
{
    public class SimpleId<T> where T : struct
    {
        public T Id { get; set; }
    }
}