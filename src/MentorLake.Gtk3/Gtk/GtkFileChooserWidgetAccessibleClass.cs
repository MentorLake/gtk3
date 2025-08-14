namespace MentorLake.Gtk;


public class GtkFileChooserWidgetAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkFileChooserWidgetAccessibleClassExtensions
{

	public static GtkFileChooserWidgetAccessibleClass Dereference(this GtkFileChooserWidgetAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFileChooserWidgetAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkFileChooserWidgetAccessibleClassExterns
{
}


public struct GtkFileChooserWidgetAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
