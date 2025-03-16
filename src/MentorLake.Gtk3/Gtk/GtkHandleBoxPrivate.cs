namespace MentorLake.Gtk;

public class GtkHandleBoxPrivateHandle : BaseSafeHandle
{
}


public static class GtkHandleBoxPrivateExtensions
{

	public static GtkHandleBoxPrivate Dereference(this GtkHandleBoxPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkHandleBoxPrivate>(x.DangerousGetHandle());
}
internal class GtkHandleBoxPrivateExterns
{
}

public struct GtkHandleBoxPrivate
{
}
