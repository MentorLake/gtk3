namespace MentorLake.Gtk;

public class GtkSpinnerPrivateHandle : BaseSafeHandle
{
}


public static class GtkSpinnerPrivateExtensions
{

	public static GtkSpinnerPrivate Dereference(this GtkSpinnerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSpinnerPrivate>(x.DangerousGetHandle());
}
internal class GtkSpinnerPrivateExterns
{
}

public struct GtkSpinnerPrivate
{
}
