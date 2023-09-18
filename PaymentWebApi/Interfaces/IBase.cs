namespace PaymentWebApi;
public interface IBase<TModel>
{
    public Task<int> CreateAsync(TModel entity);
    public Task<int> UpdateAsync(TModel entity);
    public Task<int> DeleteAsync(long Id);
    public Task<TModel> GetByIdAsync(long Id);
    public Task<List<TModel>> GetAllAsync();
}
