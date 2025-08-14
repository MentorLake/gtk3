namespace MentorLake.Gtk;


public class GtkToolItemClassHandle : BaseSafeHandle
{
}


public static class GtkToolItemClassExtensions
{

	public static GtkToolItemClass Dereference(this GtkToolItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToolItemClass>(x.DangerousGetHandle());
}
internal class GtkToolItemClassExterns
{
}


public struct GtkToolItemClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBinClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when the toolbar needs
///    information from tool_item about whether the item should appear in
///    the toolbar overflow menu.
/// </para>
/// </summary>

public IntPtr create_menu_proxy;
	/// <summary>
/// <para>
/// Signal emitted when some property of the
///    toolbar that the item is a child of changes.
/// </para>
/// </summary>

public IntPtr toolbar_reconfigured;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
