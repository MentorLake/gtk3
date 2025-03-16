namespace MentorLake.Gtk;

public class GtkSizeGroupClassHandle : BaseSafeHandle
{
}


public static class GtkSizeGroupClassExtensions
{

	public static GtkSizeGroupClass Dereference(this GtkSizeGroupClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSizeGroupClass>(x.DangerousGetHandle());
}
internal class GtkSizeGroupClassExterns
{
}

public struct GtkSizeGroupClass
{
	public GObjectClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
