namespace MentorLake.Gtk;

public interface GtkScrollableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkScrollableHandleImpl : BaseSafeHandle, GtkScrollableHandle
{
}

public static class GtkScrollableHandleExtensions
{
	public static bool GetBorder(this MentorLake.Gtk.GtkScrollableHandle scrollable, out MentorLake.Gtk.GtkBorder border)
	{
		if (scrollable.IsInvalid || scrollable.IsClosed) throw new Exception("Invalid or closed handle (GtkScrollableHandle)");
		return GtkScrollableHandleExterns.gtk_scrollable_get_border(scrollable, out border);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkScrollableHandle scrollable)
	{
		if (scrollable.IsInvalid || scrollable.IsClosed) throw new Exception("Invalid or closed handle (GtkScrollableHandle)");
		return GtkScrollableHandleExterns.gtk_scrollable_get_hadjustment(scrollable);
	}

	public static MentorLake.Gtk.GtkScrollablePolicy GetHscrollPolicy(this MentorLake.Gtk.GtkScrollableHandle scrollable)
	{
		if (scrollable.IsInvalid || scrollable.IsClosed) throw new Exception("Invalid or closed handle (GtkScrollableHandle)");
		return GtkScrollableHandleExterns.gtk_scrollable_get_hscroll_policy(scrollable);
	}

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkScrollableHandle scrollable)
	{
		if (scrollable.IsInvalid || scrollable.IsClosed) throw new Exception("Invalid or closed handle (GtkScrollableHandle)");
		return GtkScrollableHandleExterns.gtk_scrollable_get_vadjustment(scrollable);
	}

	public static MentorLake.Gtk.GtkScrollablePolicy GetVscrollPolicy(this MentorLake.Gtk.GtkScrollableHandle scrollable)
	{
		if (scrollable.IsInvalid || scrollable.IsClosed) throw new Exception("Invalid or closed handle (GtkScrollableHandle)");
		return GtkScrollableHandleExterns.gtk_scrollable_get_vscroll_policy(scrollable);
	}

	public static T SetHadjustment<T>(this T scrollable, MentorLake.Gtk.GtkAdjustmentHandle hadjustment) where T : GtkScrollableHandle
	{
		if (scrollable.IsInvalid || scrollable.IsClosed) throw new Exception("Invalid or closed handle (GtkScrollableHandle)");
		GtkScrollableHandleExterns.gtk_scrollable_set_hadjustment(scrollable, hadjustment);
		return scrollable;
	}

	public static T SetHscrollPolicy<T>(this T scrollable, MentorLake.Gtk.GtkScrollablePolicy policy) where T : GtkScrollableHandle
	{
		if (scrollable.IsInvalid || scrollable.IsClosed) throw new Exception("Invalid or closed handle (GtkScrollableHandle)");
		GtkScrollableHandleExterns.gtk_scrollable_set_hscroll_policy(scrollable, policy);
		return scrollable;
	}

	public static T SetVadjustment<T>(this T scrollable, MentorLake.Gtk.GtkAdjustmentHandle vadjustment) where T : GtkScrollableHandle
	{
		if (scrollable.IsInvalid || scrollable.IsClosed) throw new Exception("Invalid or closed handle (GtkScrollableHandle)");
		GtkScrollableHandleExterns.gtk_scrollable_set_vadjustment(scrollable, vadjustment);
		return scrollable;
	}

	public static T SetVscrollPolicy<T>(this T scrollable, MentorLake.Gtk.GtkScrollablePolicy policy) where T : GtkScrollableHandle
	{
		if (scrollable.IsInvalid || scrollable.IsClosed) throw new Exception("Invalid or closed handle (GtkScrollableHandle)");
		GtkScrollableHandleExterns.gtk_scrollable_set_vscroll_policy(scrollable, policy);
		return scrollable;
	}

}

internal class GtkScrollableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrollable_get_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable, out MentorLake.Gtk.GtkBorder border);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_scrollable_get_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkScrollablePolicy gtk_scrollable_get_hscroll_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_scrollable_get_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkScrollablePolicy gtk_scrollable_get_vscroll_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrollable_set_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle hadjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrollable_set_hscroll_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable, MentorLake.Gtk.GtkScrollablePolicy policy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrollable_set_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle vadjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrollable_set_vscroll_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrollableHandleImpl>))] MentorLake.Gtk.GtkScrollableHandle scrollable, MentorLake.Gtk.GtkScrollablePolicy policy);

}
