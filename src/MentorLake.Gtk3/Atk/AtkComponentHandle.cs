namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface provided by UI components
/// which occupy a physical area on the screen.
/// which the user can activate/interact with.
/// </para>
/// <para>
/// #AtkComponent should be implemented by most if not all UI elements
/// with an actual on-screen presence, i.e. components which can be
/// said to have a screen-coordinate bounding box.  Virtually all
/// widgets will need to have #AtkComponent implementations provided
/// for their corresponding #AtkObject class.  In short, only UI
/// elements which are *not* GUI elements will omit this ATK interface.
/// </para>
/// <para>
/// A possible exception might be textual information with a
/// transparent background, in which case text glyph bounding box
/// information is provided by #AtkText.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Add the specified handler to the set of functions to be called
/// when this object receives focus events (in or out). If the handler is
/// already added it is not added again
/// </para>
/// </summary>

/// <param name="component">
/// The #AtkComponent to attach the @handler to
/// </param>
/// <param name="handler">
/// The #AtkFocusHandler to be attached to @component
/// </param>
/// <return>
/// a handler id which can be used in atk_component_remove_focus_handler()
/// or zero if the handler was already added.
/// </return>

	public static uint AddFocusHandler(this MentorLake.Atk.AtkComponentHandle component, MentorLake.Atk.AtkFocusHandler handler)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_add_focus_handler(component, handler);
	}

/// <summary>
/// <para>
/// Checks whether the specified point is within the extent of the @component.
/// </para>
/// <para>
/// Toolkit implementor note: ATK provides a default implementation for
/// this virtual method. In general there are little reason to
/// re-implement it.
/// </para>
/// </summary>

/// <param name="component">
/// the #AtkComponent
/// </param>
/// <param name="x">
/// x coordinate
/// </param>
/// <param name="y">
/// y coordinate
/// </param>
/// <param name="coord_type">
/// specifies whether the coordinates are relative to the screen
/// or to the components top level window
/// </param>
/// <return>
/// %TRUE or %FALSE indicating whether the specified point is within
/// the extent of the @component or not
/// </return>

	public static bool Contains(this MentorLake.Atk.AtkComponentHandle component, int x, int y, MentorLake.Atk.AtkCoordType coord_type)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_contains(component, x, y, coord_type);
	}

/// <summary>
/// <para>
/// Returns the alpha value (i.e. the opacity) for this
/// @component, on a scale from 0 (fully transparent) to 1.0
/// (fully opaque).
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <return>
/// An alpha value from 0 to 1.0, inclusive.
/// </return>

	public static double GetAlpha(this MentorLake.Atk.AtkComponentHandle component)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_get_alpha(component);
	}

/// <summary>
/// <para>
/// Gets the rectangle which gives the extent of the @component.
/// </para>
/// <para>
/// If the extent can not be obtained (e.g. a non-embedded plug or missing
/// support), all of x, y, width, height are set to -1.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <param name="x">
/// address of #gint to put x coordinate
/// </param>
/// <param name="y">
/// address of #gint to put y coordinate
/// </param>
/// <param name="width">
/// address of #gint to put width
/// </param>
/// <param name="height">
/// address of #gint to put height
/// </param>
/// <param name="coord_type">
/// specifies whether the coordinates are relative to the screen
/// or to the components top level window
/// </param>

	public static T GetExtents<T>(this T component, out int x, out int y, out int width, out int height, MentorLake.Atk.AtkCoordType coord_type) where T : AtkComponentHandle
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		AtkComponentHandleExterns.atk_component_get_extents(component, out x, out y, out width, out height, coord_type);
		return component;
	}

/// <summary>
/// <para>
/// Gets the layer of the component.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <return>
/// an #AtkLayer which is the layer of the component
/// </return>

	public static MentorLake.Atk.AtkLayer GetLayer(this MentorLake.Atk.AtkComponentHandle component)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_get_layer(component);
	}

/// <summary>
/// <para>
/// Gets the zorder of the component. The value G_MININT will be returned
/// if the layer of the component is not ATK_LAYER_MDI or ATK_LAYER_WINDOW.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <return>
/// a gint which is the zorder of the component, i.e. the depth at
/// which the component is shown in relation to other components in the same
/// container.
/// </return>

	public static int GetMdiZorder(this MentorLake.Atk.AtkComponentHandle component)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_get_mdi_zorder(component);
	}

/// <summary>
/// <para>
/// Gets the position of @component in the form of
/// a point specifying @component's top-left corner.
/// </para>
/// <para>
/// If the position can not be obtained (e.g. a non-embedded plug or missing
/// support), x and y are set to -1.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <param name="x">
/// address of #gint to put x coordinate position
/// </param>
/// <param name="y">
/// address of #gint to put y coordinate position
/// </param>
/// <param name="coord_type">
/// specifies whether the coordinates are relative to the screen
/// or to the components top level window
/// </param>

	public static T GetPosition<T>(this T component, out int x, out int y, MentorLake.Atk.AtkCoordType coord_type) where T : AtkComponentHandle
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		AtkComponentHandleExterns.atk_component_get_position(component, out x, out y, coord_type);
		return component;
	}

