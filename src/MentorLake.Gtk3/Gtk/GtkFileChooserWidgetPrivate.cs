namespace MentorLake.Gtk;


public class GtkFileChooserWidgetPrivateHandle : BaseSafeHandle
{
}


public static class GtkFileChooserWidgetPrivateExtensions
{

	public static GtkFileChooserWidgetPrivate Dereference(this GtkFileChooserWidgetPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFileChooserWidgetPrivate>(x.DangerousGetHandle());
}
internal class GtkFileChooserWidgetPrivateExterns
{
}


public struct GtkFileChooserWidgetPrivate
{
}
