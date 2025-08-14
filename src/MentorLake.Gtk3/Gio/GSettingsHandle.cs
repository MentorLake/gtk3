namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The `GSettings` class provides a convenient API for storing and retrieving
/// application settings.
/// </para>
/// <para>
/// Reads and writes can be considered to be non-blocking.  Reading
/// settings with `GSettings` is typically extremely fast: on
/// approximately the same order of magnitude (but slower than) a
/// [struct@GLib.HashTable] lookup.  Writing settings is also extremely fast in
/// terms of time to return to your application, but can be extremely expensive
/// for other threads and other processes.  Many settings backends
/// (including dconf) have lazy initialisation which means in the common
/// case of the user using their computer without modifying any settings
/// a lot of work can be avoided.  For dconf, the D-Bus service doesn’t
/// even need to be started in this case.  For this reason, you should
/// only ever modify `GSettings` keys in response to explicit user action.
/// Particular care should be paid to ensure that modifications are not
/// made during startup — for example, when setting the initial value
/// of preferences widgets.  The built-in [method@Gio.Settings.bind]
/// functionality is careful not to write settings in response to notify signals
/// as a result of modifications that it makes to widgets.
/// </para>
/// <para>
/// When creating a `GSettings` instance, you have to specify a schema
/// that describes the keys in your settings and their types and default
/// values, as well as some other information.
/// </para>
/// <para>
/// Normally, a schema has a fixed path that determines where the settings
/// are stored in the conceptual global tree of settings. However, schemas
/// can also be ‘[relocatable](#relocatable-schemas)’, i.e. not equipped with
/// a fixed path. This is
/// useful e.g. when the schema describes an ‘account’, and you want to be
/// able to store a arbitrary number of accounts.
/// </para>
/// <para>
/// Paths must start with and end with a forward slash character (`/`)
/// and must not contain two sequential slash characters.  Paths should
/// be chosen based on a domain name associated with the program or
/// library to which the settings belong.  Examples of paths are
/// `/org/gtk/settings/file-chooser/` and `/ca/desrt/dconf-editor/`.
/// Paths should not start with `/apps/`, `/desktop/` or `/system/` as
/// they often did in GConf.
/// </para>
/// <para>
/// Unlike other configuration systems (like GConf), GSettings does not
/// restrict keys to basic types like strings and numbers. GSettings stores
/// values as [struct@GLib.Variant], and allows any [type@GLib.VariantType] for
/// keys. Key names are restricted to lowercase characters, numbers and `-`.
/// Furthermore, the names must begin with a lowercase character, must not end
/// with a `-`, and must not contain consecutive dashes.
/// </para>
/// <para>
/// Similar to GConf, the default values in GSettings schemas can be
/// localized, but the localized values are stored in gettext catalogs
/// and looked up with the domain that is specified in the
/// `gettext-domain` attribute of the `<schemalist>` or `<schema>`
/// elements and the category that is specified in the `l10n` attribute of
/// the `<default>` element. The string which is translated includes all text in
/// the `<default>` element, including any surrounding quotation marks.
/// </para>
/// <para>
/// The `l10n` attribute must be set to `messages` or `time`, and sets the
/// [locale category for
/// translation](https://www.gnu.org/software/gettext/manual/html_node/Aspects.html#index-locale-categories-1).
/// The `messages` category should be used by default; use `time` for
/// translatable date or time formats. A translation comment can be added as an
/// XML comment immediately above the `<default>` element — it is recommended to
/// add these comments to aid translators understand the meaning and
/// implications of the default value. An optional translation `context`
/// attribute can be set on the `<default>` element to disambiguate multiple
/// defaults which use the same string.
/// </para>
/// <para>
/// For example:
/// ```xml
///  <!-- Translators: A list of words which are not allowed to be typed, in
///       GVariant serialization syntax.
///       See: https://developer.gnome.org/glib/stable/gvariant-text.html -->
///  <default l10n='messages' context='Banned words'>['bad', 'words']</default>
/// ```
/// </para>
/// <para>
/// Translations of default values must remain syntactically valid serialized
/// [struct@GLib.Variant]s (e.g. retaining any surrounding quotation marks) or
/// runtime errors will occur.
/// </para>
/// <para>
/// GSettings uses schemas in a compact binary form that is created
/// by the <see href="glib-compile-schemas.html">glib-compile-schemas</see>
/// utility. The input is a schema description in an XML format.
/// </para>
/// <para>
/// A DTD for the gschema XML format can be found here:
/// [gschema.dtd](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/gschema.dtd)
/// </para>
/// <para>
/// The <see href="glib-compile-schemas.html">glib-compile-schemas</see> tool expects schema
/// files to have the extension `.gschema.xml`.
/// </para>
/// <para>
/// At runtime, schemas are identified by their ID (as specified in the
/// `id` attribute of the `<schema>` element). The convention for schema
/// IDs is to use a dotted name, similar in style to a D-Bus bus name,
/// e.g. `org.gnome.SessionManager`. In particular, if the settings are
/// for a specific service that owns a D-Bus bus name, the D-Bus bus name
/// and schema ID should match. For schemas which deal with settings not
/// associated with one named application, the ID should not use
/// StudlyCaps, e.g. `org.gnome.font-rendering`.
/// </para>
/// <para>
/// In addition to [struct@GLib.Variant] types, keys can have types that have
/// enumerated types. These can be described by a `<choice>`,
/// `<enum>` or `<flags>` element, as seen in the
/// second example below. The underlying type of such a key
/// is string, but you can use [method@Gio.Settings.get_enum],
/// [method@Gio.Settings.set_enum], [method@Gio.Settings.get_flags],
/// [method@Gio.Settings.set_flags] access the numeric values corresponding to
/// the string value of enum and flags keys.
/// </para>
/// <para>
/// An example for default value:
/// ```xml
/// <schemalist>
///   <schema id="org.gtk.Test" path="/org/gtk/Test/" gettext-domain="test">
/// </para>
/// <para>
///     <key name="greeting" type="s">
///       <default l10n="messages">"Hello, earthlings"</default>
///       <summary>A greeting</summary>
///       <description>
///         Greeting of the invading martians
///       </description>
///     </key>
/// </para>
/// <para>
///     <key name="box" type="(ii)">
///       <default>(20,30)</default>
///     </key>
/// </para>
/// <para>
///     <key name="empty-string" type="s">
///       <default>""</default>
///       <summary>Empty strings have to be provided in GVariant form</summary>
///     </key>
/// </para>
/// <para>
///   </schema>
/// </schemalist>
/// ```
/// </para>
/// <para>
/// An example for ranges, choices and enumerated types:
/// ```xml
/// <schemalist>
/// </para>
/// <para>
///   <enum id="org.gtk.Test.myenum">
///     <value nick="first" value="1"/>
///     <value nick="second" value="2"/>
///   </enum>
/// </para>
/// <para>
///   <flags id="org.gtk.Test.myflags">
///     <value nick="flag1" value="1"/>
///     <value nick="flag2" value="2"/>
///     <value nick="flag3" value="4"/>
///   </flags>
/// </para>
/// <para>
///   <schema id="org.gtk.Test">
/// </para>
/// <para>
///     <key name="key-with-range" type="i">
///       <range min="1" max="100"/>
///       <default>10</default>
///     </key>
/// </para>
/// <para>
///     <key name="key-with-choices" type="s">
///       <choices>
///         <choice value='Elisabeth'/>
///         <choice value='Annabeth'/>
///         <choice value='Joe'/>
///       </choices>
///       <aliases>
///         <alias value='Anna' target='Annabeth'/>
///         <alias value='Beth' target='Elisabeth'/>
///       </aliases>
///       <default>'Joe'</default>
///     </key>
/// </para>
/// <para>
///     <key name='enumerated-key' enum='org.gtk.Test.myenum'>
///       <default>'first'</default>
///     </key>
/// </para>
/// <para>
///     <key name='flags-key' flags='org.gtk.Test.myflags'>
///       <default>["flag1","flag2"]</default>
///     </key>
///   </schema>
/// </schemalist>
/// ```
/// </para>
/// <para>
/// ## Vendor overrides
/// </para>
/// <para>
/// Default values are defined in the schemas that get installed by
/// an application. Sometimes, it is necessary for a vendor or distributor
/// to adjust these defaults. Since patching the XML source for the schema
/// is inconvenient and error-prone,
/// <see href="glib-compile-schemas.html">glib-compile-schemas</see> reads so-called ‘vendor
/// override’ files. These are keyfiles in the same directory as the XML
/// schema sources which can override default values. The schema ID serves
/// as the group name in the key file, and the values are expected in
/// serialized [struct@GLib.Variant] form, as in the following example:
/// ```
/// [org.gtk.Example]
/// key1='string'
/// key2=1.5
/// ```
/// </para>
/// <para>
/// `glib-compile-schemas` expects schema files to have the extension
/// `.gschema.override`.
/// </para>
/// <para>
/// ## Binding
/// </para>
/// <para>
/// A very convenient feature of GSettings lets you bind [class@GObject.Object]
/// properties directly to settings, using [method@Gio.Settings.bind]. Once a
/// [class@GObject.Object] property has been bound to a setting, changes on
/// either side are automatically propagated to the other side. GSettings handles
/// details like mapping between [class@GObject.Object] and [struct@GLib.Variant]
/// types, and preventing infinite cycles.
/// </para>
/// <para>
/// This makes it very easy to hook up a preferences dialog to the
/// underlying settings. To make this even more convenient, GSettings
/// looks for a boolean property with the name `sensitivity` and
/// automatically binds it to the writability of the bound setting.
/// If this ‘magic’ gets in the way, it can be suppressed with the
/// `G_SETTINGS_BIND_NO_SENSITIVITY` flag.
/// </para>
/// <para>
/// ## Relocatable schemas
/// </para>
/// <para>
/// A relocatable schema is one with no `path` attribute specified on its
/// `<schema>` element. By using [ctor@Gio.Settings.new_with_path], a `GSettings`
/// object can be instantiated for a relocatable schema, assigning a path to the
/// instance. Paths passed to [ctor@Gio.Settings.new_with_path] will typically be
/// constructed dynamically from a constant prefix plus some form of instance
/// identifier; but they must still be valid GSettings paths. Paths could also
/// be constant and used with a globally installed schema originating from a
/// dependency library.
/// </para>
/// <para>
/// For example, a relocatable schema could be used to store geometry information
/// for different windows in an application. If the schema ID was
/// `org.foo.MyApp.Window`, it could be instantiated for paths
/// `/org/foo/MyApp/main/`, `/org/foo/MyApp/document-1/`,
/// `/org/foo/MyApp/document-2/`, etc. If any of the paths are well-known
/// they can be specified as `<child>` elements in the parent schema, e.g.:
/// ```xml
/// <schema id="org.foo.MyApp" path="/org/foo/MyApp/">
///   <child name="main" schema="org.foo.MyApp.Window"/>
/// </schema>
/// ```
/// </para>
/// <para>
/// ## Build system integration
/// </para>
/// <para>
/// ### Meson
/// </para>
/// <para>
/// GSettings is natively supported by Meson's [GNOME module](https://mesonbuild.com/Gnome-module.html).
/// </para>
/// <para>
/// You can install the schemas as any other data file:
/// </para>
/// <para>
/// ```
/// install_data(
///   'org.foo.MyApp.gschema.xml',
///   install_dir: get_option('datadir') / 'glib-2.0/schemas',
/// )
/// ```
/// </para>
/// <para>
/// You can use `gnome.post_install()` function to compile the schemas on
/// installation:
/// </para>
/// <para>
/// ```
/// gnome = import('gnome')
/// gnome.post_install(
///   glib_compile_schemas: true,
/// )
/// ```
/// </para>
/// <para>
/// If an enumerated type defined in a C header file is to be used in a GSettings
/// schema, it can either be defined manually using an `<enum>` element in the
/// schema XML, or it can be extracted automatically from the C header. This
/// approach is preferred, as it ensures the two representations are always
/// synchronised. To do so, you will need to use the `gnome.mkenums()` function
/// with the following templates:
/// </para>
/// <para>
/// ```
/// schemas_enums = gnome.mkenums('org.foo.MyApp.enums.xml',
///   comments: '<!-- @comment@ -->',
///   fhead: '<schemalist>',
///   vhead: '  <@type@ id="org.foo.MyApp.@EnumName@">',
///   vprod: '    <value nick="@valuenick@" value="@valuenum@"/>',
///   vtail: '  </@type@>',
///   ftail: '</schemalist>',
///   sources: enum_sources,
///   install_header: true,
///   install_dir: get_option('datadir') / 'glib-2.0/schemas',
/// )
/// ```
/// </para>
/// <para>
/// It is recommended to validate your schemas as part of the test suite for
/// your application:
/// </para>
/// <para>
/// ```
/// test('validate-schema',
///   find_program('glib-compile-schemas'),
///   args: ['--strict', '--dry-run', meson.current_source_dir()],
/// )
/// ```
/// </para>
/// <para>
/// If your application allows running uninstalled, you should also use the
/// `gnome.compile_schemas()` function to compile the schemas in the current
/// build directory:
/// </para>
/// <para>
/// ```
/// gnome.compile_schemas()
/// ```
/// </para>
/// <para>
/// ### Autotools
/// </para>
/// <para>
/// GSettings comes with autotools integration to simplify compiling and
/// installing schemas. To add GSettings support to an application, add the
/// following to your `configure.ac`:
/// ```
/// GLIB_GSETTINGS
/// ```
/// </para>
/// <para>
/// In the appropriate `Makefile.am`, use the following snippet to compile and
/// install the named schema:
/// ```
/// gsettings_SCHEMAS = org.foo.MyApp.gschema.xml
/// EXTRA_DIST = $(gsettings_SCHEMAS)
/// </para>
/// <para>
/// @GSETTINGS_RULES@
/// ```
/// </para>
/// <para>
/// If an enumerated type defined in a C header file is to be used in a GSettings
/// schema, it can either be defined manually using an `<enum>` element in the
/// schema XML, or it can be extracted automatically from the C header. This
/// approach is preferred, as it ensures the two representations are always
/// synchronised. To do so, add the following to the relevant `Makefile.am`:
/// ```
/// gsettings_ENUM_NAMESPACE = org.foo.MyApp
/// gsettings_ENUM_FILES = my-app-enums.h my-app-misc.h
/// ```
/// </para>
/// <para>
/// `gsettings_ENUM_NAMESPACE` specifies the schema namespace for the enum files,
/// which are specified in `gsettings_ENUM_FILES`. This will generate a
/// `org.foo.MyApp.enums.xml` file containing the extracted enums, which will be
/// automatically included in the schema compilation, install and uninstall
/// rules. It should not be committed to version control or included in
/// `EXTRA_DIST`.
/// </para>
/// <para>
/// ## Localization
/// </para>
/// <para>
/// No changes are needed to the build system to mark a schema XML file for
/// translation. Assuming it sets the `gettext-domain` attribute, a schema may
/// be marked for translation by adding it to `POTFILES.in`, assuming gettext
/// 0.19 or newer is in use (the preferred method for translation):
/// ```
/// data/org.foo.MyApp.gschema.xml
/// ```
/// </para>
/// <para>
/// Alternatively, if intltool 0.50.1 is in use:
/// ```
/// [type: gettext/gsettings]data/org.foo.MyApp.gschema.xml
/// ```
/// </para>
/// <para>
/// GSettings will use gettext to look up translations for the `<summary>` and
/// `<description>` elements, and also any `<default>` elements which have a
/// `l10n` attribute set.
/// </para>
/// <para>
/// Translations **must not** be included in the `.gschema.xml` file by the build
/// system, for example by using a rule to generate the XML file from a template.
/// </para>
/// </summary>

