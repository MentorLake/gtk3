namespace MentorLake.Gtk;

public class GtkMiscPrivateHandle : BaseSafeHandle
{
}


public static class GtkMiscPrivateExtensions
{

	public static GtkMiscPrivate Dereference(this GtkMiscPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMiscPrivate>(x.DangerousGetHandle());
}
internal class GtkMiscPrivateExterns
{
}

public struct GtkMiscPrivate
{
}
