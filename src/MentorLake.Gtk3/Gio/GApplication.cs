namespace MentorLake.Gtk3.Gio;

public class GApplicationHandle : GObjectHandle, GActionGroupHandle, GActionMapHandle
{
	public static GApplicationHandle New(string application_id, GApplicationFlags flags)
	{
		return GApplicationExterns.g_application_new(application_id, flags);
	}

	public static GApplicationHandle GetDefault()
	{
		return GApplicationExterns.g_application_get_default();
	}

	public static bool IdIsValid(string application_id)
	{
		return GApplicationExterns.g_application_id_is_valid(application_id);
	}

}

public static class GApplicationSignalExtensions
{

	public static IObservable<GApplicationSignalStructs.ActivateSignal> Signal_Activate(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.ActivateSignal> obs) =>
		{
			GApplicationSignalDelegates.activate handler = (GApplicationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.CommandLineSignal> Signal_CommandLine(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.CommandLineSignal> obs) =>
		{
			GApplicationSignalDelegates.command_line handler = (GApplicationHandle self, GApplicationCommandLineHandle command_line, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.CommandLineSignal()
				{
					Self = self, CommandLine = command_line, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "command_line", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.HandleLocalOptionsSignal> Signal_HandleLocalOptions(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.HandleLocalOptionsSignal> obs) =>
		{
			GApplicationSignalDelegates.handle_local_options handler = (GApplicationHandle self, GVariantDictHandle options, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.HandleLocalOptionsSignal()
				{
					Self = self, Options = options, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "handle_local_options", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.NameLostSignal> Signal_NameLost(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.NameLostSignal> obs) =>
		{
			GApplicationSignalDelegates.name_lost handler = (GApplicationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.NameLostSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "name_lost", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.OpenSignal> Signal_Open(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.OpenSignal> obs) =>
		{
			GApplicationSignalDelegates.open handler = (GApplicationHandle self, IntPtr files, int n_files, string hint, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.OpenSignal()
				{
					Self = self, Files = files, NFiles = n_files, Hint = hint, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "open", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.ShutdownSignal> Signal_Shutdown(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.ShutdownSignal> obs) =>
		{
			GApplicationSignalDelegates.shutdown handler = (GApplicationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.ShutdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "shutdown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GApplicationSignalStructs.StartupSignal> Signal_Startup(this GApplicationHandle instance)
	{
		return Observable.Create((IObserver<GApplicationSignalStructs.StartupSignal> obs) =>
		{
			GApplicationSignalDelegates.startup handler = (GApplicationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationSignalStructs.StartupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "startup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GApplicationSignalStructs
{

public struct ActivateSignal
{
	public GApplicationHandle Self;
	public IntPtr UserData;
}

public struct CommandLineSignal
{
	public GApplicationHandle Self;
	public GApplicationCommandLineHandle CommandLine;
	public IntPtr UserData;
	public int ReturnValue;
}

public struct HandleLocalOptionsSignal
{
	public GApplicationHandle Self;
	public GVariantDictHandle Options;
	public IntPtr UserData;
	public int ReturnValue;
}

public struct NameLostSignal
{
	public GApplicationHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct OpenSignal
{
	public GApplicationHandle Self;
	public IntPtr Files;
	public int NFiles;
	public string Hint;
	public IntPtr UserData;
}

public struct ShutdownSignal
{
	public GApplicationHandle Self;
	public IntPtr UserData;
}

public struct StartupSignal
{
	public GApplicationHandle Self;
	public IntPtr UserData;
}
}

public static class GApplicationSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int command_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationCommandLineHandle>))] GApplicationCommandLineHandle command_line, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int handle_local_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVariantDictHandle>))] GVariantDictHandle options, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool name_lost([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void open([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, IntPtr files, int n_files, string hint, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void shutdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void startup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GApplicationHandle>))] GApplicationHandle self, IntPtr user_data);

}


public static class GApplicationHandleExtensions
{
	public static T Activate<T>(this T application) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_activate(application);
		return application;
	}

	public static T AddMainOption<T>(this T application, string long_name, char short_name, GOptionFlags flags, GOptionArg arg, string description, string arg_description) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_add_main_option(application, long_name, short_name, flags, arg, description, arg_description);
		return application;
	}

	public static T AddMainOptionEntries<T>(this T application, GOptionEntry[] entries) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_add_main_option_entries(application, entries);
		return application;
	}

	public static T AddOptionGroup<T>(this T application, GOptionGroupHandle group) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_add_option_group(application, group);
		return application;
	}

	public static T BindBusyProperty<T>(this T application, GObjectHandle @object, string property) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_bind_busy_property(application, @object, property);
		return application;
	}

	public static string GetApplicationId(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_application_id(application);
	}

	public static GDBusConnectionHandle GetDbusConnection(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_dbus_connection(application);
	}

	public static string GetDbusObjectPath(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_dbus_object_path(application);
	}

	public static GApplicationFlags GetFlags(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_flags(application);
	}

	public static uint GetInactivityTimeout(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_inactivity_timeout(application);
	}

	public static bool GetIsBusy(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_busy(application);
	}

	public static bool GetIsRegistered(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_registered(application);
	}

	public static bool GetIsRemote(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_is_remote(application);
	}

	public static string GetResourceBasePath(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_resource_base_path(application);
	}

	public static string GetVersion(this GApplicationHandle application)
	{
		return GApplicationExterns.g_application_get_version(application);
	}

	public static T Hold<T>(this T application) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_hold(application);
		return application;
	}

	public static T MarkBusy<T>(this T application) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_mark_busy(application);
		return application;
	}

	public static T Open<T>(this T application, GFileHandle[] files, int n_files, string hint) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_open(application, files, n_files, hint);
		return application;
	}

	public static T Quit<T>(this T application) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_quit(application);
		return application;
	}

	public static bool Register(this GApplicationHandle application, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GApplicationExterns.g_application_register(application, cancellable, out error);
	}

	public static T Release<T>(this T application) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_release(application);
		return application;
	}

	public static int Run(this GApplicationHandle application, int argc, string[] argv)
	{
		return GApplicationExterns.g_application_run(application, argc, argv);
	}

	public static T SendNotification<T>(this T application, string id, GNotificationHandle notification) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_send_notification(application, id, notification);
		return application;
	}

	public static T SetActionGroup<T>(this T application, GActionGroupHandle action_group) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_set_action_group(application, action_group);
		return application;
	}

	public static T SetApplicationId<T>(this T application, string application_id) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_set_application_id(application, application_id);
		return application;
	}

	public static T SetDefault<T>(this T application) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_set_default(application);
		return application;
	}

