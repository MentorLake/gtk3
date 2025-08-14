namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A helper class for testing code which uses D-Bus without touching the user’s
/// session bus.
/// </para>
/// <para>
/// Note that `GTestDBus` modifies the user’s environment, calling
/// <see href="man:setenv(3">setenv()</see>). This is not thread-safe, so all `GTestDBus`
/// calls should be completed before threads are spawned, or should have
/// appropriate locking to ensure no access conflicts to environment variables
/// shared between `GTestDBus` and other threads.
/// </para>
/// <para>
/// ## Creating unit tests using `GTestDBus`
/// </para>
/// <para>
/// Testing of D-Bus services can be tricky because normally we only ever run
/// D-Bus services over an existing instance of the D-Bus daemon thus we
/// usually don’t activate D-Bus services that are not yet installed into the
/// target system. The `GTestDBus` object makes this easier for us by taking care
/// of the lower level tasks such as running a private D-Bus daemon and looking
/// up uninstalled services in customizable locations, typically in your source
/// code tree.
/// </para>
/// <para>
/// The first thing you will need is a separate service description file for the
/// D-Bus daemon. Typically a `services` subdirectory of your `tests` directory
/// is a good place to put this file.
/// </para>
/// <para>
/// The service file should list your service along with an absolute path to the
/// uninstalled service executable in your source tree. Using autotools we would
/// achieve this by adding a file such as `my-server.service.in` in the services
/// directory and have it processed by configure.
/// </para>
/// <para>
/// ```
/// [D-BUS Service]
/// Name=org.gtk.GDBus.Examples.ObjectManager
/// Exec=@abs_top_builddir@/gio/tests/gdbus-example-objectmanager-server
/// ```
/// </para>
/// <para>
/// You will also need to indicate this service directory in your test
/// fixtures, so you will need to pass the path while compiling your
/// test cases. Typically this is done with autotools with an added
/// preprocessor flag specified to compile your tests such as:
/// </para>
/// <para>
/// ```
/// -DTEST_SERVICES=\""$(abs_top_builddir)/tests/services"\"
/// ```
/// </para>
/// <para>
/// Once you have a service definition file which is local to your source tree,
/// you can proceed to set up a GTest fixture using the `GTestDBus` scaffolding.
/// </para>
/// <para>
/// An example of a test fixture for D-Bus services can be found
/// here:
/// [gdbus-test-fixture.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gdbus-test-fixture.c)
/// </para>
/// <para>
/// Note that these examples only deal with isolating the D-Bus aspect of your
/// service. To successfully run isolated unit tests on your service you may need
/// some additional modifications to your test case fixture. For example; if your
/// service uses [class@Gio.Settings] and installs a schema then it is important
/// that your test service not load the schema in the ordinary installed location
/// (chances are that your service and schema files are not yet installed, or
/// worse; there is an older version of the schema file sitting in the install
/// location).
/// </para>
/// <para>
/// Most of the time we can work around these obstacles using the
/// environment. Since the environment is inherited by the D-Bus daemon
/// created by `GTestDBus` and then in turn inherited by any services the
/// D-Bus daemon activates, using the setup routine for your fixture is
/// a practical place to help sandbox your runtime environment. For the
/// rather typical GSettings case we can work around this by setting
/// `GSETTINGS_SCHEMA_DIR` to the in tree directory holding your schemas
/// in the above `fixture_setup()` routine.
/// </para>
/// <para>
/// The GSettings schemas need to be locally pre-compiled for this to work. This
/// can be achieved by compiling the schemas locally as a step before running
/// test cases, an autotools setup might do the following in the directory
/// holding schemas:
/// </para>
/// <para>
/// ```
///     all-am:
///             $(GLIB_COMPILE_SCHEMAS) .
/// </para>
/// <para>
///     CLEANFILES += gschemas.compiled
/// ```
/// </para>
/// </summary>

public class GTestDBusHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #GTestDBus object.
/// </para>
/// </summary>

/// <param name="flags">
/// a #GTestDBusFlags
/// </param>
/// <return>
/// a new #GTestDBus.
/// </return>

	public static MentorLake.Gio.GTestDBusHandle New(MentorLake.Gio.GTestDBusFlags flags)
	{
		return GTestDBusHandleExterns.g_test_dbus_new(flags);
	}

