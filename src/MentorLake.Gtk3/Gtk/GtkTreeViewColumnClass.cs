namespace MentorLake.Gtk;

public class GtkTreeViewColumnClassHandle : BaseSafeHandle
{
}


public static class GtkTreeViewColumnClassExtensions
{

	public static GtkTreeViewColumnClass Dereference(this GtkTreeViewColumnClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeViewColumnClass>(x.DangerousGetHandle());
}
internal class GtkTreeViewColumnClassExterns
{
}

public struct GtkTreeViewColumnClass
{
	public GInitiallyUnownedClass parent_class;
	public IntPtr clicked;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
