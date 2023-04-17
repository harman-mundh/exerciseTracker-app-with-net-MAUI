using SQLite;
using exerciseTracker.Model;

namespace exerciseTracker.Data;

public class DiaryItemDatabase
{
    static SQLiteAsyncConnection Database;

    public static readonly AsyncLazy<DiaryItemDatabase> Instance =
        new AsyncLazy<DiaryItemDatabase>(async () =>
        {
            var instance = new DiaryItemDatabase();
            try
            {
                CreateTableResult result = await Database.CreateTableAsync<DiaryItem>();
            }
            catch (Exception ex)
            {

                throw;
            }
            return instance;
        });


    public DiaryItemDatabase()
    {
        Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
    }

    public Task<List<DiaryItem>> GetItemsAsync()
    {
        return Database.Table<DiaryItem>().ToListAsync();
    }

    public Task<List<DiaryItem>> GetItemsNotDoneAsync()
    {
        return Database.QueryAsync<DiaryItem>("SELECT * FROM [DiaryItem] WHERE [Done] = 0");
    }

    public Task<DiaryItem> GetItemAsync(int id)
    {
        return Database.Table<DiaryItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
    }

    public Task<int> SaveItemAsync(DiaryItem item)
    {
        if (item.ID != 0)
        {
            return Database.UpdateAsync(item);
        }
        else
        {
            return Database.InsertAsync(item);
        }
    }

    public Task<int> DeleteItemAsync(DiaryItem item)
    {
        return Database.DeleteAsync(item);
    }
}