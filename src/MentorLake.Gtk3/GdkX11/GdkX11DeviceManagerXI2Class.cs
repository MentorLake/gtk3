namespace MentorLake.GdkX11;


public class GdkX11DeviceManagerXI2ClassHandle : BaseSafeHandle
{
}


public static class GdkX11DeviceManagerXI2ClassExtensions
{

	public static GdkX11DeviceManagerXI2Class Dereference(this GdkX11DeviceManagerXI2ClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11DeviceManagerXI2Class>(x.DangerousGetHandle());
}
internal class GdkX11DeviceManagerXI2ClassExterns
{
}


public struct GdkX11DeviceManagerXI2Class
{
}
