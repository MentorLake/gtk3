namespace MentorLake.Gio;

public class GAsyncInitableIfaceHandle : BaseSafeHandle
{
}


public static class GAsyncInitableIfaceExtensions
{

	public static GAsyncInitableIface Dereference(this GAsyncInitableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAsyncInitableIface>(x.DangerousGetHandle());
}
internal class GAsyncInitableIfaceExterns
{
}

public struct GAsyncInitableIface
{
	public GTypeInterface g_iface;
	public IntPtr init_async;
	public IntPtr init_finish;
}
