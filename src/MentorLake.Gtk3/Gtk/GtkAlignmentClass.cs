namespace MentorLake.Gtk;

public class GtkAlignmentClassHandle : BaseSafeHandle
{
}


public static class GtkAlignmentClassExtensions
{

	public static GtkAlignmentClass Dereference(this GtkAlignmentClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAlignmentClass>(x.DangerousGetHandle());
}
internal class GtkAlignmentClassExterns
{
}

public struct GtkAlignmentClass
{
	public GtkBinClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