public class GSettingsHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GSettings object with the schema specified by
/// @schema_id.
/// </para>
/// <para>
/// It is an error for the schema to not exist: schemas are an
/// essential part of a program, as they provide type information.
/// If schemas need to be dynamically loaded (for example, from an
/// optional runtime dependency), g_settings_schema_source_lookup()
/// can be used to test for their existence before loading them.
/// </para>
/// <para>
/// Signals on the newly created #GSettings object will be dispatched
/// via the thread-default #GMainContext in effect at the time of the
/// call to g_settings_new().  The new #GSettings will hold a reference
/// on the context.  See g_main_context_push_thread_default().
/// </para>
/// </summary>

/// <param name="schema_id">
/// the id of the schema
/// </param>
/// <return>
/// a new #GSettings object
/// </return>

	public static MentorLake.Gio.GSettingsHandle New(string schema_id)
	{
		return GSettingsHandleExterns.g_settings_new(schema_id);
	}

/// <summary>
/// <para>
/// Creates a new #GSettings object with a given schema, backend and
/// path.
/// </para>
/// <para>
/// It should be extremely rare that you ever want to use this function.
/// It is made available for advanced use-cases (such as plugin systems
/// that want to provide access to schemas loaded from custom locations,
/// etc).
/// </para>
/// <para>
/// At the most basic level, a #GSettings object is a pure composition of
/// 4 things: a #GSettingsSchema, a #GSettingsBackend, a path within that
/// backend, and a #GMainContext to which signals are dispatched.
/// </para>
/// <para>
/// This constructor therefore gives you full control over constructing
/// #GSettings instances.  The first 3 parameters are given directly as
/// @schema, @backend and @path, and the main context is taken from the
/// thread-default (as per g_settings_new()).
/// </para>
/// <para>
/// If @backend is %NULL then the default backend is used.
/// </para>
/// <para>
/// If @path is %NULL then the path from the schema is used.  It is an
/// error if @path is %NULL and the schema has no path of its own or if
/// @path is non-%NULL and not equal to the path that the schema does
/// have.
/// </para>
/// </summary>

