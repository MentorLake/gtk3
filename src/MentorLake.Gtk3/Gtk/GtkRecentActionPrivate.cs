namespace MentorLake.Gtk;

public class GtkRecentActionPrivateHandle : BaseSafeHandle
{
}


public static class GtkRecentActionPrivateExtensions
{

	public static GtkRecentActionPrivate Dereference(this GtkRecentActionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentActionPrivate>(x.DangerousGetHandle());
}
internal class GtkRecentActionPrivateExterns
{
}

public struct GtkRecentActionPrivate
{
}
