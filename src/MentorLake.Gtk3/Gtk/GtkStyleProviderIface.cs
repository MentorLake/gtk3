namespace MentorLake.Gtk;

public class GtkStyleProviderIfaceHandle : BaseSafeHandle
{
}


public static class GtkStyleProviderIfaceExtensions
{

	public static GtkStyleProviderIface Dereference(this GtkStyleProviderIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStyleProviderIface>(x.DangerousGetHandle());
}
internal class GtkStyleProviderIfaceExterns
{
}

public struct GtkStyleProviderIface
{
	public IntPtr get_style;
	public IntPtr get_style_property;
	public IntPtr get_icon_factory;
}
