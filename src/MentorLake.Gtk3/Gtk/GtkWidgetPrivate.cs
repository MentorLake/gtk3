namespace MentorLake.Gtk;

public class GtkWidgetPrivateHandle : BaseSafeHandle
{
}


public static class GtkWidgetPrivateExtensions
{

	public static GtkWidgetPrivate Dereference(this GtkWidgetPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWidgetPrivate>(x.DangerousGetHandle());
}
internal class GtkWidgetPrivateExterns
{
}

public struct GtkWidgetPrivate
{
}
