namespace MentorLake.Gtk;

public class GtkToolShellIfaceHandle : BaseSafeHandle
{
}


public static class GtkToolShellIfaceExtensions
{

	public static GtkToolShellIface Dereference(this GtkToolShellIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolShellIface>(x.DangerousGetHandle());
}
internal class GtkToolShellIfaceExterns
{
}

public struct GtkToolShellIface
{
	public IntPtr get_icon_size;
	public IntPtr get_orientation;
	public IntPtr get_style;
	public IntPtr get_relief_style;
	public IntPtr rebuild_menu;
	public IntPtr get_text_orientation;
	public IntPtr get_text_alignment;
	public IntPtr get_ellipsize_mode;
	public IntPtr get_text_size_group;
}
