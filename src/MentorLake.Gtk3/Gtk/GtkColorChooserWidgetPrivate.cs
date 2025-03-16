namespace MentorLake.Gtk;

public class GtkColorChooserWidgetPrivateHandle : BaseSafeHandle
{
}


public static class GtkColorChooserWidgetPrivateExtensions
{

	public static GtkColorChooserWidgetPrivate Dereference(this GtkColorChooserWidgetPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorChooserWidgetPrivate>(x.DangerousGetHandle());
}
internal class GtkColorChooserWidgetPrivateExterns
{
}

public struct GtkColorChooserWidgetPrivate
{
}
