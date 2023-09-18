using PaymentWebApi;

namespace PaymentApp;
public class CardRepository : ICard
{
    private readonly AppDbContext _dbcontext;

    public CardRepository(AppDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }

    public async Task<int> CreateAsync(Card entity)
    {
        await _dbcontext.Cards.AddAsync(entity);
        return await _dbcontext.SaveChangesAsync();  
    }

    public async Task<int> UpdateAsync(Card entity)
    {
        _dbcontext.Cards.Update(entity);
        return await _dbcontext.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(long Id)
    {
        var card = await _dbcontext.Cards.FindAsync(Id);
        if (card != null)
        {
            _dbcontext.Cards.Remove(card);
            return await _dbcontext.SaveChangesAsync();
        }

        return -1;
    }

    public async Task<Card> GetByIdAsync(long Id)
    {
        var card = await  _dbcontext.Cards.FindAsync(Id);
        if(card != null)
        {
            return card;
        }
        return new Card();
    }

    public async Task<List<Card>> GetAllAsync()
    {
        var cards = _dbcontext.Cards.ToList();

        if(cards != null)
        {
            return cards;
        }
        return new List<Card>();
    }
}