/// <param name="schema">
/// a #GSettingsSchema
/// </param>
/// <param name="backend">
/// a #GSettingsBackend
/// </param>
/// <param name="path">
/// the path to use
/// </param>
/// <return>
/// a new #GSettings object
/// </return>

	public static MentorLake.Gio.GSettingsHandle NewFull(MentorLake.Gio.GSettingsSchemaHandle schema, MentorLake.Gio.GSettingsBackendHandle backend, string path)
	{
		return GSettingsHandleExterns.g_settings_new_full(schema, backend, path);
	}

/// <summary>
/// <para>
/// Creates a new #GSettings object with the schema specified by
/// @schema_id and a given #GSettingsBackend.
/// </para>
/// <para>
/// Creating a #GSettings object with a different backend allows accessing
/// settings from a database other than the usual one. For example, it may make
/// sense to pass a backend corresponding to the "defaults" settings database on
/// the system to get a settings object that modifies the system default
/// settings instead of the settings for this user.
/// </para>
/// </summary>

/// <param name="schema_id">
/// the id of the schema
/// </param>
/// <param name="backend">
/// the #GSettingsBackend to use
/// </param>
/// <return>
/// a new #GSettings object
/// </return>

	public static MentorLake.Gio.GSettingsHandle NewWithBackend(string schema_id, MentorLake.Gio.GSettingsBackendHandle backend)
	{
		return GSettingsHandleExterns.g_settings_new_with_backend(schema_id, backend);
	}

/// <summary>
/// <para>
/// Creates a new #GSettings object with the schema specified by
/// @schema_id and a given #GSettingsBackend and path.
/// </para>
/// <para>
/// This is a mix of g_settings_new_with_backend() and
/// g_settings_new_with_path().
/// </para>
/// </summary>

/// <param name="schema_id">
/// the id of the schema
/// </param>
/// <param name="backend">
/// the #GSettingsBackend to use
/// </param>
/// <param name="path">
/// the path to use
/// </param>
/// <return>
/// a new #GSettings object
/// </return>

	public static MentorLake.Gio.GSettingsHandle NewWithBackendAndPath(string schema_id, MentorLake.Gio.GSettingsBackendHandle backend, string path)
	{
		return GSettingsHandleExterns.g_settings_new_with_backend_and_path(schema_id, backend, path);
	}

/// <summary>
/// <para>
/// Creates a new #GSettings object with the relocatable schema specified
/// by @schema_id and a given path.
/// </para>
/// <para>
/// You only need to do this if you want to directly create a settings
/// object with a schema that doesn't have a specified path of its own.
/// That's quite rare.
/// </para>
/// <para>
/// It is a programmer error to call this function for a schema that
/// has an explicitly specified path.
/// </para>
/// <para>
/// It is a programmer error if @path is not a valid path.  A valid path
/// begins and ends with '/' and does not contain two consecutive '/'
/// characters.
/// </para>
/// </summary>

/// <param name="schema_id">
/// the id of the schema
/// </param>
/// <param name="path">
/// the path to use
/// </param>
/// <return>
/// a new #GSettings object
/// </return>

	public static MentorLake.Gio.GSettingsHandle NewWithPath(string schema_id, string path)
	{
		return GSettingsHandleExterns.g_settings_new_with_path(schema_id, path);
	}

/// <summary>
/// <para>
/// Deprecated.
/// </para>
/// </summary>

/// <return>
/// a list of
///   relocatable #GSettings schemas that are available, in no defined order.
///   The list must not be modified or freed.
/// </return>

	public static string[] ListRelocatableSchemas()
	{
		return GSettingsHandleExterns.g_settings_list_relocatable_schemas();
	}

/// <summary>
/// <para>
/// Deprecated.
/// </para>
/// </summary>

/// <return>
/// a list of
///   #GSettings schemas that are available, in no defined order.  The list
///   must not be modified or freed.
/// </return>

	public static string[] ListSchemas()
	{
		return GSettingsHandleExterns.g_settings_list_schemas();
	}

