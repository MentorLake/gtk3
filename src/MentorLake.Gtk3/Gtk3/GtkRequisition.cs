namespace MentorLake.Gtk3.Gtk3;

public class GtkRequisitionHandle : BaseSafeHandle
{
	public static GtkRequisitionHandle New()
	{
		return GtkRequisitionExterns.gtk_requisition_new();
	}

}


public static class GtkRequisitionHandleExtensions
{
	public static GtkRequisitionHandle Copy(this GtkRequisitionHandle requisition)
	{
		return GtkRequisitionExterns.gtk_requisition_copy(requisition);
	}

	public static T Free<T>(this T requisition) where T : GtkRequisitionHandle
	{
		GtkRequisitionExterns.gtk_requisition_free(requisition);
		return requisition;
	}

}
internal class GtkRequisitionExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRequisitionHandle gtk_requisition_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRequisitionHandle gtk_requisition_copy(GtkRequisitionHandle requisition);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_requisition_free(GtkRequisitionHandle requisition);

}

public struct GtkRequisition
{
	public int width;
	public int height;
}
