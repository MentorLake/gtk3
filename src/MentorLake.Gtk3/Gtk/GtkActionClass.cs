namespace MentorLake.Gtk;


public class GtkActionClassHandle : BaseSafeHandle
{
}


public static class GtkActionClassExtensions
{

	public static GtkActionClass Dereference(this GtkActionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActionClass>(x.DangerousGetHandle());
}
internal class GtkActionClassExterns
{
}


public struct GtkActionClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when the action is activated.
/// </para>
/// </summary>

public IntPtr activate;
	
public IntPtr create_menu_item;
	
public IntPtr create_tool_item;
	
public IntPtr connect_proxy;
	
public IntPtr disconnect_proxy;
	
public IntPtr create_menu;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
