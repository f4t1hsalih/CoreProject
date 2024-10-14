namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> TGetListAll();
        T TGetById(int id);
        void TAdd(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
    }
}
