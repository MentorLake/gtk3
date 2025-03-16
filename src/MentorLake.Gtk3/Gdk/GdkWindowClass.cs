namespace MentorLake.Gdk;

public class GdkWindowClassHandle : BaseSafeHandle
{
}


public static class GdkWindowClassExtensions
{

	public static GdkWindowClass Dereference(this GdkWindowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkWindowClass>(x.DangerousGetHandle());
}
internal class GdkWindowClassExterns
{
}

public struct GdkWindowClass
{
	public GObjectClass parent_class;
	public IntPtr pick_embedded_child;
	public IntPtr to_embedder;
	public IntPtr from_embedder;
	public IntPtr create_surface;
	public IntPtr _gdk_reserved1;
	public IntPtr _gdk_reserved2;
	public IntPtr _gdk_reserved3;
	public IntPtr _gdk_reserved4;
	public IntPtr _gdk_reserved5;
	public IntPtr _gdk_reserved6;
	public IntPtr _gdk_reserved7;
	public IntPtr _gdk_reserved8;
}
