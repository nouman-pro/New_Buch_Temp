//using PRJ.DataAccess.Entities;

using PRJ.DataAccess.Entities;

namespace PRJ.Repository.UnitOfWorks;
public class UnitOfWork //: IDisposable, IUnitOfWork
{
    private bool disposed = false;
    private readonly MainContext _context;
    public UnitOfWork(MainContext _context)
    {
        this._context = _context;
    }
    #region System
     private IRepository<PRJ.DataAccess.Entities.User> _userRepo;



    #endregion


    public IRepository<PRJ.DataAccess.Entities.User> UserRepo
    {
        get
        {
            if (_userRepo == null)
            {
                _userRepo = new Repository<PRJ.DataAccess.Entities.User>(_context);
            }
            return _userRepo;
        }
    }
    public async Task<int> Save()
    {
        var res = await _context.SaveChangesAsync();
        return res;
    }

    public void Dispose()
    {
        this._context.Dispose();
    }
}