	public static T SetFlags<T>(this T application, GApplicationFlags flags) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_set_flags(application, flags);
		return application;
	}

	public static T SetInactivityTimeout<T>(this T application, uint inactivity_timeout) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_set_inactivity_timeout(application, inactivity_timeout);
		return application;
	}

	public static T SetOptionContextDescription<T>(this T application, string description) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_set_option_context_description(application, description);
		return application;
	}

	public static T SetOptionContextParameterString<T>(this T application, string parameter_string) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_set_option_context_parameter_string(application, parameter_string);
		return application;
	}

	public static T SetOptionContextSummary<T>(this T application, string summary) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_set_option_context_summary(application, summary);
		return application;
	}

	public static T SetResourceBasePath<T>(this T application, string resource_path) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_set_resource_base_path(application, resource_path);
		return application;
	}

	public static T SetVersion<T>(this T application, string version) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_set_version(application, version);
		return application;
	}

	public static T UnbindBusyProperty<T>(this T application, GObjectHandle @object, string property) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_unbind_busy_property(application, @object, property);
		return application;
	}

	public static T UnmarkBusy<T>(this T application) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_unmark_busy(application);
		return application;
	}

	public static T WithdrawNotification<T>(this T application, string id) where T : GApplicationHandle
	{
		GApplicationExterns.g_application_withdraw_notification(application, id);
		return application;
	}

}

internal class GApplicationExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GApplicationHandle g_application_new(string application_id, GApplicationFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_activate(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_add_main_option(GApplicationHandle application, string long_name, char short_name, GOptionFlags flags, GOptionArg arg, string description, string arg_description);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_add_main_option_entries(GApplicationHandle application, GOptionEntry[] entries);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_add_option_group(GApplicationHandle application, GOptionGroupHandle group);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_bind_busy_property(GApplicationHandle application, GObjectHandle @object, string property);

	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_application_id(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_application_get_dbus_connection(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_dbus_object_path(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern GApplicationFlags g_application_get_flags(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_application_get_inactivity_timeout(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_get_is_busy(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_get_is_registered(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_get_is_remote(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_resource_base_path(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern string g_application_get_version(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_hold(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_mark_busy(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_open(GApplicationHandle application, GFileHandle[] files, int n_files, string hint);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_quit(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_register(GApplicationHandle application, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_release(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern int g_application_run(GApplicationHandle application, int argc, string[] argv);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_send_notification(GApplicationHandle application, string id, GNotificationHandle notification);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_action_group(GApplicationHandle application, GActionGroupHandle action_group);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_application_id(GApplicationHandle application, string application_id);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_default(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_flags(GApplicationHandle application, GApplicationFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_inactivity_timeout(GApplicationHandle application, uint inactivity_timeout);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_option_context_description(GApplicationHandle application, string description);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_option_context_parameter_string(GApplicationHandle application, string parameter_string);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_option_context_summary(GApplicationHandle application, string summary);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_resource_base_path(GApplicationHandle application, string resource_path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_set_version(GApplicationHandle application, string version);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_unbind_busy_property(GApplicationHandle application, GObjectHandle @object, string property);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_unmark_busy(GApplicationHandle application);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_withdraw_notification(GApplicationHandle application, string id);

	[DllImport(Libraries.Gio)]
	internal static extern GApplicationHandle g_application_get_default();

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_id_is_valid(string application_id);

}