/// <summary>
/// <para>
/// Gets the size of the @component in terms of width and height.
/// </para>
/// <para>
/// If the size can not be obtained (e.g. a non-embedded plug or missing
/// support), width and height are set to -1.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <param name="width">
/// address of #gint to put width of @component
/// </param>
/// <param name="height">
/// address of #gint to put height of @component
/// </param>

	public static T GetSize<T>(this T component, out int width, out int height) where T : AtkComponentHandle
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		AtkComponentHandleExterns.atk_component_get_size(component, out width, out height);
		return component;
	}

/// <summary>
/// <para>
/// Grabs focus for this @component.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <return>
/// %TRUE if successful, %FALSE otherwise.
/// </return>

	public static bool GrabFocus(this MentorLake.Atk.AtkComponentHandle component)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_grab_focus(component);
	}

/// <summary>
/// <para>
/// Gets a reference to the accessible child, if one exists, at the
/// coordinate point specified by @x and @y.
/// </para>
/// </summary>

/// <param name="component">
/// the #AtkComponent
/// </param>
/// <param name="x">
/// x coordinate
/// </param>
/// <param name="y">
/// y coordinate
/// </param>
/// <param name="coord_type">
/// specifies whether the coordinates are relative to the screen
/// or to the components top level window
/// </param>
/// <return>
/// a reference to the accessible
/// child, if one exists
/// </return>

	public static MentorLake.Atk.AtkObjectHandle RefAccessibleAtPoint(this MentorLake.Atk.AtkComponentHandle component, int x, int y, MentorLake.Atk.AtkCoordType coord_type)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_ref_accessible_at_point(component, x, y, coord_type);
	}

/// <summary>
/// <para>
/// Remove the handler specified by @handler_id from the list of
/// functions to be executed when this object receives focus events
/// (in or out).
/// </para>
/// </summary>

/// <param name="component">
/// the #AtkComponent to remove the focus handler from
/// </param>
/// <param name="handler_id">
/// the handler id of the focus handler to be removed
/// from @component
/// </param>

	public static T RemoveFocusHandler<T>(this T component, uint handler_id) where T : AtkComponentHandle
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		AtkComponentHandleExterns.atk_component_remove_focus_handler(component, handler_id);
		return component;
	}

/// <summary>
/// <para>
/// Makes @component visible on the screen by scrolling all necessary parents.
/// </para>
/// <para>
/// Contrary to atk_component_set_position, this does not actually move
/// @component in its parent, this only makes the parents scroll so that the
/// object shows up on the screen, given its current position within the parents.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <param name="type">
/// specify where the object should be made visible.
/// </param>
/// <return>
/// whether scrolling was successful.
/// </return>

	public static bool ScrollTo(this MentorLake.Atk.AtkComponentHandle component, MentorLake.Atk.AtkScrollType type)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_scroll_to(component, type);
	}

/// <summary>
/// <para>
/// Move the top-left of @component to a given position of the screen by
/// scrolling all necessary parents.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <param name="coords">
/// specify whether coordinates are relative to the screen or to the
/// parent object.
/// </param>
/// <param name="x">
/// x-position where to scroll to
/// </param>
/// <param name="y">
/// y-position where to scroll to
/// </param>
/// <return>
/// whether scrolling was successful.
/// </return>

	public static bool ScrollToPoint(this MentorLake.Atk.AtkComponentHandle component, MentorLake.Atk.AtkCoordType coords, int x, int y)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_scroll_to_point(component, coords, x, y);
	}

/// <summary>
/// <para>
/// Sets the extents of @component.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <param name="x">
/// x coordinate
/// </param>
/// <param name="y">
/// y coordinate
/// </param>
/// <param name="width">
/// width to set for @component
/// </param>
/// <param name="height">
/// height to set for @component
/// </param>
/// <param name="coord_type">
/// specifies whether the coordinates are relative to the screen
/// or to the components top level window
/// </param>
/// <return>
/// %TRUE or %FALSE whether the extents were set or not
/// </return>

	public static bool SetExtents(this MentorLake.Atk.AtkComponentHandle component, int x, int y, int width, int height, MentorLake.Atk.AtkCoordType coord_type)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_set_extents(component, x, y, width, height, coord_type);
	}

/// <summary>
/// <para>
/// Sets the position of @component.
/// </para>
/// <para>
/// Contrary to atk_component_scroll_to, this does not trigger any scrolling,
/// this just moves @component in its parent.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <param name="x">
/// x coordinate
/// </param>
/// <param name="y">
/// y coordinate
/// </param>
/// <param name="coord_type">
/// specifies whether the coordinates are relative to the screen
/// or to the component's top level window
/// </param>
/// <return>
/// %TRUE or %FALSE whether or not the position was set or not
/// </return>

	public static bool SetPosition(this MentorLake.Atk.AtkComponentHandle component, int x, int y, MentorLake.Atk.AtkCoordType coord_type)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
		return AtkComponentHandleExterns.atk_component_set_position(component, x, y, coord_type);
	}

/// <summary>
/// <para>
/// Set the size of the @component in terms of width and height.
/// </para>
/// </summary>

/// <param name="component">
/// an #AtkComponent
/// </param>
/// <param name="width">
/// width to set for @component
/// </param>
/// <param name="height">
/// height to set for @component
/// </param>
/// <return>
/// %TRUE or %FALSE whether the size was set or not
/// </return>

	public static bool SetSize(this MentorLake.Atk.AtkComponentHandle component, int width, int height)
	{
		if (component.IsInvalid) throw new Exception("Invalid handle (AtkComponentHandle)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
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