/// <summary>
/// <para>
/// Ensures that all pending operations are complete for the default backend.
/// </para>
/// <para>
/// Writes made to a #GSettings are handled asynchronously.  For this
/// reason, it is very unlikely that the changes have it to disk by the
/// time g_settings_set() returns.
/// </para>
/// <para>
/// This call will block until all of the writes have made it to the
/// backend.  Since the mainloop is not running, no change notifications
/// will be dispatched during this call (but some may be queued by the
/// time the call is done).
/// </para>
/// </summary>


	public static void Sync()
	{
		GSettingsHandleExterns.g_settings_sync();
	}

/// <summary>
/// <para>
/// Removes an existing binding for @property on @object.
/// </para>
/// <para>
/// Note that bindings are automatically removed when the
/// object is finalized, so it is rarely necessary to call this
/// function.
/// </para>
/// </summary>

/// <param name="@object">
/// the object
/// </param>
/// <param name="property">
/// the property whose binding is removed
/// </param>

	public static void Unbind(MentorLake.GObject.GObjectHandle @object, string property)
	{
		GSettingsHandleExterns.g_settings_unbind(@object, property);
	}

}
public static class GSettingsHandleSignalExtensions
{
/// <summary>
/// <para>
/// The "change-event" signal is emitted once per change event that
/// affects this settings object.  You should connect to this signal
/// only if you are interested in viewing groups of changes before they
/// are split out into multiple emissions of the "changed" signal.
/// For most use cases it is more appropriate to use the "changed" signal.
/// </para>
/// <para>
/// In the event that the change event applies to one or more specified
/// keys, @keys will be an array of #GQuark of length @n_keys.  In the
/// event that the change event applies to the #GSettings object as a
/// whole (ie: potentially every key has been changed) then @keys will
/// be %NULL and @n_keys will be 0.
/// </para>
/// <para>
/// The default handler for this signal invokes the "changed" signal
/// for each affected key.  If any other connected handler returns
/// %TRUE then this default functionality will be suppressed.
/// </para>
/// </summary>

