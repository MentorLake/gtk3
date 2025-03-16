namespace MentorLake.Gtk;

public class GtkListStoreClassHandle : BaseSafeHandle
{
}


public static class GtkListStoreClassExtensions
{

	public static GtkListStoreClass Dereference(this GtkListStoreClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkListStoreClass>(x.DangerousGetHandle());
}
internal class GtkListStoreClassExterns
{
}

public struct GtkListStoreClass
{
	public GObjectClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
