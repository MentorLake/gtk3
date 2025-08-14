namespace MentorLake.Gtk;


public class GtkButtonClassHandle : BaseSafeHandle
{
}


public static class GtkButtonClassExtensions
{

	public static GtkButtonClass Dereference(this GtkButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkButtonClass>(x.DangerousGetHandle());
}
internal class GtkButtonClassExterns
{
}


public struct GtkButtonClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBinClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when the button is pressed. Deprecated: 2.8.
/// </para>
/// </summary>

public IntPtr pressed;
	/// <summary>
/// <para>
/// Signal emitted when the button is released. Deprecated: 2.8.
/// </para>
/// </summary>

public IntPtr released;
	/// <summary>
/// <para>
/// Signal emitted when the button has been activated (pressed and released).
/// </para>
/// </summary>

public IntPtr clicked;
	/// <summary>
/// <para>
/// Signal emitted when the pointer enters the button. Deprecated: 2.8.
/// </para>
/// </summary>

public IntPtr enter;
	/// <summary>
/// <para>
/// Signal emitted when the pointer leaves the button. Deprecated: 2.8.
/// </para>
/// </summary>

public IntPtr leave;
	/// <summary>
/// <para>
/// Signal that causes the button to animate press then
///    release. Applications should never connect to this signal, but use
///    the @clicked signal.
/// </para>
/// </summary>

public IntPtr activate;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
