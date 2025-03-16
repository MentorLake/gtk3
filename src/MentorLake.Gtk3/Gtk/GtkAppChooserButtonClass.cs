namespace MentorLake.Gtk;

public class GtkAppChooserButtonClassHandle : BaseSafeHandle
{
}


public static class GtkAppChooserButtonClassExtensions
{

	public static GtkAppChooserButtonClass Dereference(this GtkAppChooserButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAppChooserButtonClass>(x.DangerousGetHandle());
}
internal class GtkAppChooserButtonClassExterns
{
}

public struct GtkAppChooserButtonClass
{
	public GtkComboBoxClass parent_class;
	public IntPtr custom_item_activated;
}
