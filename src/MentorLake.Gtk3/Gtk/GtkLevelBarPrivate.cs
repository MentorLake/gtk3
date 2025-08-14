namespace MentorLake.Gtk;


public class GtkLevelBarPrivateHandle : BaseSafeHandle
{
}


public static class GtkLevelBarPrivateExtensions
{

	public static GtkLevelBarPrivate Dereference(this GtkLevelBarPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLevelBarPrivate>(x.DangerousGetHandle());
}
internal class GtkLevelBarPrivateExterns
{
}


public struct GtkLevelBarPrivate
{
}
