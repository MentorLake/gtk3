namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GApplication` is the core class for application support.
/// </para>
/// <para>
/// A `GApplication` is the foundation of an application. It wraps some
/// low-level platform-specific services and is intended to act as the
/// foundation for higher-level application classes such as
/// `GtkApplication` or `MxApplication`. In general, you should not use
/// this class outside of a higher level framework.
/// </para>
/// <para>
/// `GApplication` provides convenient life-cycle management by maintaining
/// a "use count" for the primary application instance. The use count can
/// be changed using [method@Gio.Application.hold] and
/// [method@Gio.Application.release]. If it drops to zero, the application
/// exits. Higher-level classes such as `GtkApplication` employ the use count
/// to ensure that the application stays alive as long as it has any opened
/// windows.
/// </para>
/// <para>
/// Another feature that `GApplication` (optionally) provides is process
/// uniqueness. Applications can make use of this functionality by
/// providing a unique application ID. If given, only one application
/// with this ID can be running at a time per session. The session
/// concept is platform-dependent, but corresponds roughly to a graphical
/// desktop login. When your application is launched again, its
/// arguments are passed through platform communication to the already
/// running program. The already running instance of the program is
/// called the "primary instance"; for non-unique applications this is
/// always the current instance. On Linux, the D-Bus session bus
/// is used for communication.
/// </para>
/// <para>
/// The use of `GApplication` differs from some other commonly-used
/// uniqueness libraries (such as libunique) in important ways. The
/// application is not expected to manually register itself and check
/// if it is the primary instance. Instead, the main() function of a
/// `GApplication` should do very little more than instantiating the
/// application instance, possibly connecting signal handlers, then
/// calling [method@Gio.Application.run]. All checks for uniqueness are done
/// internally. If the application is the primary instance then the
/// startup signal is emitted and the mainloop runs. If the application
/// is not the primary instance then a signal is sent to the primary
/// instance and [method@Gio.Application.run] promptly returns. See the code
/// examples below.
/// </para>
/// <para>
/// If used, the expected form of an application identifier is the
/// same as that of a
/// [D-Bus well-known bus name](https://dbus.freedesktop.org/doc/dbus-specification.html#message-protocol-names-bus).
/// Examples include: `com.example.MyApp`, `org.example.internal_apps.Calculator`,
/// `org._7_zip.Archiver`.
/// For details on valid application identifiers, see [func@Gio.Application.id_is_valid].
/// </para>
/// <para>
/// On Linux, the application identifier is claimed as a well-known bus name
/// on the user's session bus. This means that the uniqueness of your
/// application is scoped to the current session. It also means that your
/// application may provide additional services (through registration of other
/// object paths) at that bus name. The registration of these object paths
/// should be done with the shared GDBus session bus. Note that due to the
/// internal architecture of GDBus, method calls can be dispatched at any time
/// (even if a main loop is not running). For this reason, you must ensure that
/// any object paths that you wish to register are registered before #GApplication
/// attempts to acquire the bus name of your application (which happens in
/// [method@Gio.Application.register]). Unfortunately, this means that you cannot
/// use [property@Gio.Application:is-remote] to decide if you want to register
/// object paths.
/// </para>
/// <para>
/// `GApplication` also implements the [iface@Gio.ActionGroup] and [iface@Gio.ActionMap]
/// interfaces and lets you easily export actions by adding them with
/// [method@Gio.ActionMap.add_action]. When invoking an action by calling
/// [method@Gio.ActionGroup.activate_action] on the application, it is always
/// invoked in the primary instance. The actions are also exported on
/// the session bus, and GIO provides the [class@Gio.DBusActionGroup] wrapper to
/// conveniently access them remotely. GIO provides a [class@Gio.DBusMenuModel] wrapper
/// for remote access to exported [class@Gio.MenuModel]s.
/// </para>
/// <para>
/// Note: Due to the fact that actions are exported on the session bus,
/// using `maybe` parameters is not supported, since D-Bus does not support
/// `maybe` types.
/// </para>
/// <para>
/// There is a number of different entry points into a `GApplication`:
/// </para>
/// <para>
/// - via 'Activate' (i.e. just starting the application)
/// </para>
/// <para>
/// - via 'Open' (i.e. opening some files)
/// </para>
/// <para>
/// - by handling a command-line
/// </para>
/// <para>
/// - via activating an action
/// </para>
/// <para>
/// The [signal@Gio.Application::startup] signal lets you handle the application
/// initialization for all of these in a single place.
/// </para>
/// <para>
/// Regardless of which of these entry points is used to start the
/// application, `GApplication` passes some ‘platform data’ from the
/// launching instance to the primary instance, in the form of a
/// [struct@GLib.Variant] dictionary mapping strings to variants. To use platform
/// data, override the [vfunc@Gio.Application.before_emit] or
/// [vfunc@Gio.Application.after_emit] virtual functions
/// in your `GApplication` subclass. When dealing with
/// [class@Gio.ApplicationCommandLine] objects, the platform data is
/// directly available via [method@Gio.ApplicationCommandLine.get_cwd],
/// [method@Gio.ApplicationCommandLine.get_environ] and
/// [method@Gio.ApplicationCommandLine.get_platform_data].
/// </para>
/// <para>
/// As the name indicates, the platform data may vary depending on the
/// operating system, but it always includes the current directory (key
/// `cwd`), and optionally the environment (ie the set of environment
/// variables and their values) of the calling process (key `environ`).
/// The environment is only added to the platform data if the
/// `G_APPLICATION_SEND_ENVIRONMENT` flag is set. `GApplication` subclasses
/// can add their own platform data by overriding the
/// [vfunc@Gio.Application.add_platform_data] virtual function. For instance,
/// `GtkApplication` adds startup notification data in this way.
/// </para>
/// <para>
/// To parse commandline arguments you may handle the
/// [signal@Gio.Application::command-line] signal or override the
/// [vfunc@Gio.Application.local_command_line] virtual function, to parse them in
/// either the primary instance or the local instance, respectively.
/// </para>
/// <para>
/// For an example of opening files with a `GApplication`, see
/// [gapplication-example-open.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gapplication-example-open.c).
/// </para>
/// <para>
/// For an example of using actions with `GApplication`, see
/// [gapplication-example-actions.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gapplication-example-actions.c).
/// </para>
/// <para>
/// For an example of using extra D-Bus hooks with `GApplication`, see
/// [gapplication-example-dbushooks.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gapplication-example-dbushooks.c).
/// </para>
/// </summary>

public class GApplicationHandle : GObjectHandle, GActionGroupHandle, GActionMapHandle
{
/// <summary>
/// <para>
/// Creates a new #GApplication instance.
/// </para>
/// <para>
/// If non-%NULL, the application id must be valid.  See
/// g_application_id_is_valid().
/// </para>
/// <para>
/// If no application ID is given then some features of #GApplication
/// (most notably application uniqueness) will be disabled.
/// </para>
/// </summary>

/// <param name="application_id">
/// the application id
/// </param>
/// <param name="flags">
/// the application flags
/// </param>
/// <return>
/// a new #GApplication instance
/// </return>

	public static MentorLake.Gio.GApplicationHandle New(string application_id, MentorLake.Gio.GApplicationFlags flags)
	{
		return GApplicationHandleExterns.g_application_new(application_id, flags);
	}

/// <summary>
/// <para>
/// Returns the default #GApplication instance for this process.
/// </para>
/// <para>
/// Normally there is only one #GApplication per process and it becomes
/// the default when it is created.  You can exercise more control over
/// this by using g_application_set_default().
/// </para>
/// <para>
/// If there is no default application then %NULL is returned.
/// </para>
/// </summary>

/// <return>
/// the default application for this process, or %NULL
/// </return>

	public static MentorLake.Gio.GApplicationHandle GetDefault()
	{
		return GApplicationHandleExterns.g_application_get_default();
	}

/// <summary>
/// <para>
/// Checks if @application_id is a valid application identifier.
/// </para>
/// <para>
/// A valid ID is required for calls to g_application_new() and
/// g_application_set_application_id().
/// </para>
/// <para>
/// Application identifiers follow the same format as
/// [D-Bus well-known bus names](https://dbus.freedesktop.org/doc/dbus-specification.html#message-protocol-names-bus).
/// For convenience, the restrictions on application identifiers are
/// reproduced here:
/// </para>
/// <para>
/// - Application identifiers are composed of 1 or more elements separated by a
///   period (`.`) character. All elements must contain at least one character.
/// </para>
/// <para>
/// - Each element must only contain the ASCII characters `[A-Z][a-z][0-9]_-`,
///   with `-` discouraged in new application identifiers. Each element must not
///   begin with a digit.
/// </para>
/// <para>
/// - Application identifiers must contain at least one `.` (period) character
///   (and thus at least two elements).
/// </para>
/// <para>
/// - Application identifiers must not begin with a `.` (period) character.
/// </para>
/// <para>
/// - Application identifiers must not exceed 255 characters.
/// </para>
/// <para>
/// Note that the hyphen (`-`) character is allowed in application identifiers,
/// but is problematic or not allowed in various specifications and APIs that
/// refer to D-Bus, such as
/// [Flatpak application IDs](http://docs.flatpak.org/en/latest/introduction.html#identifiers),
/// the
/// [`DBusActivatable` interface in the Desktop Entry Specification](https://specifications.freedesktop.org/desktop-entry-spec/desktop-entry-spec-latest.html#dbus),
/// and the convention that an application's "main" interface and object path
/// resemble its application identifier and bus name. To avoid situations that
/// require special-case handling, it is recommended that new application
/// identifiers consistently replace hyphens with underscores.
/// </para>
/// <para>
/// Like D-Bus interface names, application identifiers should start with the
/// reversed DNS domain name of the author of the interface (in lower-case), and
/// it is conventional for the rest of the application identifier to consist of
/// words run together, with initial capital letters.
/// </para>
/// <para>
/// As with D-Bus interface names, if the author's DNS domain name contains
/// hyphen/minus characters they should be replaced by underscores, and if it
/// contains leading digits they should be escaped by prepending an underscore.
/// For example, if the owner of 7-zip.org used an application identifier for an
/// archiving application, it might be named `org._7_zip.Archiver`.
/// </para>
/// </summary>

/// <param name="application_id">
/// a potential application identifier
/// </param>
/// <return>
/// %TRUE if @application_id is valid
/// </return>

	public static bool IdIsValid(string application_id)
	{
		return GApplicationHandleExterns.g_application_id_is_valid(application_id);
	}

}
public static class GApplicationHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::activate signal is emitted on the primary instance when an
/// activation occurs. See g_application_activate().
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.ActivateSignal> Signal_Activate(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ActivateSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.activate handler = ( MentorLake.Gio.GApplicationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ActivateSignal()
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
/// <summary>
/// <para>
/// The ::command-line signal is emitted on the primary instance when
/// a commandline is not handled locally. See g_application_run() and
/// the #GApplicationCommandLine documentation for more information.
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.CommandLineSignal> Signal_CommandLine(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.CommandLineSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.command_line handler = ( MentorLake.Gio.GApplicationHandle self,  MentorLake.Gio.GApplicationCommandLineHandle command_line,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.CommandLineSignal()
				{
					Self = self, CommandLine = command_line, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "command-line", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::handle-local-options signal is emitted on the local instance
/// after the parsing of the commandline options has occurred.
/// </para>
/// <para>
/// You can add options to be recognised during commandline option
/// parsing using g_application_add_main_option_entries() and
/// g_application_add_option_group().
/// </para>
/// <para>
/// Signal handlers can inspect @options (along with values pointed to
/// from the @arg_data of an installed #GOptionEntrys) in order to
/// decide to perform certain actions, including direct local handling
/// (which may be useful for options like --version).
/// </para>
/// <para>
/// In the event that the application is marked
/// %G_APPLICATION_HANDLES_COMMAND_LINE the "normal processing" will
/// send the @options dictionary to the primary instance where it can be
/// read with g_application_command_line_get_options_dict().  The signal
/// handler can modify the dictionary before returning, and the
/// modified dictionary will be sent.
/// </para>
/// <para>
/// In the event that %G_APPLICATION_HANDLES_COMMAND_LINE is not set,
/// "normal processing" will treat the remaining uncollected command
/// line arguments as filenames or URIs.  If there are no arguments,
/// the application is activated by g_application_activate().  One or
/// more arguments results in a call to g_application_open().
/// </para>
/// <para>
/// If you want to handle the local commandline arguments for yourself
/// by converting them to calls to g_application_open() or
/// g_action_group_activate_action() then you must be sure to register
/// the application first.  You should probably not call
/// g_application_activate() for yourself, however: just return -1 and
/// allow the default handler to do it for you.  This will ensure that
/// the `--gapplication-service` switch works properly (i.e. no activation
/// in that case).
/// </para>
/// <para>
/// Note that this signal is emitted from the default implementation of
/// local_command_line().  If you override that function and don't
/// chain up then this signal will never be emitted.
/// </para>
/// <para>
/// You can override local_command_line() if you need more powerful
/// capabilities than what is provided here, but this should not
/// normally be required.
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.HandleLocalOptionsSignal> Signal_HandleLocalOptions(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.HandleLocalOptionsSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.handle_local_options handler = ( MentorLake.Gio.GApplicationHandle self,  MentorLake.GLib.GVariantDictHandle options,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.HandleLocalOptionsSignal()
				{
					Self = self, Options = options, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "handle-local-options", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::name-lost signal is emitted only on the registered primary instance
/// when a new instance has taken over. This can only happen if the application
/// is using the %G_APPLICATION_ALLOW_REPLACEMENT flag.
/// </para>
/// <para>
/// The default handler for this signal calls g_application_quit().
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.NameLostSignal> Signal_NameLost(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.NameLostSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.name_lost handler = ( MentorLake.Gio.GApplicationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.NameLostSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "name-lost", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::open signal is emitted on the primary instance when there are
/// files to open. See g_application_open() for more information.
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.OpenSignal> Signal_Open(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.OpenSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.open handler = ( MentorLake.Gio.GApplicationHandle self,  MentorLake.Gio.GFileHandle[] files,  int n_files,  string hint,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.OpenSignal()
				{
					Self = self, Files = files, NFiles = n_files, Hint = hint, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "open", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::shutdown signal is emitted only on the registered primary instance
/// immediately after the main loop terminates.
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.ShutdownSignal> Signal_Shutdown(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ShutdownSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.shutdown handler = ( MentorLake.Gio.GApplicationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ShutdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "shutdown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::startup signal is emitted on the primary instance immediately
/// after registration. See g_application_register().
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.StartupSignal> Signal_Startup(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.StartupSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.startup handler = ( MentorLake.Gio.GApplicationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.StartupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "startup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that a new action was just added to the group.
/// </para>
/// <para>
/// This signal is emitted after the action has been added
/// and is now visible.
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.ActionAddedSignal> Signal_ActionAdded(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ActionAddedSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.action_added handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ActionAddedSignal()
				{
					Self = self, ActionName = action_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that the enabled status of the named action has changed.
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.ActionEnabledChangedSignal> Signal_ActionEnabledChanged(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ActionEnabledChangedSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.action_enabled_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  bool enabled,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ActionEnabledChangedSignal()
				{
					Self = self, ActionName = action_name, Enabled = enabled, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-enabled-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that an action is just about to be removed from the group.
/// </para>
/// <para>
/// This signal is emitted before the action is removed, so the action
/// is still visible and can be queried from the signal handler.
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.ActionRemovedSignal> Signal_ActionRemoved(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ActionRemovedSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.action_removed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ActionRemovedSignal()
				{
					Self = self, ActionName = action_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Signals that the state of the named action has changed.
/// </para>
/// </summary>

	public static IObservable<GApplicationHandleSignalStructs.ActionStateChangedSignal> Signal_ActionStateChanged(this GApplicationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GApplicationHandleSignalStructs.ActionStateChangedSignal> obs) =>
		{
			GApplicationHandleSignalDelegates.action_state_changed handler = ( MentorLake.Gio.GActionGroupHandle self,  string action_name,  MentorLake.GLib.GVariantHandle value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GApplicationHandleSignalStructs.ActionStateChangedSignal()
				{
					Self = self, ActionName = action_name, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-state-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GApplicationHandleSignalStructs
{

public class ActivateSignal
{

	public MentorLake.Gio.GApplicationHandle Self;

	public IntPtr UserData;
}

public class CommandLineSignal
{

	public MentorLake.Gio.GApplicationHandle Self;
/// <summary>
/// <para>
/// a #GApplicationCommandLine representing the
///     passed commandline
/// </para>
/// </summary>

	public MentorLake.Gio.GApplicationCommandLineHandle CommandLine;

	public IntPtr UserData;
/// <summary>
/// <para>
/// An integer that is set as the exit status for the calling
///   process. See g_application_command_line_set_exit_status().
/// </para>
/// </summary>

	public int ReturnValue;
}

public class HandleLocalOptionsSignal
{

	public MentorLake.Gio.GApplicationHandle Self;
/// <summary>
/// <para>
/// the options dictionary
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantDictHandle Options;

	public IntPtr UserData;
/// <summary>
/// <para>
/// an exit code. If you have handled your options and want
/// to exit the process, return a non-negative option, 0 for success,
/// and a positive value for failure. To continue, return -1 to let
/// the default option processing continue.
/// </para>
/// </summary>

	public int ReturnValue;
}

public class NameLostSignal
{

	public MentorLake.Gio.GApplicationHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the signal has been handled
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class OpenSignal
{

	public MentorLake.Gio.GApplicationHandle Self;
/// <summary>
/// <para>
/// an array of #GFiles
/// </para>
/// </summary>

	public MentorLake.Gio.GFileHandle[] Files;
/// <summary>
/// <para>
/// the length of @files
/// </para>
/// </summary>

	public int NFiles;
/// <summary>
/// <para>
/// a hint provided by the calling instance
/// </para>
/// </summary>

	public string Hint;

	public IntPtr UserData;
}

public class ShutdownSignal
{

	public MentorLake.Gio.GApplicationHandle Self;

	public IntPtr UserData;
}

public class StartupSignal
{

	public MentorLake.Gio.GApplicationHandle Self;

	public IntPtr UserData;
}

public class ActionAddedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;

	public IntPtr UserData;
}

public class ActionEnabledChangedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;
/// <summary>
/// <para>
/// whether the action is enabled
/// </para>
/// </summary>

	public bool Enabled;

	public IntPtr UserData;
}

public class ActionRemovedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;

	public IntPtr UserData;
}

public class ActionStateChangedSignal
{

	public MentorLake.Gio.GActionGroupHandle Self;
/// <summary>
/// <para>
/// the name of the action in @action_group
/// </para>
/// </summary>

	public string ActionName;
/// <summary>
/// <para>
/// the new value of the state
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantHandle Value;

	public IntPtr UserData;
}
}

public static class GApplicationHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::activate signal is emitted on the primary instance when an
/// activation occurs. See g_application_activate().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::command-line signal is emitted on the primary instance when
/// a commandline is not handled locally. See g_application_run() and
/// the #GApplicationCommandLine documentation for more information.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="command_line">
/// a #GApplicationCommandLine representing the
///     passed commandline
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// An integer that is set as the exit status for the calling
///   process. See g_application_command_line_set_exit_status().
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int command_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle command_line, IntPtr user_data);


/// <summary>
/// <para>
/// The ::handle-local-options signal is emitted on the local instance
/// after the parsing of the commandline options has occurred.
/// </para>
/// <para>
/// You can add options to be recognised during commandline option
/// parsing using g_application_add_main_option_entries() and
/// g_application_add_option_group().
/// </para>
/// <para>
/// Signal handlers can inspect @options (along with values pointed to
/// from the @arg_data of an installed #GOptionEntrys) in order to
/// decide to perform certain actions, including direct local handling
/// (which may be useful for options like --version).
/// </para>
/// <para>
/// In the event that the application is marked
/// %G_APPLICATION_HANDLES_COMMAND_LINE the "normal processing" will
/// send the @options dictionary to the primary instance where it can be
/// read with g_application_command_line_get_options_dict().  The signal
/// handler can modify the dictionary before returning, and the
/// modified dictionary will be sent.
/// </para>
/// <para>
/// In the event that %G_APPLICATION_HANDLES_COMMAND_LINE is not set,
/// "normal processing" will treat the remaining uncollected command
/// line arguments as filenames or URIs.  If there are no arguments,
/// the application is activated by g_application_activate().  One or
/// more arguments results in a call to g_application_open().
/// </para>
/// <para>
/// If you want to handle the local commandline arguments for yourself
/// by converting them to calls to g_application_open() or
/// g_action_group_activate_action() then you must be sure to register
/// the application first.  You should probably not call
/// g_application_activate() for yourself, however: just return -1 and
/// allow the default handler to do it for you.  This will ensure that
/// the `--gapplication-service` switch works properly (i.e. no activation
/// in that case).
/// </para>
/// <para>
/// Note that this signal is emitted from the default implementation of
/// local_command_line().  If you override that function and don't
/// chain up then this signal will never be emitted.
/// </para>
/// <para>
/// You can override local_command_line() if you need more powerful
/// capabilities than what is provided here, but this should not
/// normally be required.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="options">
/// the options dictionary
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// an exit code. If you have handled your options and want
/// to exit the process, return a non-negative option, 0 for success,
/// and a positive value for failure. To continue, return -1 to let
/// the default option processing continue.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int handle_local_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle options, IntPtr user_data);


/// <summary>
/// <para>
/// The ::name-lost signal is emitted only on the registered primary instance
/// when a new instance has taken over. This can only happen if the application
/// is using the %G_APPLICATION_ALLOW_REPLACEMENT flag.
/// </para>
/// <para>
/// The default handler for this signal calls g_application_quit().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the signal has been handled
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool name_lost([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::open signal is emitted on the primary instance when there are
/// files to open. See g_application_open() for more information.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="files">
/// an array of #GFiles
/// </param>
/// <param name="n_files">
/// the length of @files
/// </param>
/// <param name="hint">
/// a hint provided by the calling instance
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void open([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle[] files, int n_files, string hint, IntPtr user_data);


/// <summary>
/// <para>
/// The ::shutdown signal is emitted only on the registered primary instance
/// immediately after the main loop terminates.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void shutdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::startup signal is emitted on the primary instance immediately
/// after registration. See g_application_register().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void startup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that a new action was just added to the group.
/// </para>
/// <para>
/// This signal is emitted after the action has been added
/// and is now visible.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that the enabled status of the named action has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="enabled">
/// whether the action is enabled
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_enabled_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, bool enabled, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that an action is just about to be removed from the group.
/// </para>
/// <para>
/// This signal is emitted before the action is removed, so the action
/// is still visible and can be queried from the signal handler.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, IntPtr user_data);


/// <summary>
/// <para>
/// Signals that the state of the named action has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="action_name">
/// the name of the action in @action_group
/// </param>
/// <param name="value">
/// the new value of the state
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle self, string action_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr user_data);

}


public static class GApplicationHandleExtensions
{
/// <summary>
/// <para>
/// Activates the application.
/// </para>
/// <para>
/// In essence, this results in the #GApplication::activate signal being
/// emitted in the primary instance.
/// </para>
/// <para>
/// The application must be registered before calling this function.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>

	public static T Activate<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_activate(application);
		return application;
	}

/// <summary>
/// <para>
/// Add an option to be handled by @application.
/// </para>
/// <para>
/// Calling this function is the equivalent of calling
/// g_application_add_main_option_entries() with a single #GOptionEntry
/// that has its arg_data member set to %NULL.
/// </para>
/// <para>
/// The parsed arguments will be packed into a #GVariantDict which
/// is passed to #GApplication::handle-local-options. If
/// %G_APPLICATION_HANDLES_COMMAND_LINE is set, then it will also
/// be sent to the primary instance. See
/// g_application_add_main_option_entries() for more details.
/// </para>
/// <para>
/// See #GOptionEntry for more documentation of the arguments.
/// </para>
/// </summary>

/// <param name="application">
/// the #GApplication
/// </param>
/// <param name="long_name">
/// the long name of an option used to specify it in a commandline
/// </param>
/// <param name="short_name">
/// the short name of an option
/// </param>
/// <param name="flags">
/// flags from #GOptionFlags
/// </param>
/// <param name="arg">
/// the type of the option, as a #GOptionArg
/// </param>
/// <param name="description">
/// the description for the option in `--help` output
/// </param>
/// <param name="arg_description">
/// the placeholder to use for the extra argument
///    parsed by the option in `--help` output
/// </param>

	public static T AddMainOption<T>(this T application, string long_name, char short_name, MentorLake.GLib.GOptionFlags flags, MentorLake.GLib.GOptionArg arg, string description, string arg_description) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_add_main_option(application, long_name, short_name, flags, arg, description, arg_description);
		return application;
	}

/// <summary>
/// <para>
/// Adds main option entries to be handled by @application.
/// </para>
/// <para>
/// This function is comparable to g_option_context_add_main_entries().
/// </para>
/// <para>
/// After the commandline arguments are parsed, the
/// #GApplication::handle-local-options signal will be emitted.  At this
/// point, the application can inspect the values pointed to by @arg_data
/// in the given #GOptionEntrys.
/// </para>
/// <para>
/// Unlike #GOptionContext, #GApplication supports giving a %NULL
/// @arg_data for a non-callback #GOptionEntry.  This results in the
/// argument in question being packed into a #GVariantDict which is also
/// passed to #GApplication::handle-local-options, where it can be
/// inspected and modified.  If %G_APPLICATION_HANDLES_COMMAND_LINE is
/// set, then the resulting dictionary is sent to the primary instance,
/// where g_application_command_line_get_options_dict() will return it.
/// As it has been passed outside the process at this point, the types of all
/// values in the options dict must be checked before being used.
/// This "packing" is done according to the type of the argument --
/// booleans for normal flags, strings for strings, bytestrings for
/// filenames, etc.  The packing only occurs if the flag is given (ie: we
/// do not pack a "false" #GVariant in the case that a flag is missing).
/// </para>
/// <para>
/// In general, it is recommended that all commandline arguments are
/// parsed locally.  The options dictionary should then be used to
/// transmit the result of the parsing to the primary instance, where
/// g_variant_dict_lookup() can be used.  For local options, it is
/// possible to either use @arg_data in the usual way, or to consult (and
/// potentially remove) the option from the options dictionary.
/// </para>
/// <para>
/// This function is new in GLib 2.40.  Before then, the only real choice
/// was to send all of the commandline arguments (options and all) to the
/// primary instance for handling.  #GApplication ignored them completely
/// on the local side.  Calling this function "opts in" to the new
/// behaviour, and in particular, means that unrecognized options will be
/// treated as errors.  Unrecognized options have never been ignored when
/// %G_APPLICATION_HANDLES_COMMAND_LINE is unset.
/// </para>
/// <para>
/// If #GApplication::handle-local-options needs to see the list of
/// filenames, then the use of %G_OPTION_REMAINING is recommended.  If
/// @arg_data is %NULL then %G_OPTION_REMAINING can be used as a key into
/// the options dictionary.  If you do use %G_OPTION_REMAINING then you
/// need to handle these arguments for yourself because once they are
/// consumed, they will no longer be visible to the default handling
/// (which treats them as filenames to be opened).
/// </para>
/// <para>
/// It is important to use the proper GVariant format when retrieving
/// the options with g_variant_dict_lookup():
/// - for %G_OPTION_ARG_NONE, use `b`
/// - for %G_OPTION_ARG_STRING, use `&s`
/// - for %G_OPTION_ARG_INT, use `i`
/// - for %G_OPTION_ARG_INT64, use `x`
/// - for %G_OPTION_ARG_DOUBLE, use `d`
/// - for %G_OPTION_ARG_FILENAME, use `^&ay`
/// - for %G_OPTION_ARG_STRING_ARRAY, use `^a&s`
/// - for %G_OPTION_ARG_FILENAME_ARRAY, use `^a&ay`
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="entries">
/// the
///   main options for the application
/// </param>

	public static T AddMainOptionEntries<T>(this T application, MentorLake.GLib.GOptionEntryHandle[] entries) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_add_main_option_entries(application, entries);
		return application;
	}

/// <summary>
/// <para>
/// Adds a #GOptionGroup to the commandline handling of @application.
/// </para>
/// <para>
/// This function is comparable to g_option_context_add_group().
/// </para>
/// <para>
/// Unlike g_application_add_main_option_entries(), this function does
/// not deal with %NULL @arg_data and never transmits options to the
/// primary instance.
/// </para>
/// <para>
/// The reason for that is because, by the time the options arrive at the
/// primary instance, it is typically too late to do anything with them.
/// Taking the GTK option group as an example: GTK will already have been
/// initialised by the time the #GApplication::command-line handler runs.
/// In the case that this is not the first-running instance of the
/// application, the existing instance may already have been running for
/// a very long time.
/// </para>
/// <para>
/// This means that the options from #GOptionGroup are only really usable
/// in the case that the instance of the application being run is the
/// first instance.  Passing options like `--display=` or `--gdk-debug=`
/// on future runs will have no effect on the existing primary instance.
/// </para>
/// <para>
/// Calling this function will cause the options in the supplied option
/// group to be parsed, but it does not cause you to be "opted in" to the
/// new functionality whereby unrecognized options are rejected even if
/// %G_APPLICATION_HANDLES_COMMAND_LINE was given.
/// </para>
/// </summary>

/// <param name="application">
/// the #GApplication
/// </param>
/// <param name="group">
/// a #GOptionGroup
/// </param>

	public static T AddOptionGroup<T>(this T application, MentorLake.GLib.GOptionGroupHandle group) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_add_option_group(application, group);
		return application;
	}

/// <summary>
/// <para>
/// Marks @application as busy (see g_application_mark_busy()) while
/// @property on @object is %TRUE.
/// </para>
/// <para>
/// The binding holds a reference to @application while it is active, but
/// not to @object. Instead, the binding is destroyed when @object is
/// finalized.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="property">
/// the name of a boolean property of @object
/// </param>

	public static T BindBusyProperty<T>(this T application, MentorLake.GObject.GObjectHandle @object, string property) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_bind_busy_property(application, @object, property);
		return application;
	}

/// <summary>
/// <para>
/// Gets the unique identifier for @application.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <return>
/// the identifier for @application, owned by @application
/// </return>

	public static string GetApplicationId(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_application_id(application);
	}

/// <summary>
/// <para>
/// Gets the #GDBusConnection being used by the application, or %NULL.
/// </para>
/// <para>
/// If #GApplication is using its D-Bus backend then this function will
/// return the #GDBusConnection being used for uniqueness and
/// communication with the desktop environment and other instances of the
/// application.
/// </para>
/// <para>
/// If #GApplication is not using D-Bus then this function will return
/// %NULL.  This includes the situation where the D-Bus backend would
/// normally be in use but we were unable to connect to the bus.
/// </para>
/// <para>
/// This function must not be called before the application has been
/// registered.  See g_application_get_is_registered().
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <return>
/// a #GDBusConnection, or %NULL
/// </return>

	public static MentorLake.Gio.GDBusConnectionHandle GetDbusConnection(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_dbus_connection(application);
	}

/// <summary>
/// <para>
/// Gets the D-Bus object path being used by the application, or %NULL.
/// </para>
/// <para>
/// If #GApplication is using its D-Bus backend then this function will
/// return the D-Bus object path that #GApplication is using.  If the
/// application is the primary instance then there is an object published
/// at this path.  If the application is not the primary instance then
/// the result of this function is undefined.
/// </para>
/// <para>
/// If #GApplication is not using D-Bus then this function will return
/// %NULL.  This includes the situation where the D-Bus backend would
/// normally be in use but we were unable to connect to the bus.
/// </para>
/// <para>
/// This function must not be called before the application has been
/// registered.  See g_application_get_is_registered().
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <return>
/// the object path, or %NULL
/// </return>

	public static string GetDbusObjectPath(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_dbus_object_path(application);
	}

/// <summary>
/// <para>
/// Gets the flags for @application.
/// </para>
/// <para>
/// See #GApplicationFlags.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <return>
/// the flags for @application
/// </return>

	public static MentorLake.Gio.GApplicationFlags GetFlags(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_flags(application);
	}

/// <summary>
/// <para>
/// Gets the current inactivity timeout for the application.
/// </para>
/// <para>
/// This is the amount of time (in milliseconds) after the last call to
/// g_application_release() before the application stops running.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <return>
/// the timeout, in milliseconds
/// </return>

	public static uint GetInactivityTimeout(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_inactivity_timeout(application);
	}

/// <summary>
/// <para>
/// Gets the application's current busy state, as set through
/// g_application_mark_busy() or g_application_bind_busy_property().
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <return>
/// %TRUE if @application is currently marked as busy
/// </return>

	public static bool GetIsBusy(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_is_busy(application);
	}

/// <summary>
/// <para>
/// Checks if @application is registered.
/// </para>
/// <para>
/// An application is registered if g_application_register() has been
/// successfully called.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <return>
/// %TRUE if @application is registered
/// </return>

	public static bool GetIsRegistered(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_is_registered(application);
	}

/// <summary>
/// <para>
/// Checks if @application is remote.
/// </para>
/// <para>
/// If @application is remote then it means that another instance of
/// application already exists (the 'primary' instance).  Calls to
/// perform actions on @application will result in the actions being
/// performed by the primary instance.
/// </para>
/// <para>
/// The value of this property cannot be accessed before
/// g_application_register() has been called.  See
/// g_application_get_is_registered().
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <return>
/// %TRUE if @application is remote
/// </return>

	public static bool GetIsRemote(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_is_remote(application);
	}

/// <summary>
/// <para>
/// Gets the resource base path of @application.
/// </para>
/// <para>
/// See g_application_set_resource_base_path() for more information.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <return>
/// the base resource path, if one is set
/// </return>

	public static string GetResourceBasePath(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_resource_base_path(application);
	}

/// <summary>
/// <para>
/// Gets the version of @application.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <return>
/// the version of @application
/// </return>

	public static string GetVersion(this MentorLake.Gio.GApplicationHandle application)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_get_version(application);
	}

/// <summary>
/// <para>
/// Increases the use count of @application.
/// </para>
/// <para>
/// Use this function to indicate that the application has a reason to
/// continue to run.  For example, g_application_hold() is called by GTK
/// when a toplevel window is on the screen.
/// </para>
/// <para>
/// To cancel the hold, call g_application_release().
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>

	public static T Hold<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_hold(application);
		return application;
	}

/// <summary>
/// <para>
/// Increases the busy count of @application.
/// </para>
/// <para>
/// Use this function to indicate that the application is busy, for instance
/// while a long running operation is pending.
/// </para>
/// <para>
/// The busy state will be exposed to other processes, so a session shell will
/// use that information to indicate the state to the user (e.g. with a
/// spinner).
/// </para>
/// <para>
/// To cancel the busy indication, use g_application_unmark_busy().
/// </para>
/// <para>
/// The application must be registered before calling this function.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>

	public static T MarkBusy<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_mark_busy(application);
		return application;
	}

/// <summary>
/// <para>
/// Opens the given files.
/// </para>
/// <para>
/// In essence, this results in the #GApplication::open signal being emitted
/// in the primary instance.
/// </para>
/// <para>
/// @n_files must be greater than zero.
/// </para>
/// <para>
/// @hint is simply passed through to the ::open signal.  It is
/// intended to be used by applications that have multiple modes for
/// opening files (eg: "view" vs "edit", etc).  Unless you have a need
/// for this functionality, you should use "".
/// </para>
/// <para>
/// The application must be registered before calling this function
/// and it must have the %G_APPLICATION_HANDLES_OPEN flag set.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="files">
/// an array of #GFiles to open
/// </param>
/// <param name="n_files">
/// the length of the @files array
/// </param>
/// <param name="hint">
/// a hint (or ""), but never %NULL
/// </param>

	public static T Open<T>(this T application, MentorLake.Gio.GFileHandle[] files, int n_files, string hint) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_open(application, files, n_files, hint);
		return application;
	}

/// <summary>
/// <para>
/// Immediately quits the application.
/// </para>
/// <para>
/// Upon return to the mainloop, g_application_run() will return,
/// calling only the 'shutdown' function before doing so.
/// </para>
/// <para>
/// The hold count is ignored.
/// Take care if your code has called g_application_hold() on the application and
/// is therefore still expecting it to exist.
/// (Note that you may have called g_application_hold() indirectly, for example
/// through gtk_application_add_window().)
/// </para>
/// <para>
/// The result of calling g_application_run() again after it returns is
/// unspecified.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>

	public static T Quit<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_quit(application);
		return application;
	}

/// <summary>
/// <para>
/// Attempts registration of the application.
/// </para>
/// <para>
/// This is the point at which the application discovers if it is the
/// primary instance or merely acting as a remote for an already-existing
/// primary instance.  This is implemented by attempting to acquire the
/// application identifier as a unique bus name on the session bus using
/// GDBus.
/// </para>
/// <para>
/// If there is no application ID or if %G_APPLICATION_NON_UNIQUE was
/// given, then this process will always become the primary instance.
/// </para>
/// <para>
/// Due to the internal architecture of GDBus, method calls can be
/// dispatched at any time (even if a main loop is not running).  For
/// this reason, you must ensure that any object paths that you wish to
/// register are registered before calling this function.
/// </para>
/// <para>
/// If the application has already been registered then %TRUE is
/// returned with no work performed.
/// </para>
/// <para>
/// The #GApplication::startup signal is emitted if registration succeeds
/// and @application is the primary instance (including the non-unique
/// case).
/// </para>
/// <para>
/// In the event of an error (such as @cancellable being cancelled, or a
/// failure to connect to the session bus), %FALSE is returned and @error
/// is set appropriately.
/// </para>
/// <para>
/// Note: the return value of this function is not an indicator that this
/// instance is or is not the primary instance of the application.  See
/// g_application_get_is_remote() for that.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// %TRUE if registration succeeded
/// </return>

	public static bool Register(this MentorLake.Gio.GApplicationHandle application, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		var externCallResult = GApplicationHandleExterns.g_application_register(application, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Decrease the use count of @application.
/// </para>
/// <para>
/// When the use count reaches zero, the application will stop running.
/// </para>
/// <para>
/// Never call this function except to cancel the effect of a previous
/// call to g_application_hold().
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>

	public static T Release<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_release(application);
		return application;
	}

/// <summary>
/// <para>
/// Runs the application.
/// </para>
/// <para>
/// This function is intended to be run from main() and its return value
/// is intended to be returned by main(). Although you are expected to pass
/// the @argc, @argv parameters from main() to this function, it is possible
/// to pass %NULL if @argv is not available or commandline handling is not
/// required.  Note that on Windows, @argc and @argv are ignored, and
/// g_win32_get_command_line() is called internally (for proper support
/// of Unicode commandline arguments).
/// </para>
/// <para>
/// #GApplication will attempt to parse the commandline arguments.  You
/// can add commandline flags to the list of recognised options by way of
/// g_application_add_main_option_entries().  After this, the
/// #GApplication::handle-local-options signal is emitted, from which the
/// application can inspect the values of its #GOptionEntrys.
/// </para>
/// <para>
/// #GApplication::handle-local-options is a good place to handle options
/// such as `--version`, where an immediate reply from the local process is
/// desired (instead of communicating with an already-running instance).
/// A #GApplication::handle-local-options handler can stop further processing
/// by returning a non-negative value, which then becomes the exit status of
/// the process.
/// </para>
/// <para>
/// What happens next depends on the flags: if
/// %G_APPLICATION_HANDLES_COMMAND_LINE was specified then the remaining
/// commandline arguments are sent to the primary instance, where a
/// #GApplication::command-line signal is emitted.  Otherwise, the
/// remaining commandline arguments are assumed to be a list of files.
/// If there are no files listed, the application is activated via the
/// #GApplication::activate signal.  If there are one or more files, and
/// %G_APPLICATION_HANDLES_OPEN was specified then the files are opened
/// via the #GApplication::open signal.
/// </para>
/// <para>
/// If you are interested in doing more complicated local handling of the
/// commandline then you should implement your own #GApplication subclass
/// and override local_command_line(). In this case, you most likely want
/// to return %TRUE from your local_command_line() implementation to
/// suppress the default handling. See
/// [gapplication-example-cmdline2.c][https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gapplication-example-cmdline2.c]
/// for an example.
/// </para>
/// <para>
/// If, after the above is done, the use count of the application is zero
/// then the exit status is returned immediately.  If the use count is
/// non-zero then the default main context is iterated until the use count
/// falls to zero, at which point 0 is returned.
/// </para>
/// <para>
/// If the %G_APPLICATION_IS_SERVICE flag is set, then the service will
/// run for as much as 10 seconds with a use count of zero while waiting
/// for the message that caused the activation to arrive.  After that,
/// if the use count falls to zero the application will exit immediately,
/// except in the case that g_application_set_inactivity_timeout() is in
/// use.
/// </para>
/// <para>
/// This function sets the prgname (g_set_prgname()), if not already set,
/// to the basename of argv[0].
/// </para>
/// <para>
/// Much like g_main_loop_run(), this function will acquire the main context
/// for the duration that the application is running.
/// </para>
/// <para>
/// Since 2.40, applications that are not explicitly flagged as services
/// or launchers (ie: neither %G_APPLICATION_IS_SERVICE or
/// %G_APPLICATION_IS_LAUNCHER are given as flags) will check (from the
/// default handler for local_command_line) if "--gapplication-service"
/// was given in the command line.  If this flag is present then normal
/// commandline processing is interrupted and the
/// %G_APPLICATION_IS_SERVICE flag is set.  This provides a "compromise"
/// solution whereby running an application directly from the commandline
/// will invoke it in the normal way (which can be useful for debugging)
/// while still allowing applications to be D-Bus activated in service
/// mode.  The D-Bus service file should invoke the executable with
/// "--gapplication-service" as the sole commandline argument.  This
/// approach is suitable for use by most graphical applications but
/// should not be used from applications like editors that need precise
/// control over when processes invoked via the commandline will exit and
/// what their exit status will be.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="argc">
/// the argc from main() (or 0 if @argv is %NULL)
/// </param>
/// <param name="argv">
/// 
///     the argv from main(), or %NULL
/// </param>
/// <return>
/// the exit status
/// </return>

	public static int Run(this MentorLake.Gio.GApplicationHandle application, int argc, string[] argv)
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		return GApplicationHandleExterns.g_application_run(application, argc, argv);
	}

/// <summary>
/// <para>
/// Sends a notification on behalf of @application to the desktop shell.
/// There is no guarantee that the notification is displayed immediately,
/// or even at all.
/// </para>
/// <para>
/// Notifications may persist after the application exits. It will be
/// D-Bus-activated when the notification or one of its actions is
/// activated.
/// </para>
/// <para>
/// Modifying @notification after this call has no effect. However, the
/// object can be reused for a later call to this function.
/// </para>
/// <para>
/// @id may be any string that uniquely identifies the event for the
/// application. It does not need to be in any special format. For
/// example, "new-message" might be appropriate for a notification about
/// new messages.
/// </para>
/// <para>
/// If a previous notification was sent with the same @id, it will be
/// replaced with @notification and shown again as if it was a new
/// notification. This works even for notifications sent from a previous
/// execution of the application, as long as @id is the same string.
/// </para>
/// <para>
/// @id may be `NULL`, but it is impossible to replace or withdraw
/// notifications without an id.
/// </para>
/// <para>
/// If @notification is no longer relevant, it can be withdrawn with
/// [method@Gio.Application.withdraw_notification].
/// </para>
/// <para>
/// It is an error to call this function if @application has no
/// application ID.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="id">
/// id of the notification, or %NULL
/// </param>
/// <param name="notification">
/// the #GNotification to send
/// </param>

	public static T SendNotification<T>(this T application, string id, MentorLake.Gio.GNotificationHandle notification) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_send_notification(application, id, notification);
		return application;
	}

/// <summary>
/// <para>
/// This used to be how actions were associated with a #GApplication.
/// Now there is #GActionMap for that.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="action_group">
/// a #GActionGroup, or %NULL
/// </param>

	public static T SetActionGroup<T>(this T application, MentorLake.Gio.GActionGroupHandle action_group) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_action_group(application, action_group);
		return application;
	}

/// <summary>
/// <para>
/// Sets the unique identifier for @application.
/// </para>
/// <para>
/// The application id can only be modified if @application has not yet
/// been registered.
/// </para>
/// <para>
/// If non-%NULL, the application id must be valid.  See
/// g_application_id_is_valid().
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="application_id">
/// the identifier for @application
/// </param>

	public static T SetApplicationId<T>(this T application, string application_id) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_application_id(application, application_id);
		return application;
	}

/// <summary>
/// <para>
/// Sets or unsets the default application for the process, as returned
/// by g_application_get_default().
/// </para>
/// <para>
/// This function does not take its own reference on @application.  If
/// @application is destroyed then the default application will revert
/// back to %NULL.
/// </para>
/// </summary>

/// <param name="application">
/// the application to set as default, or %NULL
/// </param>

	public static T SetDefault<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_default(application);
		return application;
	}

/// <summary>
/// <para>
/// Sets the flags for @application.
/// </para>
/// <para>
/// The flags can only be modified if @application has not yet been
/// registered.
/// </para>
/// <para>
/// See #GApplicationFlags.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="flags">
/// the flags for @application
/// </param>

	public static T SetFlags<T>(this T application, MentorLake.Gio.GApplicationFlags flags) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_flags(application, flags);
		return application;
	}

/// <summary>
/// <para>
/// Sets the current inactivity timeout for the application.
/// </para>
/// <para>
/// This is the amount of time (in milliseconds) after the last call to
/// g_application_release() before the application stops running.
/// </para>
/// <para>
/// This call has no side effects of its own.  The value set here is only
/// used for next time g_application_release() drops the use count to
/// zero.  Any timeouts currently in progress are not impacted.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="inactivity_timeout">
/// the timeout, in milliseconds
/// </param>

	public static T SetInactivityTimeout<T>(this T application, uint inactivity_timeout) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_inactivity_timeout(application, inactivity_timeout);
		return application;
	}

/// <summary>
/// <para>
/// Adds a description to the @application option context.
/// </para>
/// <para>
/// See g_option_context_set_description() for more information.
/// </para>
/// </summary>

/// <param name="application">
/// the #GApplication
/// </param>
/// <param name="description">
/// a string to be shown in `--help` output
///  after the list of options, or %NULL
/// </param>

	public static T SetOptionContextDescription<T>(this T application, string description) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_option_context_description(application, description);
		return application;
	}

/// <summary>
/// <para>
/// Sets the parameter string to be used by the commandline handling of @application.
/// </para>
/// <para>
/// This function registers the argument to be passed to g_option_context_new()
/// when the internal #GOptionContext of @application is created.
/// </para>
/// <para>
/// See g_option_context_new() for more information about @parameter_string.
/// </para>
/// </summary>

/// <param name="application">
/// the #GApplication
/// </param>
/// <param name="parameter_string">
/// a string which is displayed
///   in the first line of `--help` output, after the usage summary `programname [OPTION...]`.
/// </param>

	public static T SetOptionContextParameterString<T>(this T application, string parameter_string) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_option_context_parameter_string(application, parameter_string);
		return application;
	}

/// <summary>
/// <para>
/// Adds a summary to the @application option context.
/// </para>
/// <para>
/// See g_option_context_set_summary() for more information.
/// </para>
/// </summary>

/// <param name="application">
/// the #GApplication
/// </param>
/// <param name="summary">
/// a string to be shown in `--help` output
///  before the list of options, or %NULL
/// </param>

	public static T SetOptionContextSummary<T>(this T application, string summary) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_option_context_summary(application, summary);
		return application;
	}

/// <summary>
/// <para>
/// Sets (or unsets) the base resource path of @application.
/// </para>
/// <para>
/// The path is used to automatically load various [application
/// resources][gresource] such as menu layouts and action descriptions.
/// The various types of resources will be found at fixed names relative
/// to the given base path.
/// </para>
/// <para>
/// By default, the resource base path is determined from the application
/// ID by prefixing '/' and replacing each '.' with '/'.  This is done at
/// the time that the #GApplication object is constructed.  Changes to
/// the application ID after that point will not have an impact on the
/// resource base path.
/// </para>
/// <para>
/// As an example, if the application has an ID of "org.example.app" then
/// the default resource base path will be "/org/example/app".  If this
/// is a #GtkApplication (and you have not manually changed the path)
/// then Gtk will then search for the menus of the application at
/// "/org/example/app/gtk/menus.ui".
/// </para>
/// <para>
/// See #GResource for more information about adding resources to your
/// application.
/// </para>
/// <para>
/// You can disable automatic resource loading functionality by setting
/// the path to %NULL.
/// </para>
/// <para>
/// Changing the resource base path once the application is running is
/// not recommended.  The point at which the resource path is consulted
/// for forming paths for various purposes is unspecified.  When writing
/// a sub-class of #GApplication you should either set the
/// #GApplication:resource-base-path property at construction time, or call
/// this function during the instance initialization. Alternatively, you
/// can call this function in the #GApplicationClass.startup virtual function,
/// before chaining up to the parent implementation.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="resource_path">
/// the resource path to use
/// </param>

	public static T SetResourceBasePath<T>(this T application, string resource_path) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_resource_base_path(application, resource_path);
		return application;
	}

/// <summary>
/// <para>
/// Sets the version number of @application. This will be used to implement
/// a `--version` command line argument
/// </para>
/// <para>
/// The application version can only be modified if @application has not yet
/// been registered.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="version">
/// the version of @application
/// </param>

	public static T SetVersion<T>(this T application, string version) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_set_version(application, version);
		return application;
	}

/// <summary>
/// <para>
/// Destroys a binding between @property and the busy state of
/// @application that was previously created with
/// g_application_bind_busy_property().
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="property">
/// the name of a boolean property of @object
/// </param>

	public static T UnbindBusyProperty<T>(this T application, MentorLake.GObject.GObjectHandle @object, string property) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_unbind_busy_property(application, @object, property);
		return application;
	}

/// <summary>
/// <para>
/// Decreases the busy count of @application.
/// </para>
/// <para>
/// When the busy count reaches zero, the new state will be propagated
/// to other processes.
/// </para>
/// <para>
/// This function must only be called to cancel the effect of a previous
/// call to g_application_mark_busy().
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>

	public static T UnmarkBusy<T>(this T application) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_unmark_busy(application);
		return application;
	}

/// <summary>
/// <para>
/// Withdraws a notification that was sent with
/// g_application_send_notification().
/// </para>
/// <para>
/// This call does nothing if a notification with @id doesn't exist or
/// the notification was never sent.
/// </para>
/// <para>
/// This function works even for notifications sent in previous
/// executions of this application, as long @id is the same as it was for
/// the sent notification.
/// </para>
/// <para>
/// Note that notifications are dismissed when the user clicks on one
/// of the buttons in a notification or triggers its default action, so
/// there is no need to explicitly withdraw the notification in that case.
/// </para>
/// </summary>

/// <param name="application">
/// a #GApplication
/// </param>
/// <param name="id">
/// id of a previously sent notification
/// </param>

	public static T WithdrawNotification<T>(this T application, string id) where T : GApplicationHandle
	{
		if (application.IsInvalid) throw new Exception("Invalid handle (GApplicationHandle)");
		GApplicationHandleExterns.g_application_withdraw_notification(application, id);
		return application;
	}

}

internal class GApplicationHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))]
	internal static extern MentorLake.Gio.GApplicationHandle g_application_new(string application_id, MentorLake.Gio.GApplicationFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_add_main_option([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string long_name, char short_name, MentorLake.GLib.GOptionFlags flags, MentorLake.GLib.GOptionArg arg, string description, string arg_description);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_add_main_option_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 0, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionEntryHandle>))] MentorLake.GLib.GOptionEntryHandle[] entries);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_add_option_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_bind_busy_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_get_application_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_application_get_dbus_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_get_dbus_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GApplicationFlags g_application_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_application_get_inactivity_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_get_is_busy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_get_is_registered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_get_is_remote([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_get_resource_base_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_get_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_hold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_mark_busy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_open([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle[] files, int n_files, string hint);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_quit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_register([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_application_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, int argc, string[] argv);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_send_notification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle action_group);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_application_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string application_id);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, MentorLake.Gio.GApplicationFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_inactivity_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, uint inactivity_timeout);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_option_context_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string description);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_option_context_parameter_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string parameter_string);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_option_context_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string summary);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_resource_base_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string resource_path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_set_version([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string version);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_unbind_busy_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_unmark_busy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_withdraw_notification([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))] MentorLake.Gio.GApplicationHandle application, string id);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationHandle>))]
	internal static extern MentorLake.Gio.GApplicationHandle g_application_get_default();

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_id_is_valid(string application_id);

}