/// <summary>
/// <para>
/// Unset DISPLAY and DBUS_SESSION_BUS_ADDRESS env variables to ensure the test
/// won't use user's session bus.
/// </para>
/// <para>
/// This is useful for unit tests that want to verify behaviour when no session
/// bus is running. It is not necessary to call this if unit test already calls
/// g_test_dbus_up() before acquiring the session bus.
/// </para>
/// </summary>


	public static void Unset()
	{
		GTestDBusHandleExterns.g_test_dbus_unset();
	}

}

public static class GTestDBusHandleExtensions
{
/// <summary>
/// <para>
/// Add a path where dbus-daemon will look up .service files. This can't be
/// called after g_test_dbus_up().
/// </para>
/// </summary>

/// <param name="self">
/// a #GTestDBus
/// </param>
/// <param name="path">
/// path to a directory containing .service files
/// </param>

	public static T AddServiceDir<T>(this T self, string path) where T : GTestDBusHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		GTestDBusHandleExterns.g_test_dbus_add_service_dir(self, path);
		return self;
	}

/// <summary>
/// <para>
/// Stop the session bus started by g_test_dbus_up().
/// </para>
/// <para>
/// This will wait for the singleton returned by g_bus_get() or g_bus_get_sync()
/// to be destroyed. This is done to ensure that the next unit test won't get a
/// leaked singleton from this test.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTestDBus
/// </param>

	public static T Down<T>(this T self) where T : GTestDBusHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		GTestDBusHandleExterns.g_test_dbus_down(self);
		return self;
	}

/// <summary>
/// <para>
/// Get the address on which dbus-daemon is running. If g_test_dbus_up() has not
/// been called yet, %NULL is returned. This can be used with
/// g_dbus_connection_new_for_address().
/// </para>
/// </summary>

/// <param name="self">
/// a #GTestDBus
/// </param>
/// <return>
/// the address of the bus, or %NULL.
/// </return>

	public static string GetBusAddress(this MentorLake.Gio.GTestDBusHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		return GTestDBusHandleExterns.g_test_dbus_get_bus_address(self);
	}

/// <summary>
/// <para>
/// Get the flags of the #GTestDBus object.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTestDBus
/// </param>
/// <return>
/// the value of #GTestDBus:flags property
/// </return>

	public static MentorLake.Gio.GTestDBusFlags GetFlags(this MentorLake.Gio.GTestDBusHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		return GTestDBusHandleExterns.g_test_dbus_get_flags(self);
	}

/// <summary>
/// <para>
/// Stop the session bus started by g_test_dbus_up().
/// </para>
/// <para>
/// Unlike g_test_dbus_down(), this won't verify the #GDBusConnection
/// singleton returned by g_bus_get() or g_bus_get_sync() is destroyed. Unit
/// tests wanting to verify behaviour after the session bus has been stopped
/// can use this function but should still call g_test_dbus_down() when done.
/// </para>
/// </summary>

/// <param name="self">
/// a #GTestDBus
/// </param>

	public static T Stop<T>(this T self) where T : GTestDBusHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		GTestDBusHandleExterns.g_test_dbus_stop(self);
		return self;
	}

/// <summary>
/// <para>
/// Start a dbus-daemon instance and set DBUS_SESSION_BUS_ADDRESS. After this
/// call, it is safe for unit tests to start sending messages on the session bus.
/// </para>
/// <para>
/// If this function is called from setup callback of g_test_add(),
/// g_test_dbus_down() must be called in its teardown callback.
/// </para>
/// <para>
/// If this function is called from unit test's main(), then g_test_dbus_down()
/// must be called after g_test_run().
/// </para>
/// </summary>

/// <param name="self">
/// a #GTestDBus
/// </param>

	public static T Up<T>(this T self) where T : GTestDBusHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GTestDBusHandle)");
		GTestDBusHandleExterns.g_test_dbus_up(self);
		return self;
	}

}

internal class GTestDBusHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))]
	internal static extern MentorLake.Gio.GTestDBusHandle g_test_dbus_new(MentorLake.Gio.GTestDBusFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_test_dbus_add_service_dir([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_test_dbus_down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_dbus_get_bus_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTestDBusFlags g_test_dbus_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_test_dbus_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_test_dbus_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTestDBusHandle>))] MentorLake.Gio.GTestDBusHandle self);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_test_dbus_unset();

}
