namespace MentorLake.Gtk;

public class GtkRecentManagerPrivateHandle : BaseSafeHandle
{
}


public static class GtkRecentManagerPrivateExtensions
{

	public static GtkRecentManagerPrivate Dereference(this GtkRecentManagerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentManagerPrivate>(x.DangerousGetHandle());
}
internal class GtkRecentManagerPrivateExterns
{
}

public struct GtkRecentManagerPrivate
{
}
