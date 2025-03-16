namespace MentorLake.Gtk;

[Flags]
public enum GtkRegionFlags : long
{
	GTK_REGION_EVEN = 1,
	GTK_REGION_ODD = 2,
	GTK_REGION_FIRST = 4,
	GTK_REGION_LAST = 8,
	GTK_REGION_ONLY = 16,
	GTK_REGION_SORTED = 32
}
