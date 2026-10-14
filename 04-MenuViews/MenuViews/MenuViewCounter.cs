namespace MenuViews;

public sealed class MenuViewCounter
{
    private int _viewCount;
    public int ViewCount => _viewCount;

    public void RegisterView()
    {
        Interlocked.Increment(ref _viewCount);
    }
}
