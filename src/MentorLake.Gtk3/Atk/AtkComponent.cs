namespace MentorLake.Gtk3.Atk;

public interface AtkComponentHandle
{
}

internal class AtkComponentHandleImpl : BaseSafeHandle, AtkComponentHandle
{
}

public static class AtkComponentHandleExtensions
{
	public static uint AddFocusHandler(this AtkComponentHandle component, AtkFocusHandler handler)
	{
		return AtkComponentExterns.atk_component_add_focus_handler(component, handler);
	}

	public static bool Contains(this AtkComponentHandle component, int x, int y, AtkCoordType coord_type)
	{
		return AtkComponentExterns.atk_component_contains(component, x, y, coord_type);
	}

	public static double GetAlpha(this AtkComponentHandle component)
	{
		return AtkComponentExterns.atk_component_get_alpha(component);
	}

	public static AtkComponentHandle GetExtents(this AtkComponentHandle component, out int x, out int y, out int width, out int height, AtkCoordType coord_type)
	{
		AtkComponentExterns.atk_component_get_extents(component, out x, out y, out width, out height, coord_type);
		return component;
	}

	public static AtkLayer GetLayer(this AtkComponentHandle component)
	{
		return AtkComponentExterns.atk_component_get_layer(component);
	}

	public static int GetMdiZorder(this AtkComponentHandle component)
	{
		return AtkComponentExterns.atk_component_get_mdi_zorder(component);
	}

	public static AtkComponentHandle GetPosition(this AtkComponentHandle component, out int x, out int y, AtkCoordType coord_type)
	{
		AtkComponentExterns.atk_component_get_position(component, out x, out y, coord_type);
		return component;
	}

	public static AtkComponentHandle GetSize(this AtkComponentHandle component, out int width, out int height)
	{
		AtkComponentExterns.atk_component_get_size(component, out width, out height);
		return component;
	}

	public static bool GrabFocus(this AtkComponentHandle component)
	{
		return AtkComponentExterns.atk_component_grab_focus(component);
	}

	public static AtkObjectHandle RefAccessibleAtPoint(this AtkComponentHandle component, int x, int y, AtkCoordType coord_type)
	{
		return AtkComponentExterns.atk_component_ref_accessible_at_point(component, x, y, coord_type);
	}

	public static AtkComponentHandle RemoveFocusHandler(this AtkComponentHandle component, uint handler_id)
	{
		AtkComponentExterns.atk_component_remove_focus_handler(component, handler_id);
		return component;
	}

	public static bool ScrollTo(this AtkComponentHandle component, AtkScrollType type)
	{
		return AtkComponentExterns.atk_component_scroll_to(component, type);
	}

	public static bool ScrollToPoint(this AtkComponentHandle component, AtkCoordType coords, int x, int y)
	{
		return AtkComponentExterns.atk_component_scroll_to_point(component, coords, x, y);
	}

	public static bool SetExtents(this AtkComponentHandle component, int x, int y, int width, int height, AtkCoordType coord_type)
	{
		return AtkComponentExterns.atk_component_set_extents(component, x, y, width, height, coord_type);
	}

	public static bool SetPosition(this AtkComponentHandle component, int x, int y, AtkCoordType coord_type)
	{
		return AtkComponentExterns.atk_component_set_position(component, x, y, coord_type);
	}

	public static bool SetSize(this AtkComponentHandle component, int width, int height)
	{
		return AtkComponentExterns.atk_component_set_size(component, width, height);
	}

}

internal class AtkComponentExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern uint atk_component_add_focus_handler(AtkComponentHandle component, AtkFocusHandler handler);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_component_contains(AtkComponentHandle component, int x, int y, AtkCoordType coord_type);

	[DllImport(Libraries.Atk)]
	internal static extern double atk_component_get_alpha(AtkComponentHandle component);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_component_get_extents(AtkComponentHandle component, out int x, out int y, out int width, out int height, AtkCoordType coord_type);

	[DllImport(Libraries.Atk)]
	internal static extern AtkLayer atk_component_get_layer(AtkComponentHandle component);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_component_get_mdi_zorder(AtkComponentHandle component);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_component_get_position(AtkComponentHandle component, out int x, out int y, AtkCoordType coord_type);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_component_get_size(AtkComponentHandle component, out int width, out int height);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_component_grab_focus(AtkComponentHandle component);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_component_ref_accessible_at_point(AtkComponentHandle component, int x, int y, AtkCoordType coord_type);

	[DllImport(Libraries.Atk)]
	internal static extern void atk_component_remove_focus_handler(AtkComponentHandle component, uint handler_id);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_component_scroll_to(AtkComponentHandle component, AtkScrollType type);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_component_scroll_to_point(AtkComponentHandle component, AtkCoordType coords, int x, int y);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_component_set_extents(AtkComponentHandle component, int x, int y, int width, int height, AtkCoordType coord_type);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_component_set_position(AtkComponentHandle component, int x, int y, AtkCoordType coord_type);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_component_set_size(AtkComponentHandle component, int width, int height);

}
