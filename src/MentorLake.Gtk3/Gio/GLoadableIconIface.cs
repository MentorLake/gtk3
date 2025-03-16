namespace MentorLake.Gio;

public class GLoadableIconIfaceHandle : BaseSafeHandle
{
}


public static class GLoadableIconIfaceExtensions
{

	public static GLoadableIconIface Dereference(this GLoadableIconIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLoadableIconIface>(x.DangerousGetHandle());
}
internal class GLoadableIconIfaceExterns
{
}

public struct GLoadableIconIface
{
	public GTypeInterface g_iface;
	public IntPtr load;
	public IntPtr load_async;
	public IntPtr load_finish;
}
