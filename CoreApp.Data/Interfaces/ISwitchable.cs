using CoreWebApp.Data.Enums;

namespace CoreWebApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}