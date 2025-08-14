namespace MentorLake.Gtk;


public class GtkHandleBoxClassHandle : BaseSafeHandle
{
}


public static class GtkHandleBoxClassExtensions
{

	public static GtkHandleBoxClass Dereference(this GtkHandleBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHandleBoxClass>(x.DangerousGetHandle());
}
internal class GtkHandleBoxClassExterns
{
}


public struct GtkHandleBoxClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBinClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when the contents of the handlebox
///    are reattached to the main window. Deprecated: 3.4.
/// </para>
/// </summary>

public IntPtr child_attached;
	/// <summary>
/// <para>
/// Signal emitted when the contents of the handlebox
///    are detached from the main window. Deprecated: 3.4.
/// </para>
/// </summary>

public IntPtr child_detached;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
