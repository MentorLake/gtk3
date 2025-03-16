namespace MentorLake.Gtk;

public class GtkAdjustmentClassHandle : BaseSafeHandle
{
}


public static class GtkAdjustmentClassExtensions
{

	public static GtkAdjustmentClass Dereference(this GtkAdjustmentClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAdjustmentClass>(x.DangerousGetHandle());
}
internal class GtkAdjustmentClassExterns
{
}

public struct GtkAdjustmentClass
{
	public GInitiallyUnownedClass parent_class;
	public IntPtr changed;
	public IntPtr value_changed;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
