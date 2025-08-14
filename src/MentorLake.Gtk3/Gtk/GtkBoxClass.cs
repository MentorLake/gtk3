namespace MentorLake.Gtk;


public class GtkBoxClassHandle : BaseSafeHandle
{
}


public static class GtkBoxClassExtensions
{

	public static GtkBoxClass Dereference(this GtkBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBoxClass>(x.DangerousGetHandle());
}
internal class GtkBoxClassExterns
{
}


public struct GtkBoxClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkContainerClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
