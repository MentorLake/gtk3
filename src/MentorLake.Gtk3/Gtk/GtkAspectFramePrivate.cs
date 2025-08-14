namespace MentorLake.Gtk;


public class GtkAspectFramePrivateHandle : BaseSafeHandle
{
}


public static class GtkAspectFramePrivateExtensions
{

	public static GtkAspectFramePrivate Dereference(this GtkAspectFramePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAspectFramePrivate>(x.DangerousGetHandle());
}
internal class GtkAspectFramePrivateExterns
{
}


public struct GtkAspectFramePrivate
{
}
