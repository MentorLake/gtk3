namespace MentorLake.Gtk;


public class GtkLockButtonClassHandle : BaseSafeHandle
{
}


public static class GtkLockButtonClassExtensions
{

	public static GtkLockButtonClass Dereference(this GtkLockButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLockButtonClass>(x.DangerousGetHandle());
}
internal class GtkLockButtonClassExterns
{
}


public struct GtkLockButtonClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkButtonClass parent_class;
	
public IntPtr reserved0;
	
public IntPtr reserved1;
	
public IntPtr reserved2;
	
public IntPtr reserved3;
	
public IntPtr reserved4;
	
public IntPtr reserved5;
	
public IntPtr reserved6;
	
public IntPtr reserved7;
}
