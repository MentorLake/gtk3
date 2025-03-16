namespace MentorLake.Gtk;

public class GtkTextBufferPrivateHandle : BaseSafeHandle
{
}


public static class GtkTextBufferPrivateExtensions
{

	public static GtkTextBufferPrivate Dereference(this GtkTextBufferPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextBufferPrivate>(x.DangerousGetHandle());
}
internal class GtkTextBufferPrivateExterns
{
}

public struct GtkTextBufferPrivate
{
}
