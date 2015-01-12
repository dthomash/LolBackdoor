namespace LolBackdoor.APIs
{
    public interface ILolApi
    {
        string GetApiName();
        string GetApiVersion();
        void SetServer(LolRegion region);
    }
}
