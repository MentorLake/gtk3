namespace MentorLake.Gtk;

public class GtkProgressBarPrivateHandle : BaseSafeHandle
{
}


public static class GtkProgressBarPrivateExtensions
{

	public static GtkProgressBarPrivate Dereference(this GtkProgressBarPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkProgressBarPrivate>(x.DangerousGetHandle());
}
internal class GtkProgressBarPrivateExterns
{
}

public struct GtkProgressBarPrivate
{
}