	public static IObservable<GSettingsHandleSignalStructs.ChangeEventSignal> Signal_ChangeEvent(this GSettingsHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSettingsHandleSignalStructs.ChangeEventSignal> obs) =>
		{
			GSettingsHandleSignalDelegates.change_event handler = ( MentorLake.Gio.GSettingsHandle self,  MentorLake.GLib.GQuarkHandle[] keys,  int n_keys,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSettingsHandleSignalStructs.ChangeEventSignal()
				{
					Self = self, Keys = keys, NKeys = n_keys, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "change-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The "changed" signal is emitted when a key has potentially changed.
/// You should call one of the g_settings_get() calls to check the new
/// value.
/// </para>
/// <para>
/// This signal supports detailed connections.  You can connect to the
/// detailed signal "changed::x" in order to only receive callbacks
/// when key "x" changes.
/// </para>
/// <para>
/// Note that @settings only emits this signal if you have read @key at
/// least once while a signal handler was already connected for @key.
/// </para>
/// </summary>

	public static IObservable<GSettingsHandleSignalStructs.ChangedSignal> Signal_Changed(this GSettingsHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSettingsHandleSignalStructs.ChangedSignal> obs) =>
		{
			GSettingsHandleSignalDelegates.changed handler = ( MentorLake.Gio.GSettingsHandle self,  string key,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSettingsHandleSignalStructs.ChangedSignal()
				{
					Self = self, Key = key, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The "writable-change-event" signal is emitted once per writability
/// change event that affects this settings object.  You should connect
/// to this signal if you are interested in viewing groups of changes
/// before they are split out into multiple emissions of the
/// "writable-changed" signal.  For most use cases it is more
/// appropriate to use the "writable-changed" signal.
/// </para>
/// <para>
/// In the event that the writability change applies only to a single
/// key, @key will be set to the #GQuark for that key.  In the event
/// that the writability change affects the entire settings object,
/// @key will be 0.
/// </para>
/// <para>
/// The default handler for this signal invokes the "writable-changed"
/// and "changed" signals for each affected key.  This is done because
/// changes in writability might also imply changes in value (if for
/// example, a new mandatory setting is introduced).  If any other
/// connected handler returns %TRUE then this default functionality
/// will be suppressed.
/// </para>
/// </summary>

	public static IObservable<GSettingsHandleSignalStructs.WritableChangeEventSignal> Signal_WritableChangeEvent(this GSettingsHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSettingsHandleSignalStructs.WritableChangeEventSignal> obs) =>
		{
			GSettingsHandleSignalDelegates.writable_change_event handler = ( MentorLake.Gio.GSettingsHandle self,  uint key,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSettingsHandleSignalStructs.WritableChangeEventSignal()
				{
					Self = self, Key = key, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "writable-change-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The "writable-changed" signal is emitted when the writability of a
/// key has potentially changed.  You should call
/// g_settings_is_writable() in order to determine the new status.
/// </para>
/// <para>
/// This signal supports detailed connections.  You can connect to the
/// detailed signal "writable-changed::x" in order to only receive
/// callbacks when the writability of "x" changes.
/// </para>
/// </summary>

	public static IObservable<GSettingsHandleSignalStructs.WritableChangedSignal> Signal_WritableChanged(this GSettingsHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSettingsHandleSignalStructs.WritableChangedSignal> obs) =>
		{
			GSettingsHandleSignalDelegates.writable_changed handler = ( MentorLake.Gio.GSettingsHandle self,  string key,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSettingsHandleSignalStructs.WritableChangedSignal()
				{
					Self = self, Key = key, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "writable-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GSettingsHandleSignalStructs
{

public class ChangeEventSignal
{

	public MentorLake.Gio.GSettingsHandle Self;
/// <summary>
/// <para>
/// </para>
/// <para>
///        an array of #GQuarks for the changed keys, or %NULL
/// </para>
/// </summary>

	public MentorLake.GLib.GQuarkHandle[] Keys;
/// <summary>
/// <para>
/// the length of the @keys array, or 0
/// </para>
/// </summary>

	public int NKeys;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the
///          event. FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ChangedSignal
{

	public MentorLake.Gio.GSettingsHandle Self;
/// <summary>
/// <para>
/// the name of the key that changed
/// </para>
/// </summary>

	public string Key;

	public IntPtr UserData;
}

public class WritableChangeEventSignal
{

	public MentorLake.Gio.GSettingsHandle Self;
/// <summary>
/// <para>
/// the quark of the key, or 0
/// </para>
/// </summary>

	public uint Key;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop other handlers from being invoked for the
///          event. FALSE to propagate the event further.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class WritableChangedSignal
{

	public MentorLake.Gio.GSettingsHandle Self;
/// <summary>
/// <para>
/// the key
/// </para>
/// </summary>

	public string Key;

	public IntPtr UserData;
}
}

public static class GSettingsHandleSignalDelegates
{

/// <summary>
/// <para>
/// The "change-event" signal is emitted once per change event that
/// affects this settings object.  You should connect to this signal
/// only if you are interested in viewing groups of changes before they
/// are split out into multiple emissions of the "changed" signal.
/// For most use cases it is more appropriate to use the "changed" signal.
/// </para>
/// <para>
/// In the event that the change event applies to one or more specified
/// keys, @keys will be an array of #GQuark of length @n_keys.  In the
/// event that the change event applies to the #GSettings object as a
/// whole (ie: potentially every key has been changed) then @keys will
/// be %NULL and @n_keys will be 0.
/// </para>
/// <para>
/// The default handler for this signal invokes the "changed" signal
/// for each affected key.  If any other connected handler returns
/// %TRUE then this default functionality will be suppressed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="keys">
/// 
///        an array of #GQuarks for the changed keys, or %NULL
/// </param>
/// <param name="n_keys">
/// the length of the @keys array, or 0
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the
///          event. FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle self, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQuarkHandle>))] MentorLake.GLib.GQuarkHandle[] keys, int n_keys, IntPtr user_data);


/// <summary>
/// <para>
/// The "changed" signal is emitted when a key has potentially changed.
/// You should call one of the g_settings_get() calls to check the new
/// value.
/// </para>
/// <para>
/// This signal supports detailed connections.  You can connect to the
/// detailed signal "changed::x" in order to only receive callbacks
/// when key "x" changes.
/// </para>
/// <para>
/// Note that @settings only emits this signal if you have read @key at
/// least once while a signal handler was already connected for @key.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="key">
/// the name of the key that changed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle self, string key, IntPtr user_data);


/// <summary>
/// <para>
/// The "writable-change-event" signal is emitted once per writability
/// change event that affects this settings object.  You should connect
/// to this signal if you are interested in viewing groups of changes
/// before they are split out into multiple emissions of the
/// "writable-changed" signal.  For most use cases it is more
/// appropriate to use the "writable-changed" signal.
/// </para>
/// <para>
/// In the event that the writability change applies only to a single
/// key, @key will be set to the #GQuark for that key.  In the event
/// that the writability change affects the entire settings object,
/// @key will be 0.
/// </para>
/// <para>
/// The default handler for this signal invokes the "writable-changed"
/// and "changed" signals for each affected key.  This is done because
/// changes in writability might also imply changes in value (if for
/// example, a new mandatory setting is introduced).  If any other
/// connected handler returns %TRUE then this default functionality
/// will be suppressed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="key">
/// the quark of the key, or 0
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop other handlers from being invoked for the
///          event. FALSE to propagate the event further.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool writable_change_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle self, uint key, IntPtr user_data);


/// <summary>
/// <para>
/// The "writable-changed" signal is emitted when the writability of a
/// key has potentially changed.  You should call
/// g_settings_is_writable() in order to determine the new status.
/// </para>
/// <para>
/// This signal supports detailed connections.  You can connect to the
/// detailed signal "writable-changed::x" in order to only receive
/// callbacks when the writability of "x" changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="key">
/// the key
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void writable_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle self, string key, IntPtr user_data);

}


public static class GSettingsHandleExtensions
{
/// <summary>
/// <para>
/// Applies any changes that have been made to the settings.  This
/// function does nothing unless @settings is in 'delay-apply' mode;
/// see g_settings_delay().  In the normal case settings are always
/// applied immediately.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings instance
/// </param>

	public static T Apply<T>(this T settings) where T : GSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		GSettingsHandleExterns.g_settings_apply(settings);
		return settings;
	}

/// <summary>
/// <para>
/// Create a binding between the @key in the @settings object
/// and the property @property of @object.
/// </para>
/// <para>
/// The binding uses the default GIO mapping functions to map
/// between the settings and property values. These functions
/// handle booleans, numeric types and string types in a
/// straightforward way. Use g_settings_bind_with_mapping() if
/// you need a custom mapping, or map between types that are not
/// supported by the default mapping functions.
/// </para>
/// <para>
/// Unless the @flags include %G_SETTINGS_BIND_NO_SENSITIVITY, this
/// function also establishes a binding between the writability of
/// @key and the "sensitive" property of @object (if @object has
/// a boolean property by that name). See g_settings_bind_writable()
/// for more details about writable bindings.
/// </para>
/// <para>
/// Note that the lifecycle of the binding is tied to @object,
/// and that you can have only one binding per object property.
/// If you bind the same property twice on the same object, the second
/// binding overrides the first one.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to bind
/// </param>
/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="property">
/// the name of the property to bind
/// </param>
/// <param name="flags">
/// flags for the binding
/// </param>

	public static T Bind<T>(this T settings, string key, MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags) where T : GSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		GSettingsHandleExterns.g_settings_bind(settings, key, @object, property, flags);
		return settings;
	}

/// <summary>
/// <para>
/// Create a binding between the @key in the @settings object
/// and the property @property of @object.
/// </para>
/// <para>
/// The binding uses the provided mapping functions to map between
/// settings and property values.
/// </para>
/// <para>
/// Note that the lifecycle of the binding is tied to @object,
/// and that you can have only one binding per object property.
/// If you bind the same property twice on the same object, the second
/// binding overrides the first one.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to bind
/// </param>
/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="property">
/// the name of the property to bind
/// </param>
/// <param name="flags">
/// flags for the binding
/// </param>
/// <param name="get_mapping">
/// a function that gets called to convert values
///     from @settings to @object, or %NULL to use the default GIO mapping
/// </param>
/// <param name="set_mapping">
/// a function that gets called to convert values
///     from @object to @settings, or %NULL to use the default GIO mapping
/// </param>
/// <param name="user_data">
/// data that gets passed to @get_mapping and @set_mapping
/// </param>
/// <param name="destroy">
/// #GDestroyNotify function for @user_data
/// </param>

	public static T BindWithMapping<T>(this T settings, string key, MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags, MentorLake.Gio.GSettingsBindGetMapping get_mapping, MentorLake.Gio.GSettingsBindSetMapping set_mapping, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		GSettingsHandleExterns.g_settings_bind_with_mapping(settings, key, @object, property, flags, get_mapping, set_mapping, user_data, destroy);
		return settings;
	}

/// <summary>
/// <para>
/// Version of g_settings_bind_with_mapping() using closures instead of callbacks
/// for easier binding in other languages.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to bind
/// </param>
/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="property">
/// the name of the property to bind
/// </param>
/// <param name="flags">
/// flags for the binding
/// </param>
/// <param name="get_mapping">
/// a function that gets called to convert values
///     from @settings to @object, or %NULL to use the default GIO mapping
/// </param>
/// <param name="set_mapping">
/// a function that gets called to convert values
///     from @object to @settings, or %NULL to use the default GIO mapping
/// </param>

	public static T BindWithMappingClosures<T>(this T settings, string key, MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags, MentorLake.GObject.GClosureHandle get_mapping, MentorLake.GObject.GClosureHandle set_mapping) where T : GSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		GSettingsHandleExterns.g_settings_bind_with_mapping_closures(settings, key, @object, property, flags, get_mapping, set_mapping);
		return settings;
	}

/// <summary>
/// <para>
/// Create a binding between the writability of @key in the
/// @settings object and the property @property of @object.
/// The property must be boolean; "sensitive" or "visible"
/// properties of widgets are the most likely candidates.
/// </para>
/// <para>
/// Writable bindings are always uni-directional; changes of the
/// writability of the setting will be propagated to the object
/// property, not the other way.
/// </para>
/// <para>
/// When the @inverted argument is %TRUE, the binding inverts the
/// value as it passes from the setting to the object, i.e. @property
/// will be set to %TRUE if the key is not writable.
/// </para>
/// <para>
/// Note that the lifecycle of the binding is tied to @object,
/// and that you can have only one binding per object property.
/// If you bind the same property twice on the same object, the second
/// binding overrides the first one.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to bind
/// </param>
/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="property">
/// the name of a boolean property to bind
/// </param>
/// <param name="inverted">
/// whether to 'invert' the value
/// </param>

	public static T BindWritable<T>(this T settings, string key, MentorLake.GObject.GObjectHandle @object, string property, bool inverted) where T : GSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		GSettingsHandleExterns.g_settings_bind_writable(settings, key, @object, property, inverted);
		return settings;
	}

/// <summary>
/// <para>
/// Creates a #GAction corresponding to a given #GSettings key.
/// </para>
/// <para>
/// The action has the same name as the key.
/// </para>
/// <para>
/// The value of the key becomes the state of the action and the action
/// is enabled when the key is writable.  Changing the state of the
/// action results in the key being written to.  Changes to the value or
/// writability of the key cause appropriate change notifications to be
/// emitted for the action.
/// </para>
/// <para>
/// For boolean-valued keys, action activations take no parameter and
/// result in the toggling of the value.  For all other types,
/// activations take the new value for the key (which must have the
/// correct type).
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings
/// </param>
/// <param name="key">
/// the name of a key in @settings
/// </param>
/// <return>
/// a new #GAction
/// </return>

	public static MentorLake.Gio.GActionHandle CreateAction(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_create_action(settings, key);
	}

/// <summary>
/// <para>
/// Changes the #GSettings object into 'delay-apply' mode. In this
/// mode, changes to @settings are not immediately propagated to the
/// backend, but kept locally until g_settings_apply() is called.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>

	public static T Delay<T>(this T settings) where T : GSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		GSettingsHandleExterns.g_settings_delay(settings);
		return settings;
	}

/// <summary>
/// <para>
/// Gets the value that is stored at @key in @settings.
/// </para>
/// <para>
/// A convenience function that combines g_settings_get_value() with
/// g_variant_get().
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't contained in the
/// schema for @settings or for the #GVariantType of @format to mismatch
/// the type given in the schema.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <param name="format">
/// a #GVariant format string
/// </param>
/// <param name="@__arglist">
/// arguments as per @format
/// </param>

	public static T Get<T>(this T settings, string key, string format, IntPtr @__arglist) where T : GSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		GSettingsHandleExterns.g_settings_get(settings, key, format, @__arglist);
		return settings;
	}

/// <summary>
/// <para>
/// Gets the value that is stored at @key in @settings.
/// </para>
/// <para>
/// A convenience variant of g_settings_get() for booleans.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a boolean type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// a boolean
/// </return>

	public static bool GetBoolean(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_boolean(settings, key);
	}

/// <summary>
/// <para>
/// Creates a child settings object which has a base path of
/// `base-path/@name`, where `base-path` is the base path of
/// @settings.
/// </para>
/// <para>
/// The schema for the child settings object must have been declared
/// in the schema of @settings using a `<child>` element.
/// </para>
/// <para>
/// The created child settings object will inherit the #GSettings:delay-apply
/// mode from @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="name">
/// the name of the child schema
/// </param>
/// <return>
/// a 'child' settings object
/// </return>

	public static MentorLake.Gio.GSettingsHandle GetChild(this MentorLake.Gio.GSettingsHandle settings, string name)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_child(settings, name);
	}

/// <summary>
/// <para>
/// Gets the "default value" of a key.
/// </para>
/// <para>
/// This is the value that would be read if g_settings_reset() were to be
/// called on the key.
/// </para>
/// <para>
/// Note that this may be a different value than returned by
/// g_settings_schema_key_get_default_value() if the system administrator
/// has provided a default value.
/// </para>
/// <para>
/// Comparing the return values of g_settings_get_default_value() and
/// g_settings_get_value() is not sufficient for determining if a value
/// has been set because the user may have explicitly set the value to
/// something that happens to be equal to the default.  The difference
/// here is that if the default changes in the future, the user's key
/// will still be set.
/// </para>
/// <para>
/// This function may be useful for adding an indication to a UI of what
/// the default value was before the user set it.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't contained in the
/// schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the default value for
/// </param>
/// <return>
/// the default value
/// </return>

	public static MentorLake.GLib.GVariantHandle GetDefaultValue(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_default_value(settings, key);
	}

/// <summary>
/// <para>
/// Gets the value that is stored at @key in @settings.
/// </para>
/// <para>
/// A convenience variant of g_settings_get() for doubles.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a 'double' type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// a double
/// </return>

	public static double GetDouble(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_double(settings, key);
	}

/// <summary>
/// <para>
/// Gets the value that is stored in @settings for @key and converts it
/// to the enum value that it represents.
/// </para>
/// <para>
/// In order to use this function the type of the value must be a string
/// and it must be marked in the schema file as an enumerated type.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't contained in the
/// schema for @settings or is not marked as an enumerated type.
/// </para>
/// <para>
/// If the value stored in the configuration database is not a valid
/// value for the enumerated type then this function will return the
/// default value.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// the enum value
/// </return>

	public static int GetEnum(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_enum(settings, key);
	}

/// <summary>
/// <para>
/// Gets the value that is stored in @settings for @key and converts it
/// to the flags value that it represents.
/// </para>
/// <para>
/// In order to use this function the type of the value must be an array
/// of strings and it must be marked in the schema file as a flags type.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't contained in the
/// schema for @settings or is not marked as a flags type.
/// </para>
/// <para>
/// If the value stored in the configuration database is not a valid
/// value for the flags type then this function will return the default
/// value.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// the flags value
/// </return>

	public static uint GetFlags(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_flags(settings, key);
	}

/// <summary>
/// <para>
/// Returns whether the #GSettings object has any unapplied
/// changes.  This can only be the case if it is in 'delayed-apply' mode.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <return>
/// %TRUE if @settings has unapplied changes
/// </return>

	public static bool GetHasUnapplied(this MentorLake.Gio.GSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_has_unapplied(settings);
	}

/// <summary>
/// <para>
/// Gets the value that is stored at @key in @settings.
/// </para>
/// <para>
/// A convenience variant of g_settings_get() for 32-bit integers.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a int32 type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// an integer
/// </return>

	public static int GetInt(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_int(settings, key);
	}

/// <summary>
/// <para>
/// Gets the value that is stored at @key in @settings.
/// </para>
/// <para>
/// A convenience variant of g_settings_get() for 64-bit integers.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a int64 type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// a 64-bit integer
/// </return>

	public static long GetInt64(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_int64(settings, key);
	}

/// <summary>
/// <para>
/// Gets the value that is stored at @key in @settings, subject to
/// application-level validation/mapping.
/// </para>
/// <para>
/// You should use this function when the application needs to perform
/// some processing on the value of the key (for example, parsing).  The
/// @mapping function performs that processing.  If the function
/// indicates that the processing was unsuccessful (due to a parse error,
/// for example) then the mapping is tried again with another value.
/// </para>
/// <para>
/// This allows a robust 'fall back to defaults' behaviour to be
/// implemented somewhat automatically.
/// </para>
/// <para>
/// The first value that is tried is the user's setting for the key.  If
/// the mapping function fails to map this value, other values may be
/// tried in an unspecified order (system or site defaults, translated
/// schema default values, untranslated schema default values, etc).
/// </para>
/// <para>
/// If the mapping function fails for all possible values, one additional
/// attempt is made: the mapping function is called with a %NULL value.
/// If the mapping function still indicates failure at this point then
/// the application will be aborted.
/// </para>
/// <para>
/// The result parameter for the @mapping function is pointed to a
/// #gpointer which is initially set to %NULL.  The same pointer is given
/// to each invocation of @mapping.  The final value of that #gpointer is
/// what is returned by this function.  %NULL is valid; it is returned
/// just as any other value would be.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <param name="mapping">
/// the function to map the value in the
///           settings database to the value used by the application
/// </param>
/// <param name="user_data">
/// user data for @mapping
/// </param>
/// <return>
/// the result, which may be %NULL
/// </return>

	public static IntPtr GetMapped(this MentorLake.Gio.GSettingsHandle settings, string key, MentorLake.Gio.GSettingsGetMapping mapping, IntPtr user_data)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_mapped(settings, key, mapping, user_data);
	}

/// <summary>
/// <para>
/// Queries the range of a key.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings
/// </param>
/// <param name="key">
/// the key to query the range of
/// </param>

	public static MentorLake.GLib.GVariantHandle GetRange(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_range(settings, key);
	}

/// <summary>
/// <para>
/// Gets the value that is stored at @key in @settings.
/// </para>
/// <para>
/// A convenience variant of g_settings_get() for strings.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a string type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// a newly-allocated string
/// </return>

	public static string GetString(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_string(settings, key);
	}

/// <summary>
/// <para>
/// A convenience variant of g_settings_get() for string arrays.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having an array of strings type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// a
/// newly-allocated, %NULL-terminated array of strings, the value that
/// is stored at @key in @settings.
/// </return>

	public static string[] GetStrv(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_strv(settings, key);
	}

/// <summary>
/// <para>
/// Gets the value that is stored at @key in @settings.
/// </para>
/// <para>
/// A convenience variant of g_settings_get() for 32-bit unsigned
/// integers.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a uint32 type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// an unsigned integer
/// </return>

	public static uint GetUint(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_uint(settings, key);
	}

/// <summary>
/// <para>
/// Gets the value that is stored at @key in @settings.
/// </para>
/// <para>
/// A convenience variant of g_settings_get() for 64-bit unsigned
/// integers.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a uint64 type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// a 64-bit unsigned integer
/// </return>

	public static ulong GetUint64(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_uint64(settings, key);
	}

/// <summary>
/// <para>
/// Checks the "user value" of a key, if there is one.
/// </para>
/// <para>
/// The user value of a key is the last value that was set by the user.
/// </para>
/// <para>
/// After calling g_settings_reset() this function should always return
/// %NULL (assuming something is not wrong with the system
/// configuration).
/// </para>
/// <para>
/// It is possible that g_settings_get_value() will return a different
/// value than this function.  This can happen in the case that the user
/// set a value for a key that was subsequently locked down by the system
/// administrator -- this function will return the user's old value.
/// </para>
/// <para>
/// This function may be useful for adding a "reset" option to a UI or
/// for providing indication that a particular value has been changed.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't contained in the
/// schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the user value for
/// </param>
/// <return>
/// the user's value, if set
/// </return>

	public static MentorLake.GLib.GVariantHandle GetUserValue(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_user_value(settings, key);
	}

/// <summary>
/// <para>
/// Gets the value that is stored in @settings for @key.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't contained in the
/// schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the key to get the value for
/// </param>
/// <return>
/// a new #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle GetValue(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_get_value(settings, key);
	}

/// <summary>
/// <para>
/// Finds out if a key can be written or not
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="name">
/// the name of a key
/// </param>
/// <return>
/// %TRUE if the key @name is writable
/// </return>

	public static bool IsWritable(this MentorLake.Gio.GSettingsHandle settings, string name)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_is_writable(settings, name);
	}

/// <summary>
/// <para>
/// Gets the list of children on @settings.
/// </para>
/// <para>
/// The list is exactly the list of strings for which it is not an error
/// to call g_settings_get_child().
/// </para>
/// <para>
/// There is little reason to call this function from "normal" code, since
/// you should already know what children are in your schema. This function
/// may still be useful there for introspection reasons, however.
/// </para>
/// <para>
/// You should free the return value with g_strfreev() when you are done
/// with it.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <return>
/// a list of the children
///    on @settings, in no defined order
/// </return>

	public static string[] ListChildren(this MentorLake.Gio.GSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_list_children(settings);
	}

/// <summary>
/// <para>
/// Introspects the list of keys on @settings.
/// </para>
/// <para>
/// You should probably not be calling this function from "normal" code
/// (since you should already know what keys are in your schema).  This
/// function is intended for introspection reasons.
/// </para>
/// <para>
/// You should free the return value with g_strfreev() when you are done
/// with it.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <return>
/// a list
///    of the keys on @settings, in no defined order
/// </return>

	public static string[] ListKeys(this MentorLake.Gio.GSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_list_keys(settings);
	}

/// <summary>
/// <para>
/// Checks if the given @value is of the correct type and within the
/// permitted range for @key.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings
/// </param>
/// <param name="key">
/// the key to check
/// </param>
/// <param name="value">
/// the value to check
/// </param>
/// <return>
/// %TRUE if @value is valid for @key
/// </return>

	public static bool RangeCheck(this MentorLake.Gio.GSettingsHandle settings, string key, MentorLake.GLib.GVariantHandle value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_range_check(settings, key, value);
	}

/// <summary>
/// <para>
/// Resets @key to its default value.
/// </para>
/// <para>
/// This call resets the key, as much as possible, to its default value.
/// That might be the value specified in the schema or the one set by the
/// administrator.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of a key
/// </param>

	public static T Reset<T>(this T settings, string key) where T : GSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		GSettingsHandleExterns.g_settings_reset(settings, key);
		return settings;
	}

/// <summary>
/// <para>
/// Reverts all non-applied changes to the settings.  This function
/// does nothing unless @settings is in 'delay-apply' mode; see
/// g_settings_delay().  In the normal case settings are always applied
/// immediately.
/// </para>
/// <para>
/// Change notifications will be emitted for affected keys.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings instance
/// </param>

	public static T Revert<T>(this T settings) where T : GSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		GSettingsHandleExterns.g_settings_revert(settings);
		return settings;
	}

/// <summary>
/// <para>
/// Sets @key in @settings to @value.
/// </para>
/// <para>
/// A convenience function that combines g_settings_set_value() with
/// g_variant_new().
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't contained in the
/// schema for @settings or for the #GVariantType of @format to mismatch
/// the type given in the schema.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of the key to set
/// </param>
/// <param name="format">
/// a #GVariant format string
/// </param>
/// <param name="@__arglist">
/// arguments as per @format
/// </param>
/// <return>
/// %TRUE if setting the key succeeded,
///     %FALSE if the key was not writable
/// </return>

	public static bool Set(this MentorLake.Gio.GSettingsHandle settings, string key, string format, IntPtr @__arglist)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set(settings, key, format, @__arglist);
	}

/// <summary>
/// <para>
/// Sets @key in @settings to @value.
/// </para>
/// <para>
/// A convenience variant of g_settings_set() for booleans.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a boolean type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of the key to set
/// </param>
/// <param name="value">
/// the value to set it to
/// </param>
/// <return>
/// %TRUE if setting the key succeeded,
///     %FALSE if the key was not writable
/// </return>

	public static bool SetBoolean(this MentorLake.Gio.GSettingsHandle settings, string key, bool value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_boolean(settings, key, value);
	}

/// <summary>
/// <para>
/// Sets @key in @settings to @value.
/// </para>
/// <para>
/// A convenience variant of g_settings_set() for doubles.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a 'double' type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of the key to set
/// </param>
/// <param name="value">
/// the value to set it to
/// </param>
/// <return>
/// %TRUE if setting the key succeeded,
///     %FALSE if the key was not writable
/// </return>

	public static bool SetDouble(this MentorLake.Gio.GSettingsHandle settings, string key, double value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_double(settings, key, value);
	}

/// <summary>
/// <para>
/// Looks up the enumerated type nick for @value and writes it to @key,
/// within @settings.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't contained in the
/// schema for @settings or is not marked as an enumerated type, or for
/// @value not to be a valid value for the named type.
/// </para>
/// <para>
/// After performing the write, accessing @key directly with
/// g_settings_get_string() will return the 'nick' associated with
/// @value.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// a key, within @settings
/// </param>
/// <param name="value">
/// an enumerated value
/// </param>
/// <return>
/// %TRUE, if the set succeeds
/// </return>

	public static bool SetEnum(this MentorLake.Gio.GSettingsHandle settings, string key, int value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_enum(settings, key, value);
	}

/// <summary>
/// <para>
/// Looks up the flags type nicks for the bits specified by @value, puts
/// them in an array of strings and writes the array to @key, within
/// @settings.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't contained in the
/// schema for @settings or is not marked as a flags type, or for @value
/// to contain any bits that are not value for the named type.
/// </para>
/// <para>
/// After performing the write, accessing @key directly with
/// g_settings_get_strv() will return an array of 'nicks'; one for each
/// bit in @value.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// a key, within @settings
/// </param>
/// <param name="value">
/// a flags value
/// </param>
/// <return>
/// %TRUE, if the set succeeds
/// </return>

	public static bool SetFlags(this MentorLake.Gio.GSettingsHandle settings, string key, uint value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_flags(settings, key, value);
	}

/// <summary>
/// <para>
/// Sets @key in @settings to @value.
/// </para>
/// <para>
/// A convenience variant of g_settings_set() for 32-bit integers.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a int32 type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of the key to set
/// </param>
/// <param name="value">
/// the value to set it to
/// </param>
/// <return>
/// %TRUE if setting the key succeeded,
///     %FALSE if the key was not writable
/// </return>

	public static bool SetInt(this MentorLake.Gio.GSettingsHandle settings, string key, int value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_int(settings, key, value);
	}

/// <summary>
/// <para>
/// Sets @key in @settings to @value.
/// </para>
/// <para>
/// A convenience variant of g_settings_set() for 64-bit integers.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a int64 type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of the key to set
/// </param>
/// <param name="value">
/// the value to set it to
/// </param>
/// <return>
/// %TRUE if setting the key succeeded,
///     %FALSE if the key was not writable
/// </return>

	public static bool SetInt64(this MentorLake.Gio.GSettingsHandle settings, string key, long value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_int64(settings, key, value);
	}

/// <summary>
/// <para>
/// Sets @key in @settings to @value.
/// </para>
/// <para>
/// A convenience variant of g_settings_set() for strings.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a string type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of the key to set
/// </param>
/// <param name="value">
/// the value to set it to
/// </param>
/// <return>
/// %TRUE if setting the key succeeded,
///     %FALSE if the key was not writable
/// </return>

	public static bool SetString(this MentorLake.Gio.GSettingsHandle settings, string key, string value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_string(settings, key, value);
	}

/// <summary>
/// <para>
/// Sets @key in @settings to @value.
/// </para>
/// <para>
/// A convenience variant of g_settings_set() for string arrays.  If
/// @value is %NULL, then @key is set to be the empty array.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having an array of strings type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of the key to set
/// </param>
/// <param name="value">
/// the value to set it to, or %NULL
/// </param>
/// <return>
/// %TRUE if setting the key succeeded,
///     %FALSE if the key was not writable
/// </return>

	public static bool SetStrv(this MentorLake.Gio.GSettingsHandle settings, string key, string[] value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_strv(settings, key, value);
	}

/// <summary>
/// <para>
/// Sets @key in @settings to @value.
/// </para>
/// <para>
/// A convenience variant of g_settings_set() for 32-bit unsigned
/// integers.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a uint32 type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of the key to set
/// </param>
/// <param name="value">
/// the value to set it to
/// </param>
/// <return>
/// %TRUE if setting the key succeeded,
///     %FALSE if the key was not writable
/// </return>

	public static bool SetUint(this MentorLake.Gio.GSettingsHandle settings, string key, uint value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_uint(settings, key, value);
	}

/// <summary>
/// <para>
/// Sets @key in @settings to @value.
/// </para>
/// <para>
/// A convenience variant of g_settings_set() for 64-bit unsigned
/// integers.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't specified as
/// having a uint64 type in the schema for @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of the key to set
/// </param>
/// <param name="value">
/// the value to set it to
/// </param>
/// <return>
/// %TRUE if setting the key succeeded,
///     %FALSE if the key was not writable
/// </return>

	public static bool SetUint64(this MentorLake.Gio.GSettingsHandle settings, string key, ulong value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_uint64(settings, key, value);
	}

/// <summary>
/// <para>
/// Sets @key in @settings to @value.
/// </para>
/// <para>
/// It is a programmer error to give a @key that isn't contained in the
/// schema for @settings or for @value to have the incorrect type, per
/// the schema.
/// </para>
/// <para>
/// If @value is floating then this function consumes the reference.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GSettings object
/// </param>
/// <param name="key">
/// the name of the key to set
/// </param>
/// <param name="value">
/// a #GVariant of the correct type
/// </param>
/// <return>
/// %TRUE if setting the key succeeded,
///     %FALSE if the key was not writable
/// </return>

	public static bool SetValue(this MentorLake.Gio.GSettingsHandle settings, string key, MentorLake.GLib.GVariantHandle value)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GSettingsHandle)");
		return GSettingsHandleExterns.g_settings_set_value(settings, key, value);
	}

}

