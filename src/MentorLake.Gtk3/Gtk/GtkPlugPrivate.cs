namespace MentorLake.Gtk;

public class GtkPlugPrivateHandle : BaseSafeHandle
{
}


public static class GtkPlugPrivateExtensions
{

	public static GtkPlugPrivate Dereference(this GtkPlugPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPlugPrivate>(x.DangerousGetHandle());
}
internal class GtkPlugPrivateExterns
{
}

public struct GtkPlugPrivate
{
}
