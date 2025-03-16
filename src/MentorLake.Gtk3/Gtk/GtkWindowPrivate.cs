namespace MentorLake.Gtk;

public class GtkWindowPrivateHandle : BaseSafeHandle
{
}


public static class GtkWindowPrivateExtensions
{

	public static GtkWindowPrivate Dereference(this GtkWindowPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWindowPrivate>(x.DangerousGetHandle());
}
internal class GtkWindowPrivateExterns
{
}

public struct GtkWindowPrivate
{
}
