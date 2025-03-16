namespace MentorLake.Gtk;

public class GtkImageCellAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkImageCellAccessiblePrivateExtensions
{

	public static GtkImageCellAccessiblePrivate Dereference(this GtkImageCellAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkImageCellAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkImageCellAccessiblePrivateExterns
{
}

public struct GtkImageCellAccessiblePrivate
{
}
