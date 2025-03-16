namespace MentorLake.Gtk;

public class GtkComboBoxClassHandle : BaseSafeHandle
{
}


public static class GtkComboBoxClassExtensions
{

	public static GtkComboBoxClass Dereference(this GtkComboBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkComboBoxClass>(x.DangerousGetHandle());
}
internal class GtkComboBoxClassExterns
{
}

public struct GtkComboBoxClass
{
	public GtkBinClass parent_class;
	public IntPtr changed;
	public IntPtr format_entry_text;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
}
