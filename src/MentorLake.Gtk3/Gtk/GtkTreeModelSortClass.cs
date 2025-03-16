namespace MentorLake.Gtk;

public class GtkTreeModelSortClassHandle : BaseSafeHandle
{
}


public static class GtkTreeModelSortClassExtensions
{

	public static GtkTreeModelSortClass Dereference(this GtkTreeModelSortClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeModelSortClass>(x.DangerousGetHandle());
}
internal class GtkTreeModelSortClassExterns
{
}

public struct GtkTreeModelSortClass
{
	public GObjectClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
