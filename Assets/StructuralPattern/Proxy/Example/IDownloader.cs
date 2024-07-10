namespace WenQu.DesignPattern.Proxy
{
    /// <summary>
    /// 原始下载接口
    /// </summary>
    public interface IDownloader
    {
        public bool DownloadImg(int id);
    }
}