namespace MentorLake.Gtk;

public class GtkExpanderHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkExpanderHandle New(string label)
	{
		return GtkExpanderHandleExterns.gtk_expander_new(label);
	}

	public static MentorLake.Gtk.GtkExpanderHandle NewWithMnemonic(string label)
	{
		return GtkExpanderHandleExterns.gtk_expander_new_with_mnemonic(label);
	}

}
public static class GtkExpanderHandleSignalExtensions
{

	public static IObservable<GtkExpanderHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkExpanderHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkExpanderHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkExpanderHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkExpanderHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkExpanderHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkExpanderHandleSignalStructs
{

public class ActivateSignal
{
	public MentorLake.Gtk.GtkExpanderHandle Self;
	public IntPtr UserData;
}
}

public static class GtkExpanderHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle self, IntPtr user_data);

}


public static class GtkExpanderHandleExtensions
{
	public static bool GetExpanded(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_expanded(expander);
	}

	public static string GetLabel(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_label(expander);
	}

	public static bool GetLabelFill(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_label_fill(expander);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetLabelWidget(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_label_widget(expander);
	}

	public static bool GetResizeToplevel(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_resize_toplevel(expander);
	}

	public static int GetSpacing(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_spacing(expander);
	}

	public static bool GetUseMarkup(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_use_markup(expander);
	}

	public static bool GetUseUnderline(this MentorLake.Gtk.GtkExpanderHandle expander)
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		return GtkExpanderHandleExterns.gtk_expander_get_use_underline(expander);
	}

	public static T SetExpanded<T>(this T expander, bool expanded) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_expanded(expander, expanded);
		return expander;
	}

	public static T SetLabel<T>(this T expander, string label) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_label(expander, label);
		return expander;
	}

	public static T SetLabelFill<T>(this T expander, bool label_fill) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_label_fill(expander, label_fill);
		return expander;
	}

	public static T SetLabelWidget<T>(this T expander, MentorLake.Gtk.GtkWidgetHandle label_widget) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_label_widget(expander, label_widget);
		return expander;
	}

	public static T SetResizeToplevel<T>(this T expander, bool resize_toplevel) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_resize_toplevel(expander, resize_toplevel);
		return expander;
	}

	public static T SetSpacing<T>(this T expander, int spacing) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_spacing(expander, spacing);
		return expander;
	}

	public static T SetUseMarkup<T>(this T expander, bool use_markup) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_use_markup(expander, use_markup);
		return expander;
	}

	public static T SetUseUnderline<T>(this T expander, bool use_underline) where T : GtkExpanderHandle
	{
		if (expander.IsInvalid) throw new Exception("Invalid handle (GtkExpanderHandle)");
		GtkExpanderHandleExterns.gtk_expander_set_use_underline(expander, use_underline);
		return expander;
	}

}

internal class GtkExpanderHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))]
	internal static extern MentorLake.Gtk.GtkExpanderHandle gtk_expander_new(string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))]
	internal static extern MentorLake.Gtk.GtkExpanderHandle gtk_expander_new_with_mnemonic(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_expander_get_expanded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_expander_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_expander_get_label_fill([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_expander_get_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_expander_get_resize_toplevel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_expander_get_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_expander_get_use_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_expander_get_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_expanded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, bool expanded);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_label_fill([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, bool label_fill);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_resize_toplevel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, bool resize_toplevel);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_spacing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, int spacing);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_use_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, bool use_markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_expander_set_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkExpanderHandle>))] MentorLake.Gtk.GtkExpanderHandle expander, bool use_underline);

}
