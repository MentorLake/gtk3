namespace MentorLake.Gtk;

[Flags]
public enum GtkTreeViewDropPosition
{
	GTK_TREE_VIEW_DROP_BEFORE = 0,
	GTK_TREE_VIEW_DROP_AFTER = 1,
	GTK_TREE_VIEW_DROP_INTO_OR_BEFORE = 2,
	GTK_TREE_VIEW_DROP_INTO_OR_AFTER = 3
}
