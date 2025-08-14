namespace MentorLake.Gtk;


public class GtkColorSelectionClassHandle : BaseSafeHandle
{
}


public static class GtkColorSelectionClassExtensions
{

	public static GtkColorSelectionClass Dereference(this GtkColorSelectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorSelectionClass>(x.DangerousGetHandle());
}
internal class GtkColorSelectionClassExterns
{
}


public struct GtkColorSelectionClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBoxClass parent_class;
	
public IntPtr color_changed;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
