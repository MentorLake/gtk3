namespace MentorLake.Gtk;

public class GtkArrowClassHandle : BaseSafeHandle
{
}


public static class GtkArrowClassExtensions
{

	public static GtkArrowClass Dereference(this GtkArrowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkArrowClass>(x.DangerousGetHandle());
}
internal class GtkArrowClassExterns
{
}

public struct GtkArrowClass
{
	public GtkMiscClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
