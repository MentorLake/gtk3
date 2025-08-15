namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkHandleBox widget allows a portion of a window to be &quot;torn
/// off&quot;. It is a bin widget which displays its child and a handle that
/// the user can drag to tear off a separate window (the “float
/// window”) containing the child widget. A thin
/// “ghost” is drawn in the original location of the
/// handlebox. By dragging the separate window back to its original
/// location, it can be reattached.
/// </para>
/// <para>
/// When reattaching, the ghost and float window, must be aligned
/// along one of the edges, the “snap edge”.
/// This either can be specified by the application programmer
/// explicitly, or GTK+ will pick a reasonable default based
/// on the handle position.
/// </para>
/// <para>
/// To make detaching and reattaching the handlebox as minimally confusing
/// as possible to the user, it is important to set the snap edge so that
/// the snap edge does not move when the handlebox is deattached. For
/// instance, if the handlebox is packed at the bottom of a VBox, then
/// when the handlebox is detached, the bottom edge of the handlebox&apos;s
/// allocation will remain fixed as the height of the handlebox shrinks,
/// so the snap edge should be set to %GTK_POS_BOTTOM.
/// </para>
/// <para>
/// &amp;gt; #GtkHandleBox has been deprecated. It is very specialized, lacks features
/// &amp;gt; to make it useful and most importantly does not fit well into modern
/// &amp;gt; application design. Do not use it. There is no replacement.
/// </para>
/// </summary>

public class GtkHandleBoxHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Create a new handle box.
/// </para>
/// </summary>

/// <return>
/// a new #GtkHandleBox.
/// </return>

	public static MentorLake.Gtk.GtkHandleBoxHandle New()
	{
		return GtkHandleBoxHandleExterns.gtk_handle_box_new();
	}

}
public static class GtkHandleBoxHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the contents of the
/// handlebox are reattached to the main window.
/// </para>
/// </summary>

	public static IObservable<GtkHandleBoxHandleSignalStructs.ChildAttachedSignal> Signal_ChildAttached(this GtkHandleBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkHandleBoxHandleSignalStructs.ChildAttachedSignal> obs) =>
		{
			GtkHandleBoxHandleSignalDelegates.child_attached handler = ( MentorLake.Gtk.GtkHandleBoxHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkHandleBoxHandleSignalStructs.ChildAttachedSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "child-attached", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the contents of the
/// handlebox are detached from the main window.
/// </para>
/// </summary>

	public static IObservable<GtkHandleBoxHandleSignalStructs.ChildDetachedSignal> Signal_ChildDetached(this GtkHandleBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkHandleBoxHandleSignalStructs.ChildDetachedSignal> obs) =>
		{
			GtkHandleBoxHandleSignalDelegates.child_detached handler = ( MentorLake.Gtk.GtkHandleBoxHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkHandleBoxHandleSignalStructs.ChildDetachedSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "child-detached", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkHandleBoxHandleSignalStructs
{

public class ChildAttachedSignal
{

	public MentorLake.Gtk.GtkHandleBoxHandle Self;
/// <summary>
/// <para>
/// the child widget of the handlebox.
///   (this argument provides no extra information
///   and is here only for backwards-compatibility)
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Widget;

	public IntPtr UserData;
}

public class ChildDetachedSignal
{

	public MentorLake.Gtk.GtkHandleBoxHandle Self;
/// <summary>
/// <para>
/// the child widget of the handlebox.
///   (this argument provides no extra information
///   and is here only for backwards-compatibility)
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Widget;

	public IntPtr UserData;
}
}

public static class GtkHandleBoxHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the contents of the
/// handlebox are reattached to the main window.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="widget">
/// the child widget of the handlebox.
///   (this argument provides no extra information
///   and is here only for backwards-compatibility)
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_attached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the contents of the
/// handlebox are detached from the main window.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="widget">
/// the child widget of the handlebox.
///   (this argument provides no extra information
///   and is here only for backwards-compatibility)
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_detached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);

}


public static class GtkHandleBoxHandleExtensions
{
/// <summary>
/// <para>
/// Whether the handlebox’s child is currently detached.
/// </para>
/// </summary>

/// <param name="handle_box">
/// a #GtkHandleBox
/// </param>
/// <return>
/// %TRUE if the child is currently detached, otherwise %FALSE
/// </return>

	public static bool GetChildDetached(this MentorLake.Gtk.GtkHandleBoxHandle handle_box)
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		return GtkHandleBoxHandleExterns.gtk_handle_box_get_child_detached(handle_box);
	}

/// <summary>
/// <para>
/// Gets the handle position of the handle box. See
/// gtk_handle_box_set_handle_position().
/// </para>
/// </summary>

/// <param name="handle_box">
/// a #GtkHandleBox
/// </param>
/// <return>
/// the current handle position.
/// </return>

	public static MentorLake.Gtk.GtkPositionType GetHandlePosition(this MentorLake.Gtk.GtkHandleBoxHandle handle_box)
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		return GtkHandleBoxHandleExterns.gtk_handle_box_get_handle_position(handle_box);
	}

/// <summary>
/// <para>
/// Gets the type of shadow drawn around the handle box. See
/// gtk_handle_box_set_shadow_type().
/// </para>
/// </summary>

/// <param name="handle_box">
/// a #GtkHandleBox
/// </param>
/// <return>
/// the type of shadow currently drawn around the handle box.
/// </return>

	public static MentorLake.Gtk.GtkShadowType GetShadowType(this MentorLake.Gtk.GtkHandleBoxHandle handle_box)
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		return GtkHandleBoxHandleExterns.gtk_handle_box_get_shadow_type(handle_box);
	}

