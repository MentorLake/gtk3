namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkOverlay is a container which contains a single main child, on top
/// of which it can place “overlay” widgets. The position of each overlay
/// widget is determined by its #GtkWidget:halign and #GtkWidget:valign
/// properties. E.g. a widget with both alignments set to %GTK_ALIGN_START
/// will be placed at the top left corner of the GtkOverlay container,
/// whereas an overlay with halign set to %GTK_ALIGN_CENTER and valign set
/// to %GTK_ALIGN_END will be placed a the bottom edge of the GtkOverlay,
/// horizontally centered. The position can be adjusted by setting the margin
/// properties of the child to non-zero values.
/// </para>
/// <para>
/// More complicated placement of overlays is possible by connecting
/// to the #GtkOverlay::get-child-position signal.
/// </para>
/// <para>
/// An overlay’s minimum and natural sizes are those of its main child. The sizes
/// of overlay children are not considered when measuring these preferred sizes.
/// </para>
/// <para>
/// # GtkOverlay as GtkBuildable
/// </para>
/// <para>
/// The GtkOverlay implementation of the GtkBuildable interface
/// supports placing a child as an overlay by specifying “overlay” as
/// the “type” attribute of a `&amp;lt;child&amp;gt;` element.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkOverlay has a single CSS node with the name “overlay”. Overlay children
/// whose alignments cause them to be positioned at an edge get the style classes
/// “.left”, “.right”, “.top”, and/or “.bottom” according to their position.
/// </para>
/// </summary>

public class GtkOverlayHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkOverlay.
/// </para>
/// </summary>

/// <return>
/// a new #GtkOverlay object.
/// </return>

	public static MentorLake.Gtk.GtkOverlayHandle New()
	{
		return GtkOverlayHandleExterns.gtk_overlay_new();
	}

}
public static class GtkOverlayHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::get-child-position signal is emitted to determine
/// the position and size of any overlay child widgets. A
/// handler for this signal should fill @allocation with
/// the desired position and size for @widget, relative to
/// the &apos;main&apos; child of @overlay.
/// </para>
/// <para>
/// The default handler for this signal uses the @widget&apos;s
/// halign and valign properties to determine the position
/// and gives the widget its natural size (except that an
/// alignment of %GTK_ALIGN_FILL will cause the overlay to
/// be full-width/height). If the main child is a
/// #GtkScrolledWindow, the overlays are placed relative
/// to its contents.
/// </para>
/// </summary>

	public static IObservable<GtkOverlayHandleSignalStructs.GetChildPositionSignal> Signal_GetChildPosition(this GtkOverlayHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkOverlayHandleSignalStructs.GetChildPositionSignal> obs) =>
		{
			GtkOverlayHandleSignalDelegates.get_child_position handler = ( MentorLake.Gtk.GtkOverlayHandle self,  MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gdk.GdkRectangleHandle allocation,  IntPtr user_data) =>
			{
				allocation = default;

				var signalStruct = new GtkOverlayHandleSignalStructs.GetChildPositionSignal()
				{
					Self = self, Widget = widget, Allocation = allocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "get-child-position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkOverlayHandleSignalStructs
{

public class GetChildPositionSignal
{

	public MentorLake.Gtk.GtkOverlayHandle Self;
/// <summary>
/// <para>
/// the child widget to position
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Widget;
/// <summary>
/// <para>
/// return
///   location for the allocation
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkRectangleHandle Allocation;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the @allocation has been filled
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GtkOverlayHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::get-child-position signal is emitted to determine
/// the position and size of any overlay child widgets. A
/// handler for this signal should fill @allocation with
/// the desired position and size for @widget, relative to
/// the &apos;main&apos; child of @overlay.
/// </para>
/// <para>
/// The default handler for this signal uses the @widget&apos;s
/// halign and valign properties to determine the position
/// and gives the widget its natural size (except that an
/// alignment of %GTK_ALIGN_FILL will cause the overlay to
/// be full-width/height). If the main child is a
/// #GtkScrolledWindow, the overlays are placed relative
/// to its contents.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="widget">
/// the child widget to position
/// </param>
/// <param name="allocation">
/// return
///   location for the allocation
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the @allocation has been filled
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool get_child_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))] MentorLake.Gtk.GtkOverlayHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] out MentorLake.Gdk.GdkRectangleHandle allocation, IntPtr user_data);

}


