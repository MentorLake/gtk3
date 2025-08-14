namespace MentorLake.Gtk;


public class GtkToggleToolButtonClassHandle : BaseSafeHandle
{
}


public static class GtkToggleToolButtonClassExtensions
{

	public static GtkToggleToolButtonClass Dereference(this GtkToggleToolButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleToolButtonClass>(x.DangerousGetHandle());
}
internal class GtkToggleToolButtonClassExterns
{
}


public struct GtkToggleToolButtonClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkToolButtonClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted whenever the toggle tool button changes state.
/// </para>
/// </summary>

public IntPtr toggled;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
