namespace MentorLake.Gtk;


public class GtkDialogClassHandle : BaseSafeHandle
{
}


public static class GtkDialogClassExtensions
{

	public static GtkDialogClass Dereference(this GtkDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkDialogClass>(x.DangerousGetHandle());
}
internal class GtkDialogClassExterns
{
}


public struct GtkDialogClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkWindowClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when an action widget is activated.
/// </para>
/// </summary>

public IntPtr response;
	/// <summary>
/// <para>
/// Signal emitted when the user uses a keybinding to close the dialog.
/// </para>
/// </summary>

public IntPtr close;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
