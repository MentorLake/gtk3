namespace MentorLake.Gtk;

public class GtkTreeModelFilterClassHandle : BaseSafeHandle
{
}


public static class GtkTreeModelFilterClassExtensions
{

	public static GtkTreeModelFilterClass Dereference(this GtkTreeModelFilterClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeModelFilterClass>(x.DangerousGetHandle());
}
internal class GtkTreeModelFilterClassExterns
{
}

public struct GtkTreeModelFilterClass
{
	public GObjectClass parent_class;
	public IntPtr visible;
	public IntPtr modify;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
