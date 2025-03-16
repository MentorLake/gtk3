namespace MentorLake.Gtk;

public class GtkTextTagTableClassHandle : BaseSafeHandle
{
}


public static class GtkTextTagTableClassExtensions
{

	public static GtkTextTagTableClass Dereference(this GtkTextTagTableClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextTagTableClass>(x.DangerousGetHandle());
}
internal class GtkTextTagTableClassExterns
{
}

public struct GtkTextTagTableClass
{
	public GObjectClass parent_class;
	public IntPtr tag_changed;
	public IntPtr tag_added;
	public IntPtr tag_removed;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