internal class GSettingsHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_new(string schema_id);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_new_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))] MentorLake.Gio.GSettingsSchemaHandle schema, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend, string path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_new_with_backend(string schema_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_new_with_backend_and_path(string schema_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend, string path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_new_with_path(string schema_id, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_apply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_bind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_bind_with_mapping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags, MentorLake.Gio.GSettingsBindGetMapping get_mapping, MentorLake.Gio.GSettingsBindSetMapping set_mapping, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_bind_with_mapping_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle get_mapping, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle set_mapping);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_bind_writable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property, bool inverted);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))]
	internal static extern MentorLake.Gio.GActionHandle g_settings_create_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_delay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_get_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_get_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_settings_get_default_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern double g_settings_get_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_settings_get_enum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_settings_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_get_has_unapplied([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_settings_get_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern long g_settings_get_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_settings_get_mapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, MentorLake.Gio.GSettingsGetMapping mapping, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_settings_get_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_settings_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_settings_get_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_settings_get_uint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern ulong g_settings_get_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_settings_get_user_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_settings_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_is_writable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_settings_list_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_settings_list_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_range_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_revert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, bool value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, double value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_enum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, int value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, uint value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, int value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, long value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, string value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, string[] value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_uint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, uint value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, ulong value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_settings_list_relocatable_schemas();

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_settings_list_schemas();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_sync();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_unbind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property);

}
