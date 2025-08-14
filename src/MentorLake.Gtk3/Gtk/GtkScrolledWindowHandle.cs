namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkScrolledWindow is a container that accepts a single child widget and makes
/// that child scrollable using either internally added scrollbars or externally
/// associated adjustments.
/// </para>
/// <para>
/// Widgets with native scrolling support, i.e. those whose classes implement the
/// #GtkScrollable interface, are added directly. For other types of widget, the
/// class #GtkViewport acts as an adaptor, giving scrollability to other widgets.
/// GtkScrolledWindow’s implementation of gtk_container_add() intelligently
/// accounts for whether or not the added child is a #GtkScrollable. If it isn’t,
/// #GtkScrolledWindow wraps the child in a #GtkViewport and adds that for you.
/// Therefore, you can just add any child widget and not worry about the details.
/// </para>
/// <para>
/// If gtk_container_add() has added a #GtkViewport for you, you can remove
/// both your added child widget from the #GtkViewport, and the #GtkViewport
/// from the GtkScrolledWindow, like this:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GtkWidget *scrolled_window = gtk_scrolled_window_new (NULL, NULL);
/// GtkWidget *child_widget = gtk_button_new ();
/// </para>
/// <para>
/// // GtkButton is not a GtkScrollable, so GtkScrolledWindow will automatically
/// // add a GtkViewport.
/// gtk_container_add (GTK_CONTAINER (scrolled_window),
///                    child_widget);
/// </para>
/// <para>
/// // Either of these will result in child_widget being unparented:
/// gtk_container_remove (GTK_CONTAINER (scrolled_window),
///                       child_widget);
/// // or
/// gtk_container_remove (GTK_CONTAINER (scrolled_window),
///                       gtk_bin_get_child (GTK_BIN (scrolled_window)));
/// ]|
/// </para>
/// <para>
/// Unless #GtkScrolledWindow:policy is GTK_POLICY_NEVER or GTK_POLICY_EXTERNAL,
/// GtkScrolledWindow adds internal #GtkScrollbar widgets around its child. The
/// scroll position of the child, and if applicable the scrollbars, is controlled
/// by the #GtkScrolledWindow:hadjustment and #GtkScrolledWindow:vadjustment
/// that are associated with the GtkScrolledWindow. See the docs on #GtkScrollbar
/// for the details, but note that the “step_increment” and “page_increment”
/// fields are only effective if the policy causes scrollbars to be present.
/// </para>
/// <para>
/// If a GtkScrolledWindow doesn’t behave quite as you would like, or
/// doesn’t have exactly the right layout, it’s very possible to set up
/// your own scrolling with #GtkScrollbar and for example a #GtkGrid.
/// </para>
/// <para>
/// # Touch support
/// </para>
/// <para>
/// GtkScrolledWindow has built-in support for touch devices. When a
/// touchscreen is used, swiping will move the scrolled window, and will
/// expose 'kinetic' behavior. This can be turned off with the
/// #GtkScrolledWindow:kinetic-scrolling property if it is undesired.
/// </para>
/// <para>
/// GtkScrolledWindow also displays visual 'overshoot' indication when
/// the content is pulled beyond the end, and this situation can be
/// captured with the #GtkScrolledWindow::edge-overshot signal.
/// </para>
/// <para>
/// If no mouse device is present, the scrollbars will overlayed as
/// narrow, auto-hiding indicators over the content. If traditional
/// scrollbars are desired although no mouse is present, this behaviour
/// can be turned off with the #GtkScrolledWindow:overlay-scrolling
/// property.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkScrolledWindow has a main CSS node with name scrolledwindow.
/// </para>
/// <para>
/// It uses subnodes with names overshoot and undershoot to
/// draw the overflow and underflow indications. These nodes get
/// the .left, .right, .top or .bottom style class added depending
/// on where the indication is drawn.
/// </para>
/// <para>
/// GtkScrolledWindow also sets the positional style classes (.left,
/// .right, .top, .bottom) and style classes related to overlay
/// scrolling (.overlay-indicator, .dragging, .hovering) on its scrollbars.
/// </para>
/// <para>
/// If both scrollbars are visible, the area where they meet is drawn
/// with a subnode named junction.
/// </para>
/// </summary>

