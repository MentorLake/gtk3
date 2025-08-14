namespace MentorLake.Gtk;


public class GtkCheckMenuItemClassHandle : BaseSafeHandle
{
}


public static class GtkCheckMenuItemClassExtensions
{

	public static GtkCheckMenuItemClass Dereference(this GtkCheckMenuItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCheckMenuItemClass>(x.DangerousGetHandle());
}
internal class GtkCheckMenuItemClassExterns
{
}


public struct GtkCheckMenuItemClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkMenuItemClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when the state of the check box is changed.
/// </para>
/// </summary>

public IntPtr toggled;
	/// <summary>
/// <para>
/// Called to draw the check indicator.
/// </para>
/// </summary>

public IntPtr draw_indicator;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
