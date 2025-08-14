namespace MentorLake.Gtk;


public class GtkAppChooserDialogClassHandle : BaseSafeHandle
{
}


public static class GtkAppChooserDialogClassExtensions
{

	public static GtkAppChooserDialogClass Dereference(this GtkAppChooserDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAppChooserDialogClass>(x.DangerousGetHandle());
}
internal class GtkAppChooserDialogClassExterns
{
}


public struct GtkAppChooserDialogClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkDialogClass parent_class;
}
