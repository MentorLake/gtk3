namespace MentorLake.Gtk;


public class GtkStatusbarPrivateHandle : BaseSafeHandle
{
}


public static class GtkStatusbarPrivateExtensions
{

	public static GtkStatusbarPrivate Dereference(this GtkStatusbarPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkStatusbarPrivate>(x.DangerousGetHandle());
}
internal class GtkStatusbarPrivateExterns
{
}


public struct GtkStatusbarPrivate
{
}
