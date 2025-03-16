namespace MentorLake.Gtk;

public class GtkStylePropertiesClassHandle : BaseSafeHandle
{
}


public static class GtkStylePropertiesClassExtensions
{

	public static GtkStylePropertiesClass Dereference(this GtkStylePropertiesClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStylePropertiesClass>(x.DangerousGetHandle());
}
internal class GtkStylePropertiesClassExterns
{
}

public struct GtkStylePropertiesClass
{
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
