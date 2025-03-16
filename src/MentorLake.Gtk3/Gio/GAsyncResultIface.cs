namespace MentorLake.Gio;

public class GAsyncResultIfaceHandle : BaseSafeHandle
{
}


public static class GAsyncResultIfaceExtensions
{

	public static GAsyncResultIface Dereference(this GAsyncResultIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAsyncResultIface>(x.DangerousGetHandle());
}
internal class GAsyncResultIfaceExterns
{
}

public struct GAsyncResultIface
{
	public GTypeInterface g_iface;
	public IntPtr get_user_data;
	public IntPtr get_source_object;
	public IntPtr is_tagged;
}
