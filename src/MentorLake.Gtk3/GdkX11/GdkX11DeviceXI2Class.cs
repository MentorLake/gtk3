namespace MentorLake.GdkX11;


public class GdkX11DeviceXI2ClassHandle : BaseSafeHandle
{
}


public static class GdkX11DeviceXI2ClassExtensions
{

	public static GdkX11DeviceXI2Class Dereference(this GdkX11DeviceXI2ClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11DeviceXI2Class>(x.DangerousGetHandle());
}
internal class GdkX11DeviceXI2ClassExterns
{
}


public struct GdkX11DeviceXI2Class
{
}
