namespace MentorLake.Gtk;

public class GtkThemingEngineClassHandle : BaseSafeHandle
{
}


public static class GtkThemingEngineClassExtensions
{

	public static GtkThemingEngineClass Dereference(this GtkThemingEngineClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkThemingEngineClass>(x.DangerousGetHandle());
}
internal class GtkThemingEngineClassExterns
{
}

public struct GtkThemingEngineClass
{
	public GObjectClass parent_class;
	public IntPtr render_line;
	public IntPtr render_background;
	public IntPtr render_frame;
	public IntPtr render_frame_gap;
	public IntPtr render_extension;
	public IntPtr render_check;
	public IntPtr render_option;
	public IntPtr render_arrow;
	public IntPtr render_expander;
	public IntPtr render_focus;
	public IntPtr render_layout;
	public IntPtr render_slider;
	public IntPtr render_handle;
	public IntPtr render_activity;
	public IntPtr render_icon_pixbuf;
	public IntPtr render_icon;
	public IntPtr render_icon_surface;
}
