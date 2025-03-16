namespace MentorLake.Gtk;

public class GtkFramePrivateHandle : BaseSafeHandle
{
}


public static class GtkFramePrivateExtensions
{

	public static GtkFramePrivate Dereference(this GtkFramePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFramePrivate>(x.DangerousGetHandle());
}
internal class GtkFramePrivateExterns
{
}

public struct GtkFramePrivate
{
}
