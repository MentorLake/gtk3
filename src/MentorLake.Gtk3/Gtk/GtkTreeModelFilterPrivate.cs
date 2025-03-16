namespace MentorLake.Gtk;

public class GtkTreeModelFilterPrivateHandle : BaseSafeHandle
{
}


public static class GtkTreeModelFilterPrivateExtensions
{

	public static GtkTreeModelFilterPrivate Dereference(this GtkTreeModelFilterPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeModelFilterPrivate>(x.DangerousGetHandle());
}
internal class GtkTreeModelFilterPrivateExterns
{
}

public struct GtkTreeModelFilterPrivate
{
}
