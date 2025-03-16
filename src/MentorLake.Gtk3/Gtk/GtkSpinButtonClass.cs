namespace MentorLake.Gtk;

public class GtkSpinButtonClassHandle : BaseSafeHandle
{
}


public static class GtkSpinButtonClassExtensions
{

	public static GtkSpinButtonClass Dereference(this GtkSpinButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSpinButtonClass>(x.DangerousGetHandle());
}
internal class GtkSpinButtonClassExterns
{
}

public struct GtkSpinButtonClass
{
	public GtkEntryClass parent_class;
	public IntPtr input;
	public IntPtr output;
	public IntPtr value_changed;
	public IntPtr change_value;
	public IntPtr wrapped;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
