namespace MentorLake.Gio;

public class GUnixFDListClassHandle : BaseSafeHandle
{
}


public static class GUnixFDListClassExtensions
{

	public static GUnixFDListClass Dereference(this GUnixFDListClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixFDListClass>(x.DangerousGetHandle());
}
internal class GUnixFDListClassExterns
{
}

public struct GUnixFDListClass
{
	public GObjectClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}
