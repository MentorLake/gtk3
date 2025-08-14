namespace MentorLake.Gtk;


public class GtkInfoBarPrivateHandle : BaseSafeHandle
{
}


public static class GtkInfoBarPrivateExtensions
{

	public static GtkInfoBarPrivate Dereference(this GtkInfoBarPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkInfoBarPrivate>(x.DangerousGetHandle());
}
internal class GtkInfoBarPrivateExterns
{
}


public struct GtkInfoBarPrivate
{
}
