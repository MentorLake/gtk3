namespace MentorLake.Gtk3.Gtk3;

public class GtkBoxHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkBoxHandle New(GtkOrientation orientation, int spacing)
	{
		return GtkBoxExterns.gtk_box_new(orientation, spacing);
	}

}

public static class GtkBoxHandleExtensions
{
	public static GtkBaselinePosition GetBaselinePosition(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_baseline_position(box);
	}

	public static GtkWidgetHandle GetCenterWidget(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_center_widget(box);
	}

	public static bool GetHomogeneous(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_homogeneous(box);
	}

	public static int GetSpacing(this GtkBoxHandle box)
	{
		return GtkBoxExterns.gtk_box_get_spacing(box);
	}

	public static GtkBoxHandle PackEnd(this GtkBoxHandle box, GtkWidgetHandle child, bool expand, bool fill, uint padding)
	{
		GtkBoxExterns.gtk_box_pack_end(box, child, expand, fill, padding);
		return box;
	}

	public static GtkBoxHandle PackStart(this GtkBoxHandle box, GtkWidgetHandle child, bool expand, bool fill, uint padding)
	{
		GtkBoxExterns.gtk_box_pack_start(box, child, expand, fill, padding);
		return box;
	}

	public static GtkBoxHandle QueryChildPacking(this GtkBoxHandle box, GtkWidgetHandle child, out bool expand, out bool fill, out uint padding, out GtkPackType pack_type)
	{
		GtkBoxExterns.gtk_box_query_child_packing(box, child, out expand, out fill, out padding, out pack_type);
		return box;
	}

	public static GtkBoxHandle ReorderChild(this GtkBoxHandle box, GtkWidgetHandle child, int position)
	{
		GtkBoxExterns.gtk_box_reorder_child(box, child, position);
		return box;
	}

	public static GtkBoxHandle SetBaselinePosition(this GtkBoxHandle box, GtkBaselinePosition position)
	{
		GtkBoxExterns.gtk_box_set_baseline_position(box, position);
		return box;
	}

	public static GtkBoxHandle SetCenterWidget(this GtkBoxHandle box, GtkWidgetHandle widget)
	{
		GtkBoxExterns.gtk_box_set_center_widget(box, widget);
		return box;
	}

	public static GtkBoxHandle SetChildPacking(this GtkBoxHandle box, GtkWidgetHandle child, bool expand, bool fill, uint padding, GtkPackType pack_type)
	{
		GtkBoxExterns.gtk_box_set_child_packing(box, child, expand, fill, padding, pack_type);
		return box;
	}

	public static GtkBoxHandle SetHomogeneous(this GtkBoxHandle box, bool homogeneous)
	{
		GtkBoxExterns.gtk_box_set_homogeneous(box, homogeneous);
		return box;
	}

	public static GtkBoxHandle SetSpacing(this GtkBoxHandle box, int spacing)
	{
		GtkBoxExterns.gtk_box_set_spacing(box, spacing);
		return box;
	}

}

internal class GtkBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBoxHandle gtk_box_new(GtkOrientation orientation, int spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBaselinePosition gtk_box_get_baseline_position(GtkBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_box_get_center_widget(GtkBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_box_get_homogeneous(GtkBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_box_get_spacing(GtkBoxHandle box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_box_pack_end(GtkBoxHandle box, GtkWidgetHandle child, bool expand, bool fill, uint padding);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_box_pack_start(GtkBoxHandle box, GtkWidgetHandle child, bool expand, bool fill, uint padding);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_box_query_child_packing(GtkBoxHandle box, GtkWidgetHandle child, out bool expand, out bool fill, out uint padding, out GtkPackType pack_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_box_reorder_child(GtkBoxHandle box, GtkWidgetHandle child, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_box_set_baseline_position(GtkBoxHandle box, GtkBaselinePosition position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_box_set_center_widget(GtkBoxHandle box, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_box_set_child_packing(GtkBoxHandle box, GtkWidgetHandle child, bool expand, bool fill, uint padding, GtkPackType pack_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_box_set_homogeneous(GtkBoxHandle box, bool homogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_box_set_spacing(GtkBoxHandle box, int spacing);

}
