namespace MentorLake.Gtk;

public class GtkContainerCellAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkContainerCellAccessiblePrivateExtensions
{

	public static GtkContainerCellAccessiblePrivate Dereference(this GtkContainerCellAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkContainerCellAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkContainerCellAccessiblePrivateExterns
{
}

public struct GtkContainerCellAccessiblePrivate
{
}
