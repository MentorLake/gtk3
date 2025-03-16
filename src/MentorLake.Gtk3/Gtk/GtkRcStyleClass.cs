namespace MentorLake.Gtk;

public class GtkRcStyleClassHandle : BaseSafeHandle
{
}


public static class GtkRcStyleClassExtensions
{

	public static GtkRcStyleClass Dereference(this GtkRcStyleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRcStyleClass>(x.DangerousGetHandle());
}
internal class GtkRcStyleClassExterns
{
}

public struct GtkRcStyleClass
{
	public GObjectClass parent_class;
	public IntPtr create_rc_style;
	public IntPtr parse;
	public IntPtr merge;
	public IntPtr create_style;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
