namespace MentorLake.Gtk;

public class GtkMountOperationClassHandle : BaseSafeHandle
{
}


public static class GtkMountOperationClassExtensions
{

	public static GtkMountOperationClass Dereference(this GtkMountOperationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMountOperationClass>(x.DangerousGetHandle());
}
internal class GtkMountOperationClassExterns
{
}

public struct GtkMountOperationClass
{
	public GMountOperationClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