public static class GtkOverlayHandleExtensions
{
/// <summary>
/// <para>
/// Adds @widget to @overlay.
/// </para>
/// <para>
/// The widget will be stacked on top of the main widget
/// added with gtk_container_add().
/// </para>
/// <para>
/// The position at which @widget is placed is determined
/// from its #GtkWidget:halign and #GtkWidget:valign properties.
/// </para>
/// </summary>

/// <param name="overlay">
/// a #GtkOverlay
/// </param>
/// <param name="widget">
/// a #GtkWidget to be added to the container
/// </param>

	public static T AddOverlay<T>(this T overlay, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkOverlayHandle
	{
		if (overlay.IsInvalid) throw new Exception("Invalid handle (GtkOverlayHandle)");
		GtkOverlayHandleExterns.gtk_overlay_add_overlay(overlay, widget);
		return overlay;
	}

/// <summary>
/// <para>
/// Convenience function to get the value of the #GtkOverlay:pass-through
/// child property for @widget.
/// </para>
/// </summary>

/// <param name="overlay">
/// a #GtkOverlay
/// </param>
/// <param name="widget">
/// an overlay child of #GtkOverlay
/// </param>
/// <return>
/// whether the widget is a pass through child.
/// </return>

	public static bool GetOverlayPassThrough(this MentorLake.Gtk.GtkOverlayHandle overlay, MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (overlay.IsInvalid) throw new Exception("Invalid handle (GtkOverlayHandle)");
		return GtkOverlayHandleExterns.gtk_overlay_get_overlay_pass_through(overlay, widget);
	}

/// <summary>
/// <para>
/// Moves @child to a new @index in the list of @overlay children.
/// The list contains overlays in the order that these were
/// added to @overlay by default. See also #GtkOverlay:index.
/// </para>
/// <para>
/// A widget’s index in the @overlay children list determines which order
/// the children are drawn if they overlap. The first child is drawn at
/// the bottom. It also affects the default focus chain order.
/// </para>
/// </summary>

/// <param name="overlay">
/// a #GtkOverlay
/// </param>
/// <param name="child">
/// the overlaid #GtkWidget to move
/// </param>
/// <param name="index_">
/// the new index for @child in the list of overlay children
///   of @overlay, starting from 0. If negative, indicates the end of
///   the list
/// </param>

	public static T ReorderOverlay<T>(this T overlay, MentorLake.Gtk.GtkWidgetHandle child, int index_) where T : GtkOverlayHandle
	{
		if (overlay.IsInvalid) throw new Exception("Invalid handle (GtkOverlayHandle)");
		GtkOverlayHandleExterns.gtk_overlay_reorder_overlay(overlay, child, index_);
		return overlay;
	}

/// <summary>
/// <para>
/// Convenience function to set the value of the #GtkOverlay:pass-through
/// child property for @widget.
/// </para>
/// </summary>

/// <param name="overlay">
/// a #GtkOverlay
/// </param>
/// <param name="widget">
/// an overlay child of #GtkOverlay
/// </param>
/// <param name="pass_through">
/// whether the child should pass the input through
/// </param>

	public static T SetOverlayPassThrough<T>(this T overlay, MentorLake.Gtk.GtkWidgetHandle widget, bool pass_through) where T : GtkOverlayHandle
	{
		if (overlay.IsInvalid) throw new Exception("Invalid handle (GtkOverlayHandle)");
		GtkOverlayHandleExterns.gtk_overlay_set_overlay_pass_through(overlay, widget, pass_through);
		return overlay;
	}

}

internal class GtkOverlayHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))]
	internal static extern MentorLake.Gtk.GtkOverlayHandle gtk_overlay_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_overlay_add_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))] MentorLake.Gtk.GtkOverlayHandle overlay, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_overlay_get_overlay_pass_through([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))] MentorLake.Gtk.GtkOverlayHandle overlay, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_overlay_reorder_overlay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))] MentorLake.Gtk.GtkOverlayHandle overlay, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_overlay_set_overlay_pass_through([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOverlayHandle>))] MentorLake.Gtk.GtkOverlayHandle overlay, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool pass_through);

}
