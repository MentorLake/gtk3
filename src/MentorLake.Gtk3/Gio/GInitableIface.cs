namespace MentorLake.Gio;

public class GInitableIfaceHandle : BaseSafeHandle
{
}


public static class GInitableIfaceExtensions
{

	public static GInitableIface Dereference(this GInitableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInitableIface>(x.DangerousGetHandle());
}
internal class GInitableIfaceExterns
{
}

public struct GInitableIface
{
	public GTypeInterface g_iface;
	public IntPtr init;
}
