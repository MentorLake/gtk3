namespace MentorLake.Gtk;

public class GtkCellAreaContextHandle : GObjectHandle
{
}

public static class GtkCellAreaContextHandleExtensions
{
	public static T Allocate<T>(this T context, int width, int height) where T : GtkCellAreaContextHandle
	{
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_allocate(context, width, height);
		return context;
	}

	public static T GetAllocation<T>(this T context, out int width, out int height) where T : GtkCellAreaContextHandle
	{
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_allocation(context, out width, out height);
		return context;
	}

	public static MentorLake.Gtk.GtkCellAreaHandle GetArea(this MentorLake.Gtk.GtkCellAreaContextHandle context)
	{
		return GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_area(context);
	}

	public static T GetPreferredHeight<T>(this T context, out int minimum_height, out int natural_height) where T : GtkCellAreaContextHandle
	{
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_preferred_height(context, out minimum_height, out natural_height);
		return context;
	}

	public static T GetPreferredHeightForWidth<T>(this T context, int width, out int minimum_height, out int natural_height) where T : GtkCellAreaContextHandle
	{
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_preferred_height_for_width(context, width, out minimum_height, out natural_height);
		return context;
	}

	public static T GetPreferredWidth<T>(this T context, out int minimum_width, out int natural_width) where T : GtkCellAreaContextHandle
	{
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_preferred_width(context, out minimum_width, out natural_width);
		return context;
	}

	public static T GetPreferredWidthForHeight<T>(this T context, int height, out int minimum_width, out int natural_width) where T : GtkCellAreaContextHandle
	{
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_get_preferred_width_for_height(context, height, out minimum_width, out natural_width);
		return context;
	}

	public static T PushPreferredHeight<T>(this T context, int minimum_height, int natural_height) where T : GtkCellAreaContextHandle
	{
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_push_preferred_height(context, minimum_height, natural_height);
		return context;
	}

	public static T PushPreferredWidth<T>(this T context, int minimum_width, int natural_width) where T : GtkCellAreaContextHandle
	{
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_push_preferred_width(context, minimum_width, natural_width);
		return context;
	}

	public static T Reset<T>(this T context) where T : GtkCellAreaContextHandle
	{
		GtkCellAreaContextHandleExterns.gtk_cell_area_context_reset(context);
		return context;
	}

}

internal class GtkCellAreaContextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_get_allocation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellAreaHandle gtk_cell_area_context_get_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_get_preferred_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_get_preferred_height_for_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, int width, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_get_preferred_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_get_preferred_width_for_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, int height, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_push_preferred_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, int minimum_height, int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_push_preferred_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context, int minimum_width, int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_area_context_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context);

}
