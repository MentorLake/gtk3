namespace MentorLake.Gtk;

public class GtkCalendarPrivateHandle : BaseSafeHandle
{
}


public static class GtkCalendarPrivateExtensions
{

	public static GtkCalendarPrivate Dereference(this GtkCalendarPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCalendarPrivate>(x.DangerousGetHandle());
}
internal class GtkCalendarPrivateExterns
{
}

public struct GtkCalendarPrivate
{
}
