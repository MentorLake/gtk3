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
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBinClass parent_class;
	/// <summary>
/// <para>
/// Signal is emitted when the active item is changed.
/// </para>
/// </summary>

public IntPtr changed;
	/// <summary>
/// <para>
/// Signal which allows you to change how the text
///    displayed in a combo box’s entry is displayed.
/// </para>
/// </summary>

public IntPtr format_entry_text;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
}