/// <summary>
/// <para>
/// Gets the edge used for determining reattachment of the handle box.
/// See gtk_handle_box_set_snap_edge().
/// </para>
/// </summary>

/// <param name="handle_box">
/// a #GtkHandleBox
/// </param>
/// <return>
/// the edge used for determining reattachment, or
///   (GtkPositionType)-1 if this is determined (as per default)
///   from the handle position.
/// </return>

	public static MentorLake.Gtk.GtkPositionType GetSnapEdge(this MentorLake.Gtk.GtkHandleBoxHandle handle_box)
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		return GtkHandleBoxHandleExterns.gtk_handle_box_get_snap_edge(handle_box);
	}

/// <summary>
/// <para>
/// Sets the side of the handlebox where the handle is drawn.
/// </para>
/// </summary>

/// <param name="handle_box">
/// a #GtkHandleBox
/// </param>
/// <param name="position">
/// the side of the handlebox where the handle should be drawn.
/// </param>

	public static T SetHandlePosition<T>(this T handle_box, MentorLake.Gtk.GtkPositionType position) where T : GtkHandleBoxHandle
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		GtkHandleBoxHandleExterns.gtk_handle_box_set_handle_position(handle_box, position);
		return handle_box;
	}

/// <summary>
/// <para>
/// Sets the type of shadow to be drawn around the border
/// of the handle box.
/// </para>
/// </summary>

/// <param name="handle_box">
/// a #GtkHandleBox
/// </param>
/// <param name="type">
/// the shadow type.
/// </param>

	public static T SetShadowType<T>(this T handle_box, MentorLake.Gtk.GtkShadowType type) where T : GtkHandleBoxHandle
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		GtkHandleBoxHandleExterns.gtk_handle_box_set_shadow_type(handle_box, type);
		return handle_box;
	}

/// <summary>
/// <para>
/// Sets the snap edge of a handlebox. The snap edge is
/// the edge of the detached child that must be aligned
/// with the corresponding edge of the “ghost” left
/// behind when the child was detached to reattach
/// the torn-off window. Usually, the snap edge should
/// be chosen so that it stays in the same place on
/// the screen when the handlebox is torn off.
/// </para>
/// <para>
/// If the snap edge is not set, then an appropriate value
/// will be guessed from the handle position. If the
/// handle position is %GTK_POS_RIGHT or %GTK_POS_LEFT,
/// then the snap edge will be %GTK_POS_TOP, otherwise
/// it will be %GTK_POS_LEFT.
/// </para>
/// </summary>

/// <param name="handle_box">
/// a #GtkHandleBox
/// </param>
/// <param name="edge">
/// the snap edge, or -1 to unset the value; in which
///   case GTK+ will try to guess an appropriate value
///   in the future.
/// </param>

	public static T SetSnapEdge<T>(this T handle_box, MentorLake.Gtk.GtkPositionType edge) where T : GtkHandleBoxHandle
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		GtkHandleBoxHandleExterns.gtk_handle_box_set_snap_edge(handle_box, edge);
		return handle_box;
	}

}

internal class GtkHandleBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkHandleBoxHandle gtk_handle_box_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_handle_box_get_child_detached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_handle_box_get_handle_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkShadowType gtk_handle_box_get_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_handle_box_get_snap_edge([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_handle_box_set_handle_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box, MentorLake.Gtk.GtkPositionType position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_handle_box_set_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box, MentorLake.Gtk.GtkShadowType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_handle_box_set_snap_edge([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box, MentorLake.Gtk.GtkPositionType edge);

}
