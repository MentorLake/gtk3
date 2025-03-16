namespace MentorLake.Gtk;

public class GtkWindowGroupPrivateHandle : BaseSafeHandle
{
}


public static class GtkWindowGroupPrivateExtensions
{

	public static GtkWindowGroupPrivate Dereference(this GtkWindowGroupPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWindowGroupPrivate>(x.DangerousGetHandle());
}
internal class GtkWindowGroupPrivateExterns
{
}

public struct GtkWindowGroupPrivate
{
}