public class GtkScrolledWindowHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new scrolled window.
/// </para>
/// <para>
/// The two arguments are the scrolled window’s adjustments; these will be
/// shared with the scrollbars and the child widget to keep the bars in sync
/// with the child. Usually you want to pass %NULL for the adjustments, which
/// will cause the scrolled window to create them for you.
/// </para>
/// </summary>

/// <param name="hadjustment">
/// horizontal adjustment
/// </param>
/// <param name="vadjustment">
/// vertical adjustment
/// </param>
/// <return>
/// a new scrolled window
/// </return>

	public static MentorLake.Gtk.GtkScrolledWindowHandle New(MentorLake.Gtk.GtkAdjustmentHandle hadjustment, MentorLake.Gtk.GtkAdjustmentHandle vadjustment)
	{
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_new(hadjustment, vadjustment);
	}

}
public static class GtkScrolledWindowHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::edge-overshot signal is emitted whenever user initiated scrolling
/// makes the scrolled window firmly surpass (i.e. with some edge resistance)
/// the lower or upper limits defined by the adjustment in that orientation.
/// </para>
/// <para>
/// A similar behavior without edge resistance is provided by the
/// #GtkScrolledWindow::edge-reached signal.
/// </para>
/// <para>
/// Note: The @pos argument is LTR/RTL aware, so callers should be aware too
/// if intending to provide behavior on horizontal edges.
/// </para>
/// </summary>

	public static IObservable<GtkScrolledWindowHandleSignalStructs.EdgeOvershotSignal> Signal_EdgeOvershot(this GtkScrolledWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScrolledWindowHandleSignalStructs.EdgeOvershotSignal> obs) =>
		{
			GtkScrolledWindowHandleSignalDelegates.edge_overshot handler = ( MentorLake.Gtk.GtkScrolledWindowHandle self,  MentorLake.Gtk.GtkPositionType pos,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowHandleSignalStructs.EdgeOvershotSignal()
				{
					Self = self, Pos = pos, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "edge-overshot", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The ::edge-reached signal is emitted whenever user-initiated scrolling
/// makes the scrolled window exactly reach the lower or upper limits
/// defined by the adjustment in that orientation.
/// </para>
/// <para>
/// A similar behavior with edge resistance is provided by the
/// #GtkScrolledWindow::edge-overshot signal.
/// </para>
/// <para>
/// Note: The @pos argument is LTR/RTL aware, so callers should be aware too
/// if intending to provide behavior on horizontal edges.
/// </para>
/// </summary>

	public static IObservable<GtkScrolledWindowHandleSignalStructs.EdgeReachedSignal> Signal_EdgeReached(this GtkScrolledWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScrolledWindowHandleSignalStructs.EdgeReachedSignal> obs) =>
		{
			GtkScrolledWindowHandleSignalDelegates.edge_reached handler = ( MentorLake.Gtk.GtkScrolledWindowHandle self,  MentorLake.Gtk.GtkPositionType pos,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowHandleSignalStructs.EdgeReachedSignal()
				{
					Self = self, Pos = pos, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "edge-reached", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The ::move-focus-out signal is a
/// [keybinding signal][GtkBindingSignal] which gets
/// emitted when focus is moved away from the scrolled window by a
/// keybinding. The #GtkWidget::move-focus signal is emitted with
/// @direction_type on this scrolled window’s toplevel parent in the
/// container hierarchy. The default bindings for this signal are
/// `Ctrl + Tab` to move forward and `Ctrl + Shift + Tab` to move backward.
/// </para>
/// </summary>

	public static IObservable<GtkScrolledWindowHandleSignalStructs.MoveFocusOutSignal> Signal_MoveFocusOut(this GtkScrolledWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScrolledWindowHandleSignalStructs.MoveFocusOutSignal> obs) =>
		{
			GtkScrolledWindowHandleSignalDelegates.move_focus_out handler = ( MentorLake.Gtk.GtkScrolledWindowHandle self,  MentorLake.Gtk.GtkDirectionType direction_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowHandleSignalStructs.MoveFocusOutSignal()
				{
					Self = self, DirectionType = direction_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-focus-out", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The ::scroll-child signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when a keybinding that scrolls is pressed.
/// The horizontal or vertical adjustment is updated which triggers a
/// signal that the scrolled window’s child may listen to and scroll itself.
/// </para>
/// </summary>

	public static IObservable<GtkScrolledWindowHandleSignalStructs.ScrollChildSignal> Signal_ScrollChild(this GtkScrolledWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkScrolledWindowHandleSignalStructs.ScrollChildSignal> obs) =>
		{
			GtkScrolledWindowHandleSignalDelegates.scroll_child handler = ( MentorLake.Gtk.GtkScrolledWindowHandle self,  MentorLake.Gtk.GtkScrollType scroll,  bool horizontal,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkScrolledWindowHandleSignalStructs.ScrollChildSignal()
				{
					Self = self, Scroll = scroll, Horizontal = horizontal, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "scroll-child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkScrolledWindowHandleSignalStructs
{

public class EdgeOvershotSignal
{

	public MentorLake.Gtk.GtkScrolledWindowHandle Self;
/// <summary>
/// <para>
/// edge side that was hit
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPositionType Pos;

	public IntPtr UserData;
}

public class EdgeReachedSignal
{

	public MentorLake.Gtk.GtkScrolledWindowHandle Self;
/// <summary>
/// <para>
/// edge side that was reached
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPositionType Pos;

	public IntPtr UserData;
}

public class MoveFocusOutSignal
{

	public MentorLake.Gtk.GtkScrolledWindowHandle Self;
/// <summary>
/// <para>
/// either %GTK_DIR_TAB_FORWARD or
///   %GTK_DIR_TAB_BACKWARD
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkDirectionType DirectionType;

	public IntPtr UserData;
}

public class ScrollChildSignal
{

	public MentorLake.Gtk.GtkScrolledWindowHandle Self;
/// <summary>
/// <para>
/// a #GtkScrollType describing how much to scroll
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkScrollType Scroll;
/// <summary>
/// <para>
/// whether the keybinding scrolls the child
///   horizontally or not
/// </para>
/// </summary>

	public bool Horizontal;

	public IntPtr UserData;

	public bool ReturnValue;
}
}

public static class GtkScrolledWindowHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::edge-overshot signal is emitted whenever user initiated scrolling
/// makes the scrolled window firmly surpass (i.e. with some edge resistance)
/// the lower or upper limits defined by the adjustment in that orientation.
/// </para>
/// <para>
/// A similar behavior without edge resistance is provided by the
/// #GtkScrolledWindow::edge-reached signal.
/// </para>
/// <para>
/// Note: The @pos argument is LTR/RTL aware, so callers should be aware too
/// if intending to provide behavior on horizontal edges.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="pos">
/// edge side that was hit
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void edge_overshot([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle self, MentorLake.Gtk.GtkPositionType pos, IntPtr user_data);


/// <summary>
/// <para>
/// The ::edge-reached signal is emitted whenever user-initiated scrolling
/// makes the scrolled window exactly reach the lower or upper limits
/// defined by the adjustment in that orientation.
/// </para>
/// <para>
/// A similar behavior with edge resistance is provided by the
/// #GtkScrolledWindow::edge-overshot signal.
/// </para>
/// <para>
/// Note: The @pos argument is LTR/RTL aware, so callers should be aware too
/// if intending to provide behavior on horizontal edges.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="pos">
/// edge side that was reached
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void edge_reached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle self, MentorLake.Gtk.GtkPositionType pos, IntPtr user_data);


/// <summary>
/// <para>
/// The ::move-focus-out signal is a
/// [keybinding signal][GtkBindingSignal] which gets
/// emitted when focus is moved away from the scrolled window by a
/// keybinding. The #GtkWidget::move-focus signal is emitted with
/// @direction_type on this scrolled window’s toplevel parent in the
/// container hierarchy. The default bindings for this signal are
/// `Ctrl + Tab` to move forward and `Ctrl + Shift + Tab` to move backward.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="direction_type">
/// either %GTK_DIR_TAB_FORWARD or
///   %GTK_DIR_TAB_BACKWARD
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_focus_out([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle self, MentorLake.Gtk.GtkDirectionType direction_type, IntPtr user_data);


/// <summary>
/// <para>
/// The ::scroll-child signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when a keybinding that scrolls is pressed.
/// The horizontal or vertical adjustment is updated which triggers a
/// signal that the scrolled window’s child may listen to and scroll itself.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="scroll">
/// a #GtkScrollType describing how much to scroll
/// </param>
/// <param name="horizontal">
/// whether the keybinding scrolls the child
///   horizontally or not
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool scroll_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle self, MentorLake.Gtk.GtkScrollType scroll, bool horizontal, IntPtr user_data);

}


public static class GtkScrolledWindowHandleExtensions
{
/// <summary>
/// <para>
/// Used to add children without native scrolling capabilities. This
/// is simply a convenience function; it is equivalent to adding the
/// unscrollable child to a viewport, then adding the viewport to the
/// scrolled window. If a child has native scrolling, use
/// gtk_container_add() instead of this function.
/// </para>
/// <para>
/// The viewport scrolls the child by moving its #GdkWindow, and takes
/// the size of the child to be the size of its toplevel #GdkWindow.
/// This will be very wrong for most widgets that support native scrolling;
/// for example, if you add a widget such as #GtkTreeView with a viewport,
/// the whole widget will scroll, including the column headings. Thus,
/// widgets with native scrolling support should not be used with the
/// #GtkViewport proxy.
/// </para>
/// <para>
/// A widget supports scrolling natively if it implements the
/// #GtkScrollable interface.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="child">
/// the widget you want to scroll
/// </param>

	public static T AddWithViewport<T>(this T scrolled_window, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_add_with_viewport(scrolled_window, child);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Return whether button presses are captured during kinetic
/// scrolling. See gtk_scrolled_window_set_capture_button_press().
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// %TRUE if button presses are captured during kinetic scrolling
/// </return>

	public static bool GetCaptureButtonPress(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_capture_button_press(scrolled_window);
	}

/// <summary>
/// <para>
/// Returns the horizontal scrollbar’s adjustment, used to connect the
/// horizontal scrollbar to the child widget’s horizontal scroll
/// functionality.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the horizontal #GtkAdjustment
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetHadjustment(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_hadjustment(scrolled_window);
	}

/// <summary>
/// <para>
/// Returns the horizontal scrollbar of @scrolled_window.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the horizontal scrollbar of the scrolled window.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetHscrollbar(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_hscrollbar(scrolled_window);
	}

/// <summary>
/// <para>
/// Returns the specified kinetic scrolling behavior.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the scrolling behavior flags.
/// </return>

	public static bool GetKineticScrolling(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_kinetic_scrolling(scrolled_window);
	}

/// <summary>
/// <para>
/// Returns the maximum content height set.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the maximum content height, or -1
/// </return>

	public static int GetMaxContentHeight(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_max_content_height(scrolled_window);
	}

/// <summary>
/// <para>
/// Returns the maximum content width set.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the maximum content width, or -1
/// </return>

	public static int GetMaxContentWidth(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_max_content_width(scrolled_window);
	}

/// <summary>
/// <para>
/// Gets the minimal content height of @scrolled_window, or -1 if not set.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the minimal content height
/// </return>

	public static int GetMinContentHeight(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_min_content_height(scrolled_window);
	}

/// <summary>
/// <para>
/// Gets the minimum content width of @scrolled_window, or -1 if not set.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the minimum content width
/// </return>

	public static int GetMinContentWidth(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_min_content_width(scrolled_window);
	}

/// <summary>
/// <para>
/// Returns whether overlay scrolling is enabled for this scrolled window.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// %TRUE if overlay scrolling is enabled
/// </return>

	public static bool GetOverlayScrolling(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_overlay_scrolling(scrolled_window);
	}

/// <summary>
/// <para>
/// Gets the placement of the contents with respect to the scrollbars
/// for the scrolled window. See gtk_scrolled_window_set_placement().
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the current placement value.
/// 
/// See also gtk_scrolled_window_set_placement() and
/// gtk_scrolled_window_unset_placement().
/// </return>

	public static MentorLake.Gtk.GtkCornerType GetPlacement(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_placement(scrolled_window);
	}

/// <summary>
/// <para>
/// Retrieves the current policy values for the horizontal and vertical
/// scrollbars. See gtk_scrolled_window_set_policy().
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="hscrollbar_policy">
/// location to store the policy
///     for the horizontal scrollbar, or %NULL
/// </param>
/// <param name="vscrollbar_policy">
/// location to store the policy
///     for the vertical scrollbar, or %NULL
/// </param>

	public static T GetPolicy<T>(this T scrolled_window, out MentorLake.Gtk.GtkPolicyType hscrollbar_policy, out MentorLake.Gtk.GtkPolicyType vscrollbar_policy) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_policy(scrolled_window, out hscrollbar_policy, out vscrollbar_policy);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Reports whether the natural height of the child will be calculated and propagated
/// through the scrolled window’s requested natural height.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// whether natural height propagation is enabled.
/// </return>

	public static bool GetPropagateNaturalHeight(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_propagate_natural_height(scrolled_window);
	}

/// <summary>
/// <para>
/// Reports whether the natural width of the child will be calculated and propagated
/// through the scrolled window’s requested natural width.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// whether natural width propagation is enabled.
/// </return>

	public static bool GetPropagateNaturalWidth(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_propagate_natural_width(scrolled_window);
	}

/// <summary>
/// <para>
/// Gets the shadow type of the scrolled window. See
/// gtk_scrolled_window_set_shadow_type().
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the current shadow type
/// </return>

	public static MentorLake.Gtk.GtkShadowType GetShadowType(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_shadow_type(scrolled_window);
	}

/// <summary>
/// <para>
/// Returns the vertical scrollbar’s adjustment, used to connect the
/// vertical scrollbar to the child widget’s vertical scroll functionality.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the vertical #GtkAdjustment
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetVadjustment(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_vadjustment(scrolled_window);
	}

/// <summary>
/// <para>
/// Returns the vertical scrollbar of @scrolled_window.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <return>
/// the vertical scrollbar of the scrolled window.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetVscrollbar(this MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window)
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		return GtkScrolledWindowHandleExterns.gtk_scrolled_window_get_vscrollbar(scrolled_window);
	}

/// <summary>
/// <para>
/// Changes the behaviour of @scrolled_window with regard to the initial
/// event that possibly starts kinetic scrolling. When @capture_button_press
/// is set to %TRUE, the event is captured by the scrolled window, and
/// then later replayed if it is meant to go to the child widget.
/// </para>
/// <para>
/// This should be enabled if any child widgets perform non-reversible
/// actions on #GtkWidget::button-press-event. If they don't, and handle
/// additionally handle #GtkWidget::grab-broken-event, it might be better
/// to set @capture_button_press to %FALSE.
/// </para>
/// <para>
/// This setting only has an effect if kinetic scrolling is enabled.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="capture_button_press">
/// %TRUE to capture button presses
/// </param>

	public static T SetCaptureButtonPress<T>(this T scrolled_window, bool capture_button_press) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_capture_button_press(scrolled_window, capture_button_press);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Sets the #GtkAdjustment for the horizontal scrollbar.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="hadjustment">
/// the #GtkAdjustment to use, or %NULL to create a new one
/// </param>

	public static T SetHadjustment<T>(this T scrolled_window, MentorLake.Gtk.GtkAdjustmentHandle hadjustment) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_hadjustment(scrolled_window, hadjustment);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Turns kinetic scrolling on or off.
/// Kinetic scrolling only applies to devices with source
/// %GDK_SOURCE_TOUCHSCREEN.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="kinetic_scrolling">
/// %TRUE to enable kinetic scrolling
/// </param>

	public static T SetKineticScrolling<T>(this T scrolled_window, bool kinetic_scrolling) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_kinetic_scrolling(scrolled_window, kinetic_scrolling);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Sets the maximum height that @scrolled_window should keep visible. The
/// @scrolled_window will grow up to this height before it starts scrolling
/// the content.
/// </para>
/// <para>
/// It is a programming error to set the maximum content height to a value
/// smaller than #GtkScrolledWindow:min-content-height.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="height">
/// the maximum content height
/// </param>

	public static T SetMaxContentHeight<T>(this T scrolled_window, int height) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_max_content_height(scrolled_window, height);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Sets the maximum width that @scrolled_window should keep visible. The
/// @scrolled_window will grow up to this width before it starts scrolling
/// the content.
/// </para>
/// <para>
/// It is a programming error to set the maximum content width to a value
/// smaller than #GtkScrolledWindow:min-content-width.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="width">
/// the maximum content width
/// </param>

	public static T SetMaxContentWidth<T>(this T scrolled_window, int width) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_max_content_width(scrolled_window, width);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Sets the minimum height that @scrolled_window should keep visible.
/// Note that this can and (usually will) be smaller than the minimum
/// size of the content.
/// </para>
/// <para>
/// It is a programming error to set the minimum content height to a
/// value greater than #GtkScrolledWindow:max-content-height.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="height">
/// the minimal content height
/// </param>

	public static T SetMinContentHeight<T>(this T scrolled_window, int height) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_min_content_height(scrolled_window, height);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Sets the minimum width that @scrolled_window should keep visible.
/// Note that this can and (usually will) be smaller than the minimum
/// size of the content.
/// </para>
/// <para>
/// It is a programming error to set the minimum content width to a
/// value greater than #GtkScrolledWindow:max-content-width.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="width">
/// the minimal content width
/// </param>

	public static T SetMinContentWidth<T>(this T scrolled_window, int width) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_min_content_width(scrolled_window, width);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Enables or disables overlay scrolling for this scrolled window.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="overlay_scrolling">
/// whether to enable overlay scrolling
/// </param>

	public static T SetOverlayScrolling<T>(this T scrolled_window, bool overlay_scrolling) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_overlay_scrolling(scrolled_window, overlay_scrolling);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Sets the placement of the contents with respect to the scrollbars
/// for the scrolled window.
/// </para>
/// <para>
/// The default is %GTK_CORNER_TOP_LEFT, meaning the child is
/// in the top left, with the scrollbars underneath and to the right.
/// Other values in #GtkCornerType are %GTK_CORNER_TOP_RIGHT,
/// %GTK_CORNER_BOTTOM_LEFT, and %GTK_CORNER_BOTTOM_RIGHT.
/// </para>
/// <para>
/// See also gtk_scrolled_window_get_placement() and
/// gtk_scrolled_window_unset_placement().
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="window_placement">
/// position of the child window
/// </param>

	public static T SetPlacement<T>(this T scrolled_window, MentorLake.Gtk.GtkCornerType window_placement) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_placement(scrolled_window, window_placement);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Sets the scrollbar policy for the horizontal and vertical scrollbars.
/// </para>
/// <para>
/// The policy determines when the scrollbar should appear; it is a value
/// from the #GtkPolicyType enumeration. If %GTK_POLICY_ALWAYS, the
/// scrollbar is always present; if %GTK_POLICY_NEVER, the scrollbar is
/// never present; if %GTK_POLICY_AUTOMATIC, the scrollbar is present only
/// if needed (that is, if the slider part of the bar would be smaller
/// than the trough — the display is larger than the page size).
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="hscrollbar_policy">
/// policy for horizontal bar
/// </param>
/// <param name="vscrollbar_policy">
/// policy for vertical bar
/// </param>

	public static T SetPolicy<T>(this T scrolled_window, MentorLake.Gtk.GtkPolicyType hscrollbar_policy, MentorLake.Gtk.GtkPolicyType vscrollbar_policy) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_policy(scrolled_window, hscrollbar_policy, vscrollbar_policy);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Sets whether the natural height of the child should be calculated and propagated
/// through the scrolled window’s requested natural height.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="propagate">
/// whether to propagate natural height
/// </param>

	public static T SetPropagateNaturalHeight<T>(this T scrolled_window, bool propagate) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_propagate_natural_height(scrolled_window, propagate);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Sets whether the natural width of the child should be calculated and propagated
/// through the scrolled window’s requested natural width.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="propagate">
/// whether to propagate natural width
/// </param>

	public static T SetPropagateNaturalWidth<T>(this T scrolled_window, bool propagate) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_propagate_natural_width(scrolled_window, propagate);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Changes the type of shadow drawn around the contents of
/// @scrolled_window.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="type">
/// kind of shadow to draw around scrolled window contents
/// </param>

	public static T SetShadowType<T>(this T scrolled_window, MentorLake.Gtk.GtkShadowType type) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_shadow_type(scrolled_window, type);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Sets the #GtkAdjustment for the vertical scrollbar.
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>
/// <param name="vadjustment">
/// the #GtkAdjustment to use, or %NULL to create a new one
/// </param>

	public static T SetVadjustment<T>(this T scrolled_window, MentorLake.Gtk.GtkAdjustmentHandle vadjustment) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_set_vadjustment(scrolled_window, vadjustment);
		return scrolled_window;
	}

/// <summary>
/// <para>
/// Unsets the placement of the contents with respect to the scrollbars
/// for the scrolled window. If no window placement is set for a scrolled
/// window, it defaults to %GTK_CORNER_TOP_LEFT.
/// </para>
/// <para>
/// See also gtk_scrolled_window_set_placement() and
/// gtk_scrolled_window_get_placement().
/// </para>
/// </summary>

/// <param name="scrolled_window">
/// a #GtkScrolledWindow
/// </param>

	public static T UnsetPlacement<T>(this T scrolled_window) where T : GtkScrolledWindowHandle
	{
		if (scrolled_window.IsInvalid) throw new Exception("Invalid handle (GtkScrolledWindowHandle)");
		GtkScrolledWindowHandleExterns.gtk_scrolled_window_unset_placement(scrolled_window);
		return scrolled_window;
	}

}

internal class GtkScrolledWindowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkScrolledWindowHandle gtk_scrolled_window_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle hadjustment, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle vadjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_add_with_viewport([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrolled_window_get_capture_button_press([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_scrolled_window_get_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_scrolled_window_get_hscrollbar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrolled_window_get_kinetic_scrolling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_scrolled_window_get_max_content_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_scrolled_window_get_max_content_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_scrolled_window_get_min_content_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_scrolled_window_get_min_content_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrolled_window_get_overlay_scrolling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCornerType gtk_scrolled_window_get_placement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_get_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, out MentorLake.Gtk.GtkPolicyType hscrollbar_policy, out MentorLake.Gtk.GtkPolicyType vscrollbar_policy);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrolled_window_get_propagate_natural_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_scrolled_window_get_propagate_natural_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkShadowType gtk_scrolled_window_get_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_scrolled_window_get_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_scrolled_window_get_vscrollbar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_capture_button_press([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, bool capture_button_press);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_hadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle hadjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_kinetic_scrolling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, bool kinetic_scrolling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_max_content_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_max_content_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, int width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_min_content_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_min_content_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, int width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_overlay_scrolling([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, bool overlay_scrolling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_placement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, MentorLake.Gtk.GtkCornerType window_placement);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, MentorLake.Gtk.GtkPolicyType hscrollbar_policy, MentorLake.Gtk.GtkPolicyType vscrollbar_policy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_propagate_natural_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, bool propagate);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_propagate_natural_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, bool propagate);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, MentorLake.Gtk.GtkShadowType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_set_vadjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle vadjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_scrolled_window_unset_placement([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkScrolledWindowHandle>))] MentorLake.Gtk.GtkScrolledWindowHandle scrolled_window);

}
