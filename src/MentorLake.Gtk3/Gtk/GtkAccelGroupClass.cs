namespace MentorLake.Gtk;


public class GtkAccelGroupClassHandle : BaseSafeHandle
{
}


public static class GtkAccelGroupClassExtensions
{

	public static GtkAccelGroupClass Dereference(this GtkAccelGroupClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAccelGroupClass>(x.DangerousGetHandle());
}
internal class GtkAccelGroupClassExterns
{
}


public struct GtkAccelGroupClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when an entry is added to or removed
///    from the accel group.
/// </para>
/// </summary>

public IntPtr accel_changed;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
