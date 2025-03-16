namespace MentorLake.Gtk;

public class GtkImageCellAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkImageCellAccessibleClassExtensions
{

	public static GtkImageCellAccessibleClass Dereference(this GtkImageCellAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkImageCellAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkImageCellAccessibleClassExterns
{
}

public struct GtkImageCellAccessibleClass
{
	public GtkRendererCellAccessibleClass parent_class;
}
