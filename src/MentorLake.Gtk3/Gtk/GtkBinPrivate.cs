namespace MentorLake.Gtk;

public class GtkBinPrivateHandle : BaseSafeHandle
{
}


public static class GtkBinPrivateExtensions
{

	public static GtkBinPrivate Dereference(this GtkBinPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBinPrivate>(x.DangerousGetHandle());
}
internal class GtkBinPrivateExterns
{
}

public struct GtkBinPrivate
{
}
