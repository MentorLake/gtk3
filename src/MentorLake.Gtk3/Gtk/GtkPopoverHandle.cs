namespace MentorLake.Gtk;

public class GtkPopoverHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkPopoverHandle New(MentorLake.Gtk.GtkWidgetHandle relative_to)
	{
		return GtkPopoverHandleExterns.gtk_popover_new(relative_to);
	}

	public static MentorLake.Gtk.GtkPopoverHandle NewFromModel(MentorLake.Gtk.GtkWidgetHandle relative_to, MentorLake.Gio.GMenuModelHandle model)
	{
		return GtkPopoverHandleExterns.gtk_popover_new_from_model(relative_to, model);
	}

}
public static class GtkPopoverHandleSignalExtensions
{

	public static IObservable<GtkPopoverHandleSignalStructs.ClosedSignal> Signal_Closed(this GtkPopoverHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPopoverHandleSignalStructs.ClosedSignal> obs) =>
		{
			GtkPopoverHandleSignalDelegates.closed handler = ( MentorLake.Gtk.GtkPopoverHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPopoverHandleSignalStructs.ClosedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkPopoverHandleSignalStructs
{

public class ClosedSignal
{
	public MentorLake.Gtk.GtkPopoverHandle Self;
	public IntPtr UserData;
}
}

public static class GtkPopoverHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle self, IntPtr user_data);

}


public static class GtkPopoverHandleExtensions
{
	public static T BindModel<T>(this T popover, MentorLake.Gio.GMenuModelHandle model, string action_namespace) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_bind_model(popover, model, action_namespace);
		return popover;
	}

	public static MentorLake.Gtk.GtkPopoverConstraint GetConstrainTo(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_constrain_to(popover);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetDefaultWidget(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_default_widget(popover);
	}

	public static bool GetModal(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_modal(popover);
	}

	public static bool GetPointingTo(this MentorLake.Gtk.GtkPopoverHandle popover, out MentorLake.Gdk.GdkRectangle rect)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_pointing_to(popover, out rect);
	}

	public static MentorLake.Gtk.GtkPositionType GetPosition(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_position(popover);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetRelativeTo(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_relative_to(popover);
	}

	public static bool GetTransitionsEnabled(this MentorLake.Gtk.GtkPopoverHandle popover)
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		return GtkPopoverHandleExterns.gtk_popover_get_transitions_enabled(popover);
	}

	public static T Popdown<T>(this T popover) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_popdown(popover);
		return popover;
	}

	public static T Popup<T>(this T popover) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_popup(popover);
		return popover;
	}

	public static T SetConstrainTo<T>(this T popover, MentorLake.Gtk.GtkPopoverConstraint constraint) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_constrain_to(popover, constraint);
		return popover;
	}

	public static T SetDefaultWidget<T>(this T popover, MentorLake.Gtk.GtkWidgetHandle widget) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_default_widget(popover, widget);
		return popover;
	}

	public static T SetModal<T>(this T popover, bool modal) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_modal(popover, modal);
		return popover;
	}

	public static T SetPointingTo<T>(this T popover, MentorLake.Gdk.GdkRectangleHandle rect) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_pointing_to(popover, rect);
		return popover;
	}

	public static T SetPosition<T>(this T popover, MentorLake.Gtk.GtkPositionType position) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_position(popover, position);
		return popover;
	}

	public static T SetRelativeTo<T>(this T popover, MentorLake.Gtk.GtkWidgetHandle relative_to) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_relative_to(popover, relative_to);
		return popover;
	}

	public static T SetTransitionsEnabled<T>(this T popover, bool transitions_enabled) where T : GtkPopoverHandle
	{
		if (popover.IsInvalid) throw new Exception("Invalid handle (GtkPopoverHandle)");
		GtkPopoverHandleExterns.gtk_popover_set_transitions_enabled(popover, transitions_enabled);
		return popover;
	}

}

internal class GtkPopoverHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))]
	internal static extern MentorLake.Gtk.GtkPopoverHandle gtk_popover_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle relative_to);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))]
	internal static extern MentorLake.Gtk.GtkPopoverHandle gtk_popover_new_from_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle relative_to, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_bind_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, string action_namespace);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPopoverConstraint gtk_popover_get_constrain_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_popover_get_default_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_popover_get_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_popover_get_pointing_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, out MentorLake.Gdk.GdkRectangle rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_popover_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_popover_get_relative_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_popover_get_transitions_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_constrain_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, MentorLake.Gtk.GtkPopoverConstraint constraint);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_default_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, bool modal);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_pointing_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, MentorLake.Gtk.GtkPositionType position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_relative_to([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle relative_to);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_popover_set_transitions_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPopoverHandle>))] MentorLake.Gtk.GtkPopoverHandle popover, bool transitions_enabled);

}
