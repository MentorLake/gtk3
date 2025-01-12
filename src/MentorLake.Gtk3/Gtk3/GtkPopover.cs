namespace MentorLake.Gtk3.Gtk3;

public class GtkPopoverHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkPopoverHandle New(GtkWidgetHandle relative_to)
	{
		return GtkPopoverExterns.gtk_popover_new(relative_to);
	}

	public static GtkPopoverHandle NewFromModel(GtkWidgetHandle relative_to, GMenuModelHandle model)
	{
		return GtkPopoverExterns.gtk_popover_new_from_model(relative_to, model);
	}

}

public static class GtkPopoverSignalExtensions
{

	public static IObservable<GtkPopoverSignalStructs.ClosedSignal> Signal_Closed(this GtkPopoverHandle instance)
	{
		return Observable.Create((IObserver<GtkPopoverSignalStructs.ClosedSignal> obs) =>
		{
			GtkPopoverSignalDelegates.closed handler = (GtkPopoverHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPopoverSignalStructs.ClosedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "closed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkPopoverSignalStructs
{

public struct ClosedSignal
{
	public GtkPopoverHandle Self;
	public IntPtr UserData;
}
}

public static class GtkPopoverSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void closed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPopoverHandle>))] GtkPopoverHandle self, IntPtr user_data);

}


public static class GtkPopoverHandleExtensions
{
	public static T BindModel<T>(this T popover, GMenuModelHandle model, string action_namespace) where T : GtkPopoverHandle
	{
		GtkPopoverExterns.gtk_popover_bind_model(popover, model, action_namespace);
		return popover;
	}

	public static GtkPopoverConstraint GetConstrainTo(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_constrain_to(popover);
	}

	public static GtkWidgetHandle GetDefaultWidget(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_default_widget(popover);
	}

	public static bool GetModal(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_modal(popover);
	}

	public static bool GetPointingTo(this GtkPopoverHandle popover, out GdkRectangle rect)
	{
		return GtkPopoverExterns.gtk_popover_get_pointing_to(popover, out rect);
	}

	public static GtkPositionType GetPosition(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_position(popover);
	}

	public static GtkWidgetHandle GetRelativeTo(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_relative_to(popover);
	}

	public static bool GetTransitionsEnabled(this GtkPopoverHandle popover)
	{
		return GtkPopoverExterns.gtk_popover_get_transitions_enabled(popover);
	}

	public static T Popdown<T>(this T popover) where T : GtkPopoverHandle
	{
		GtkPopoverExterns.gtk_popover_popdown(popover);
		return popover;
	}

	public static T Popup<T>(this T popover) where T : GtkPopoverHandle
	{
		GtkPopoverExterns.gtk_popover_popup(popover);
		return popover;
	}

	public static T SetConstrainTo<T>(this T popover, GtkPopoverConstraint constraint) where T : GtkPopoverHandle
	{
		GtkPopoverExterns.gtk_popover_set_constrain_to(popover, constraint);
		return popover;
	}

	public static T SetDefaultWidget<T>(this T popover, GtkWidgetHandle widget) where T : GtkPopoverHandle
	{
		GtkPopoverExterns.gtk_popover_set_default_widget(popover, widget);
		return popover;
	}

	public static T SetModal<T>(this T popover, bool modal) where T : GtkPopoverHandle
	{
		GtkPopoverExterns.gtk_popover_set_modal(popover, modal);
		return popover;
	}

	public static T SetPointingTo<T>(this T popover, GdkRectangleHandle rect) where T : GtkPopoverHandle
	{
		GtkPopoverExterns.gtk_popover_set_pointing_to(popover, rect);
		return popover;
	}

	public static T SetPosition<T>(this T popover, GtkPositionType position) where T : GtkPopoverHandle
	{
		GtkPopoverExterns.gtk_popover_set_position(popover, position);
		return popover;
	}

	public static T SetRelativeTo<T>(this T popover, GtkWidgetHandle relative_to) where T : GtkPopoverHandle
	{
		GtkPopoverExterns.gtk_popover_set_relative_to(popover, relative_to);
		return popover;
	}

	public static T SetTransitionsEnabled<T>(this T popover, bool transitions_enabled) where T : GtkPopoverHandle
	{
		GtkPopoverExterns.gtk_popover_set_transitions_enabled(popover, transitions_enabled);
		return popover;
	}

}

internal class GtkPopoverExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPopoverHandle gtk_popover_new(GtkWidgetHandle relative_to);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPopoverHandle gtk_popover_new_from_model(GtkWidgetHandle relative_to, GMenuModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_bind_model(GtkPopoverHandle popover, GMenuModelHandle model, string action_namespace);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPopoverConstraint gtk_popover_get_constrain_to(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_popover_get_default_widget(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_popover_get_modal(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_popover_get_pointing_to(GtkPopoverHandle popover, out GdkRectangle rect);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPositionType gtk_popover_get_position(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_popover_get_relative_to(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_popover_get_transitions_enabled(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_popdown(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_popup(GtkPopoverHandle popover);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_set_constrain_to(GtkPopoverHandle popover, GtkPopoverConstraint constraint);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_set_default_widget(GtkPopoverHandle popover, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_set_modal(GtkPopoverHandle popover, bool modal);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_set_pointing_to(GtkPopoverHandle popover, GdkRectangleHandle rect);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_set_position(GtkPopoverHandle popover, GtkPositionType position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_set_relative_to(GtkPopoverHandle popover, GtkWidgetHandle relative_to);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_popover_set_transitions_enabled(GtkPopoverHandle popover, bool transitions_enabled);

}
