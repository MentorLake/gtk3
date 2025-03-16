namespace MentorLake.Gtk;

public class GtkComboBoxAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkComboBoxAccessibleClassExtensions
{

	public static GtkComboBoxAccessibleClass Dereference(this GtkComboBoxAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkComboBoxAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkComboBoxAccessibleClassExterns
{
}

public struct GtkComboBoxAccessibleClass
{
	public GtkContainerAccessibleClass parent_class;
}
