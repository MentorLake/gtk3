namespace MentorLake.Gtk;


public class GtkColorSelectionPrivateHandle : BaseSafeHandle
{
}


public static class GtkColorSelectionPrivateExtensions
{

	public static GtkColorSelectionPrivate Dereference(this GtkColorSelectionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorSelectionPrivate>(x.DangerousGetHandle());
}
internal class GtkColorSelectionPrivateExterns
{
}


public struct GtkColorSelectionPrivate
{
}
