namespace MentorLake.Gtk;

public class GtkProgressBarAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkProgressBarAccessiblePrivateExtensions
{

	public static GtkProgressBarAccessiblePrivate Dereference(this GtkProgressBarAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkProgressBarAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkProgressBarAccessiblePrivateExterns
{
}

public struct GtkProgressBarAccessiblePrivate
{
}
