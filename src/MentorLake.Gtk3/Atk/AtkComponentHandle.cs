namespace MentorLake.Atk;

public interface AtkComponentHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkComponentHandleImpl : BaseSafeHandle, AtkComponentHandle
{
}

public static class AtkComponentHandleExtensions
{
	public static uint AddFocusHandler(this MentorLake.Atk.AtkComponentHandle component, MentorLake.Atk.AtkFocusHandler handler)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_add_focus_handler(component, handler);
	}

	public static bool Contains(this MentorLake.Atk.AtkComponentHandle component, int x, int y, MentorLake.Atk.AtkCoordType coord_type)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_contains(component, x, y, coord_type);
	}

	public static double GetAlpha(this MentorLake.Atk.AtkComponentHandle component)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_get_alpha(component);
	}

	public static T GetExtents<T>(this T component, out int x, out int y, out int width, out int height, MentorLake.Atk.AtkCoordType coord_type) where T : AtkComponentHandle
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		AtkComponentHandleExterns.atk_component_get_extents(component, out x, out y, out width, out height, coord_type);
		return component;
	}

	public static MentorLake.Atk.AtkLayer GetLayer(this MentorLake.Atk.AtkComponentHandle component)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_get_layer(component);
	}

	public static int GetMdiZorder(this MentorLake.Atk.AtkComponentHandle component)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_get_mdi_zorder(component);
	}

	public static T GetPosition<T>(this T component, out int x, out int y, MentorLake.Atk.AtkCoordType coord_type) where T : AtkComponentHandle
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		AtkComponentHandleExterns.atk_component_get_position(component, out x, out y, coord_type);
		return component;
	}

	public static T GetSize<T>(this T component, out int width, out int height) where T : AtkComponentHandle
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		AtkComponentHandleExterns.atk_component_get_size(component, out width, out height);
		return component;
	}

	public static bool GrabFocus(this MentorLake.Atk.AtkComponentHandle component)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_grab_focus(component);
	}

	public static MentorLake.Atk.AtkObjectHandle RefAccessibleAtPoint(this MentorLake.Atk.AtkComponentHandle component, int x, int y, MentorLake.Atk.AtkCoordType coord_type)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_ref_accessible_at_point(component, x, y, coord_type);
	}

	public static T RemoveFocusHandler<T>(this T component, uint handler_id) where T : AtkComponentHandle
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		AtkComponentHandleExterns.atk_component_remove_focus_handler(component, handler_id);
		return component;
	}

	public static bool ScrollTo(this MentorLake.Atk.AtkComponentHandle component, MentorLake.Atk.AtkScrollType type)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_scroll_to(component, type);
	}

	public static bool ScrollToPoint(this MentorLake.Atk.AtkComponentHandle component, MentorLake.Atk.AtkCoordType coords, int x, int y)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_scroll_to_point(component, coords, x, y);
	}

	public static bool SetExtents(this MentorLake.Atk.AtkComponentHandle component, int x, int y, int width, int height, MentorLake.Atk.AtkCoordType coord_type)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_set_extents(component, x, y, width, height, coord_type);
	}

	public static bool SetPosition(this MentorLake.Atk.AtkComponentHandle component, int x, int y, MentorLake.Atk.AtkCoordType coord_type)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_set_position(component, x, y, coord_type);
	}

	public static bool SetSize(this MentorLake.Atk.AtkComponentHandle component, int width, int height)
	{
		if (component.IsInvalid || component.IsClosed) throw new Exception("Invalid or closed handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_set_size(component, width, height);
	}

}

internal class AtkComponentHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern uint atk_component_add_focus_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, MentorLake.Atk.AtkFocusHandler handler);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_component_contains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, int x, int y, MentorLake.Atk.AtkCoordType coord_type);

	[DllImport(AtkLibrary.Name)]
	internal static extern double atk_component_get_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_component_get_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, out int x, out int y, out int width, out int height, MentorLake.Atk.AtkCoordType coord_type);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkLayer atk_component_get_layer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_component_get_mdi_zorder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_component_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, out int x, out int y, MentorLake.Atk.AtkCoordType coord_type);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_component_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, out int width, out int height);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_component_grab_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_component_ref_accessible_at_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, int x, int y, MentorLake.Atk.AtkCoordType coord_type);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_component_remove_focus_handler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, uint handler_id);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_component_scroll_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, MentorLake.Atk.AtkScrollType type);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_component_scroll_to_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, MentorLake.Atk.AtkCoordType coords, int x, int y);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_component_set_extents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, int x, int y, int width, int height, MentorLake.Atk.AtkCoordType coord_type);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_component_set_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, int x, int y, MentorLake.Atk.AtkCoordType coord_type);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_component_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle component, int width, int height);

}
