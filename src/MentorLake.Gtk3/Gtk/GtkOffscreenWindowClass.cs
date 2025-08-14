namespace MentorLake.Gtk;


public class GtkOffscreenWindowClassHandle : BaseSafeHandle
{
}


public static class GtkOffscreenWindowClassExtensions
{

	public static GtkOffscreenWindowClass Dereference(this GtkOffscreenWindowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkOffscreenWindowClass>(x.DangerousGetHandle());
}
internal class GtkOffscreenWindowClassExterns
{
}


public struct GtkOffscreenWindowClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkWindowClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
