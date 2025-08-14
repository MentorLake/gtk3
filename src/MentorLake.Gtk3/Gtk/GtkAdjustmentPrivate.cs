namespace MentorLake.Gtk;


public class GtkAdjustmentPrivateHandle : BaseSafeHandle
{
}


public static class GtkAdjustmentPrivateExtensions
{

	public static GtkAdjustmentPrivate Dereference(this GtkAdjustmentPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAdjustmentPrivate>(x.DangerousGetHandle());
}
internal class GtkAdjustmentPrivateExterns
{
}


public struct GtkAdjustmentPrivate
{
}
