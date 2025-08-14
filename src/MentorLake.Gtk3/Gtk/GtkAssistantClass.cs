namespace MentorLake.Gtk;


public class GtkAssistantClassHandle : BaseSafeHandle
{
}


public static class GtkAssistantClassExtensions
{

	public static GtkAssistantClass Dereference(this GtkAssistantClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAssistantClass>(x.DangerousGetHandle());
}
internal class GtkAssistantClassExterns
{
}


public struct GtkAssistantClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkWindowClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when a new page is set as the assistant’s current page, before making the new page visible.
/// </para>
/// </summary>

public IntPtr prepare;
	/// <summary>
/// <para>
/// Signal emitted when the apply button is clicked.
/// </para>
/// </summary>

public IntPtr apply;
	/// <summary>
/// <para>
/// Signal emitted either when the close button or last page apply button is clicked.
/// </para>
/// </summary>

public IntPtr close;
	/// <summary>
/// <para>
/// Signal emitted when the cancel button is clicked.
/// </para>
/// </summary>

public IntPtr cancel;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
}
