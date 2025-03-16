namespace MentorLake.Gtk;

public class GtkComboBoxTextClassHandle : BaseSafeHandle
{
}


public static class GtkComboBoxTextClassExtensions
{

	public static GtkComboBoxTextClass Dereference(this GtkComboBoxTextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkComboBoxTextClass>(x.DangerousGetHandle());
}
internal class GtkComboBoxTextClassExterns
{
}

public struct GtkComboBoxTextClass
{
	public GtkComboBoxClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
