namespace MentorLake.Gtk;


public class GtkEntryBufferPrivateHandle : BaseSafeHandle
{
}


public static class GtkEntryBufferPrivateExtensions
{

	public static GtkEntryBufferPrivate Dereference(this GtkEntryBufferPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEntryBufferPrivate>(x.DangerousGetHandle());
}
internal class GtkEntryBufferPrivateExterns
{
}


public struct GtkEntryBufferPrivate
{
}
