namespace MentorLake.Gtk;

public class GtkLevelBarAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkLevelBarAccessiblePrivateExtensions
{

	public static GtkLevelBarAccessiblePrivate Dereference(this GtkLevelBarAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLevelBarAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkLevelBarAccessiblePrivateExterns
{
}

public struct GtkLevelBarAccessiblePrivate
{
}
