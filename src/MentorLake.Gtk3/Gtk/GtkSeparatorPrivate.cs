namespace MentorLake.Gtk;


public class GtkSeparatorPrivateHandle : BaseSafeHandle
{
}


public static class GtkSeparatorPrivateExtensions
{

	public static GtkSeparatorPrivate Dereference(this GtkSeparatorPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSeparatorPrivate>(x.DangerousGetHandle());
}
internal class GtkSeparatorPrivateExterns
{
}


public struct GtkSeparatorPrivate
{
}
