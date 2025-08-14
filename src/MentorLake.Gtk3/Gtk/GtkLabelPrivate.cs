namespace MentorLake.Gtk;


public class GtkLabelPrivateHandle : BaseSafeHandle
{
}


public static class GtkLabelPrivateExtensions
{

	public static GtkLabelPrivate Dereference(this GtkLabelPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLabelPrivate>(x.DangerousGetHandle());
}
internal class GtkLabelPrivateExterns
{
}


public struct GtkLabelPrivate
{
}
