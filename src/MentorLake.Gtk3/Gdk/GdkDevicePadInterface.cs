namespace MentorLake.Gdk;


public class GdkDevicePadInterfaceHandle : BaseSafeHandle
{
}


public static class GdkDevicePadInterfaceExtensions
{

	public static GdkDevicePadInterface Dereference(this GdkDevicePadInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkDevicePadInterface>(x.DangerousGetHandle());
}
internal class GdkDevicePadInterfaceExterns
{
}


public struct GdkDevicePadInterface
{
}
