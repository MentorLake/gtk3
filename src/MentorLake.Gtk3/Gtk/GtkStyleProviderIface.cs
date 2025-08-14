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
	/// <summary>
/// <para>
/// Gets a set of style information that applies to a widget path.
/// </para>
/// </summary>

public IntPtr get_style;
	/// <summary>
/// <para>
/// Gets the value of a widget style property that applies to a widget path.
/// </para>
/// </summary>

public IntPtr get_style_property;
	/// <summary>
/// <para>
/// Gets the icon factory that applies to a widget path.
/// </para>
/// </summary>

public IntPtr get_icon_factory;
}
