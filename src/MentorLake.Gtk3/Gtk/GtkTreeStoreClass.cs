namespace MentorLake.Gtk;

public class GtkTreeStoreClassHandle : BaseSafeHandle
{
}


public static class GtkTreeStoreClassExtensions
{

	public static GtkTreeStoreClass Dereference(this GtkTreeStoreClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeStoreClass>(x.DangerousGetHandle());
}
internal class GtkTreeStoreClassExterns
{
}

public struct GtkTreeStoreClass
{
	public GObjectClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
