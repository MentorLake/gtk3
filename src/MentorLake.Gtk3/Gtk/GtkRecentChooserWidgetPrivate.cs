namespace MentorLake.Gtk;

public class GtkRecentChooserWidgetPrivateHandle : BaseSafeHandle
{
}


public static class GtkRecentChooserWidgetPrivateExtensions
{

	public static GtkRecentChooserWidgetPrivate Dereference(this GtkRecentChooserWidgetPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentChooserWidgetPrivate>(x.DangerousGetHandle());
}
internal class GtkRecentChooserWidgetPrivateExterns
{
}

public struct GtkRecentChooserWidgetPrivate
{
}
