namespace MentorLake.Gtk;


public class GtkAccelLabelPrivateHandle : BaseSafeHandle
{
}


public static class GtkAccelLabelPrivateExtensions
{

	public static GtkAccelLabelPrivate Dereference(this GtkAccelLabelPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAccelLabelPrivate>(x.DangerousGetHandle());
}
internal class GtkAccelLabelPrivateExterns
{
}


public struct GtkAccelLabelPrivate
{
}
