namespace MentorLake.Gtk;


public class GtkImagePrivateHandle : BaseSafeHandle
{
}


public static class GtkImagePrivateExtensions
{

	public static GtkImagePrivate Dereference(this GtkImagePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkImagePrivate>(x.DangerousGetHandle());
}
internal class GtkImagePrivateExterns
{
}


public struct GtkImagePrivate
{
}
