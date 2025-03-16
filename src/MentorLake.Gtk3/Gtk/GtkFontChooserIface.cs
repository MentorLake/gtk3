namespace MentorLake.Gtk;

public class GtkFontChooserIfaceHandle : BaseSafeHandle
{
}


public static class GtkFontChooserIfaceExtensions
{

	public static GtkFontChooserIface Dereference(this GtkFontChooserIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontChooserIface>(x.DangerousGetHandle());
}
internal class GtkFontChooserIfaceExterns
{
}

public struct GtkFontChooserIface
{
	public GTypeInterface base_iface;
	public IntPtr get_font_family;
	public IntPtr get_font_face;
	public IntPtr get_font_size;
	public IntPtr set_filter_func;
	public IntPtr font_activated;
	public IntPtr set_font_map;
	public IntPtr get_font_map;
	public IntPtr padding;
}
