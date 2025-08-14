namespace MentorLake.Gtk;


public class GtkAppChooserWidgetPrivateHandle : BaseSafeHandle
{
}


public static class GtkAppChooserWidgetPrivateExtensions
{

	public static GtkAppChooserWidgetPrivate Dereference(this GtkAppChooserWidgetPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAppChooserWidgetPrivate>(x.DangerousGetHandle());
}
internal class GtkAppChooserWidgetPrivateExterns
{
}


public struct GtkAppChooserWidgetPrivate
{
}
