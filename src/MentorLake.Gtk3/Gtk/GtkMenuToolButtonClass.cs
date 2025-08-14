namespace MentorLake.Gtk;


public class GtkMenuToolButtonClassHandle : BaseSafeHandle
{
}


public static class GtkMenuToolButtonClassExtensions
{

	public static GtkMenuToolButtonClass Dereference(this GtkMenuToolButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuToolButtonClass>(x.DangerousGetHandle());
}
internal class GtkMenuToolButtonClassExterns
{
}


public struct GtkMenuToolButtonClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkToolButtonClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted before the menu is shown.
/// </para>
/// </summary>

public IntPtr show_menu;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
