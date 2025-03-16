namespace MentorLake.Gtk;

public class GtkToolPaletteClassHandle : BaseSafeHandle
{
}


public static class GtkToolPaletteClassExtensions
{

	public static GtkToolPaletteClass Dereference(this GtkToolPaletteClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolPaletteClass>(x.DangerousGetHandle());
}
internal class GtkToolPaletteClassExterns
{
}

public struct GtkToolPaletteClass
{
	public GtkContainerClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
