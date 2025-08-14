namespace MentorLake.Gtk;


public class GtkSizeGroupPrivateHandle : BaseSafeHandle
{
}


public static class GtkSizeGroupPrivateExtensions
{

	public static GtkSizeGroupPrivate Dereference(this GtkSizeGroupPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSizeGroupPrivate>(x.DangerousGetHandle());
}
internal class GtkSizeGroupPrivateExterns
{
}


public struct GtkSizeGroupPrivate
{
}
