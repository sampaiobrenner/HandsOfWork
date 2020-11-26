namespace HandsOfWork.Entities.Abstractions
{
    public class SimpleId<T> where T : struct
    {
        public T Id { get; set; }
    }
}