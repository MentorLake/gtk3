namespace MentorLake.Gtk3.Gtk3;

public class GtkContainerCellAccessibleHandle : GtkCellAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkTableCellHandle
{
	public static GtkContainerCellAccessibleHandle New()
	{
		return GtkContainerCellAccessibleExterns.gtk_container_cell_accessible_new();
	}

}

public static class GtkContainerCellAccessibleHandleExtensions
{
	public static GtkContainerCellAccessibleHandle AddChild(this GtkContainerCellAccessibleHandle container, GtkCellAccessibleHandle child)
	{
		GtkContainerCellAccessibleExterns.gtk_container_cell_accessible_add_child(container, child);
		return container;
	}

	public static GListHandle GetChildren(this GtkContainerCellAccessibleHandle container)
	{
		return GtkContainerCellAccessibleExterns.gtk_container_cell_accessible_get_children(container);
	}

	public static GtkContainerCellAccessibleHandle RemoveChild(this GtkContainerCellAccessibleHandle container, GtkCellAccessibleHandle child)
	{
		GtkContainerCellAccessibleExterns.gtk_container_cell_accessible_remove_child(container, child);
		return container;
	}

}

internal class GtkContainerCellAccessibleExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkContainerCellAccessibleHandle gtk_container_cell_accessible_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_cell_accessible_add_child(GtkContainerCellAccessibleHandle container, GtkCellAccessibleHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_container_cell_accessible_get_children(GtkContainerCellAccessibleHandle container);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_container_cell_accessible_remove_child(GtkContainerCellAccessibleHandle container, GtkCellAccessibleHandle child);

}
