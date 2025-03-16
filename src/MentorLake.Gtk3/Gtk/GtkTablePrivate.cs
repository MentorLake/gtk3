namespace MentorLake.Gtk;

public class GtkTablePrivateHandle : BaseSafeHandle
{
}


public static class GtkTablePrivateExtensions
{

	public static GtkTablePrivate Dereference(this GtkTablePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTablePrivate>(x.DangerousGetHandle());
}
internal class GtkTablePrivateExterns
{
}

public struct GtkTablePrivate
{
}
