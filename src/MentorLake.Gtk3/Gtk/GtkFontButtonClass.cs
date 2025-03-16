namespace MentorLake.Gtk;

public class GtkFontButtonClassHandle : BaseSafeHandle
{
}


public static class GtkFontButtonClassExtensions
{

	public static GtkFontButtonClass Dereference(this GtkFontButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontButtonClass>(x.DangerousGetHandle());
}
internal class GtkFontButtonClassExterns
{
}

public struct GtkFontButtonClass
{
	public GtkButtonClass parent_class;
	public IntPtr font_set;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
