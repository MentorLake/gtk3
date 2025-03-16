namespace MentorLake.Gio;

public class GIconIfaceHandle : BaseSafeHandle
{
}


public static class GIconIfaceExtensions
{

	public static GIconIface Dereference(this GIconIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIconIface>(x.DangerousGetHandle());
}
internal class GIconIfaceExterns
{
}

public struct GIconIface
{
	public GTypeInterface g_iface;
	public IntPtr hash;
	public IntPtr equal;
	public IntPtr to_tokens;
	public IntPtr from_tokens;
	public IntPtr serialize;
}
