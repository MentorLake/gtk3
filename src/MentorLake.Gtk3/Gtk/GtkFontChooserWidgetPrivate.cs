namespace MentorLake.Gtk;


public class GtkFontChooserWidgetPrivateHandle : BaseSafeHandle
{
}


public static class GtkFontChooserWidgetPrivateExtensions
{

	public static GtkFontChooserWidgetPrivate Dereference(this GtkFontChooserWidgetPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontChooserWidgetPrivate>(x.DangerousGetHandle());
}
internal class GtkFontChooserWidgetPrivateExterns
{
}


public struct GtkFontChooserWidgetPrivate
{
}
