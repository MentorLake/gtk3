namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkBuilder is an auxiliary object that reads textual descriptions
/// of a user interface and instantiates the described objects. To create
/// a GtkBuilder from a user interface description, call
/// gtk_builder_new_from_file(), gtk_builder_new_from_resource() or
/// gtk_builder_new_from_string().
/// </para>
/// <para>
/// In the (unusual) case that you want to add user interface
/// descriptions from multiple sources to the same GtkBuilder you can
/// call gtk_builder_new() to get an empty builder and populate it by
/// (multiple) calls to gtk_builder_add_from_file(),
/// gtk_builder_add_from_resource() or gtk_builder_add_from_string().
/// </para>
/// <para>
/// A GtkBuilder holds a reference to all objects that it has constructed
/// and drops these references when it is finalized. This finalization can
/// cause the destruction of non-widget objects or widgets which are not
/// contained in a toplevel window. For toplevel windows constructed by a
/// builder, it is the responsibility of the user to call gtk_widget_destroy()
/// to get rid of them and all the widgets they contain.
/// </para>
/// <para>
/// The functions gtk_builder_get_object() and gtk_builder_get_objects()
/// can be used to access the widgets in the interface by the names assigned
/// to them inside the UI description. Toplevel windows returned by these
/// functions will stay around until the user explicitly destroys them
/// with gtk_widget_destroy(). Other widgets will either be part of a
/// larger hierarchy constructed by the builder (in which case you should
/// not have to worry about their lifecycle), or without a parent, in which
/// case they have to be added to some container to make use of them.
/// Non-widget objects need to be reffed with g_object_ref() to keep them
/// beyond the lifespan of the builder.
/// </para>
/// <para>
/// The function gtk_builder_connect_signals() and variants thereof can be
/// used to connect handlers to the named signals in the description.
/// </para>
/// <para>
/// # GtkBuilder UI Definitions # {#BUILDER-UI}
/// </para>
/// <para>
/// GtkBuilder parses textual descriptions of user interfaces which are
/// specified in an XML format which can be roughly described by the
/// RELAX NG schema below. We refer to these descriptions as “GtkBuilder
/// UI definitions” or just “UI definitions” if the context is clear.
/// Do not confuse GtkBuilder UI Definitions with
/// [GtkUIManager UI Definitions][XML-UI], which are more limited in scope.
/// It is common to use `.ui` as the filename extension for files containing
/// GtkBuilder UI definitions.
/// </para>
/// <para>
/// [RELAX NG Compact Syntax](https://gitlab.gnome.org/GNOME/gtk/-/blob/gtk-3-24/gtk/gtkbuilder.rnc)
/// </para>
/// <para>
/// The toplevel element is `&amp;lt;interface&amp;gt;`. It optionally takes a “domain”
/// attribute, which will make the builder look for translated strings
/// using dgettext() in the domain specified. This can also be done by
/// calling gtk_builder_set_translation_domain() on the builder.
/// Objects are described by `&amp;lt;object&amp;gt;` elements, which can contain
/// `&amp;lt;property&amp;gt;` elements to set properties, `&amp;lt;signal&amp;gt;` elements which
/// connect signals to handlers, and `&amp;lt;child&amp;gt;` elements, which describe
/// child objects (most often widgets inside a container, but also e.g.
/// actions in an action group, or columns in a tree model). A `&amp;lt;child&amp;gt;`
/// element contains an `&amp;lt;object&amp;gt;` element which describes the child object.
/// The target toolkit version(s) are described by `&amp;lt;requires&amp;gt;` elements,
/// the “lib” attribute specifies the widget library in question (currently
/// the only supported value is “gtk+”) and the “version” attribute specifies
/// the target version in the form `&amp;lt;major&amp;gt;.&amp;lt;minor&amp;gt;`. The builder will error
/// out if the version requirements are not met.
/// </para>
/// <para>
/// Typically, the specific kind of object represented by an `&amp;lt;object&amp;gt;`
/// element is specified by the “class” attribute. If the type has not
/// been loaded yet, GTK+ tries to find the `get_type()` function from the
/// class name by applying heuristics. This works in most cases, but if
/// necessary, it is possible to specify the name of the get_type() function
/// explictly with the &quot;type-func&quot; attribute. As a special case, GtkBuilder
/// allows to use an object that has been constructed by a #GtkUIManager in
/// another part of the UI definition by specifying the id of the #GtkUIManager
/// in the “constructor” attribute and the name of the object in the “id”
/// attribute.
/// </para>
/// <para>
/// Objects may be given a name with the “id” attribute, which allows the
/// application to retrieve them from the builder with gtk_builder_get_object().
/// An id is also necessary to use the object as property value in other
/// parts of the UI definition. GTK+ reserves ids starting and ending
/// with `___` (3 underscores) for its own purposes.
/// </para>
/// <para>
/// Setting properties of objects is pretty straightforward with the
/// `&amp;lt;property&amp;gt;` element: the “name” attribute specifies the name of the
/// property, and the content of the element specifies the value.
/// If the “translatable” attribute is set to a true value, GTK+ uses
/// gettext() (or dgettext() if the builder has a translation domain set)
/// to find a translation for the value. This happens before the value
/// is parsed, so it can be used for properties of any type, but it is
/// probably most useful for string properties. It is also possible to
/// specify a context to disambiguate short strings, and comments which
/// may help the translators.
/// </para>
/// <para>
/// GtkBuilder can parse textual representations for the most common
/// property types: characters, strings, integers, floating-point numbers,
/// booleans (strings like “TRUE”, “t”, “yes”, “y”, “1” are interpreted
/// as %TRUE, strings like “FALSE”, “f”, “no”, “n”, “0” are interpreted
/// as %FALSE), enumerations (can be specified by their name, nick or
/// integer value), flags (can be specified by their name, nick, integer
/// value, optionally combined with “|”, e.g. “GTK_VISIBLE|GTK_REALIZED”)
/// and colors (in a format understood by gdk_rgba_parse()).
/// </para>
/// <para>
/// GVariants can be specified in the format understood by g_variant_parse(),
/// and pixbufs can be specified as a filename of an image file to load.
/// </para>
/// <para>
/// Objects can be referred to by their name and by default refer to
/// objects declared in the local xml fragment and objects exposed via
/// gtk_builder_expose_object(). In general, GtkBuilder allows forward
/// references to objects — declared in the local xml; an object doesn’t
/// have to be constructed before it can be referred to. The exception
/// to this rule is that an object has to be constructed before it can
/// be used as the value of a construct-only property.
/// </para>
/// <para>
/// It is also possible to bind a property value to another object&apos;s
/// property value using the attributes
/// &quot;bind-source&quot; to specify the source object of the binding,
/// &quot;bind-property&quot; to specify the source property and optionally
/// &quot;bind-flags&quot; to specify the binding flags.
/// Internally builder implements this using GBinding objects.
/// For more information see g_object_bind_property()
/// </para>
/// <para>
/// Signal handlers are set up with the `&amp;lt;signal&amp;gt;` element. The “name”
/// attribute specifies the name of the signal, and the “handler” attribute
/// specifies the function to connect to the signal. By default, GTK+ tries
/// to find the handler using g_module_symbol(), but this can be changed by
/// passing a custom #GtkBuilderConnectFunc to
/// gtk_builder_connect_signals_full(). The remaining attributes, “after”,
/// “swapped” and “object”, have the same meaning as the corresponding
/// parameters of the g_signal_connect_object() or
/// g_signal_connect_data() functions. A “last_modification_time”
/// attribute is also allowed, but it does not have a meaning to the
/// builder.
/// </para>
/// <para>
/// Sometimes it is necessary to refer to widgets which have implicitly
/// been constructed by GTK+ as part of a composite widget, to set
/// properties on them or to add further children (e.g. the @vbox of
/// a #GtkDialog). This can be achieved by setting the “internal-child”
/// property of the `&amp;lt;child&amp;gt;` element to a true value. Note that GtkBuilder
/// still requires an `&amp;lt;object&amp;gt;` element for the internal child, even if it
/// has already been constructed.
/// </para>
/// <para>
/// A number of widgets have different places where a child can be added
/// (e.g. tabs vs. page content in notebooks). This can be reflected in
/// a UI definition by specifying the “type” attribute on a `&amp;lt;child&amp;gt;`
/// The possible values for the “type” attribute are described in the
/// sections describing the widget-specific portions of UI definitions.
/// </para>
/// <para>
/// # A GtkBuilder UI Definition
/// </para>
/// <code>
/// &amp;lt;interface&amp;gt;
/// &amp;lt;interface&amp;gt;
///   &amp;lt;object class=&quot;GtkDialog&quot; id=&quot;dialog1&quot;&amp;gt;
///     &amp;lt;child internal-child=&quot;vbox&quot;&amp;gt;
///       &amp;lt;object class=&quot;GtkBox&quot; id=&quot;vbox1&quot;&amp;gt;
///         &amp;lt;property name=&quot;border-width&quot;&amp;gt;10&amp;lt;/property&amp;gt;
///         &amp;lt;child internal-child=&quot;action_area&quot;&amp;gt;
///           &amp;lt;object class=&quot;GtkButtonBox&quot; id=&quot;hbuttonbox1&quot;&amp;gt;
///             &amp;lt;property name=&quot;border-width&quot;&amp;gt;20&amp;lt;/property&amp;gt;
///             &amp;lt;child&amp;gt;
///               &amp;lt;object class=&quot;GtkButton&quot; id=&quot;ok_button&quot;&amp;gt;
///                 &amp;lt;property name=&quot;label&quot;&amp;gt;gtk-ok&amp;lt;/property&amp;gt;
///                 &amp;lt;property name=&quot;use-stock&quot;&amp;gt;TRUE&amp;lt;/property&amp;gt;
///                 &amp;lt;signal name=&quot;clicked&quot; handler=&quot;ok_button_clicked&quot;/&amp;gt;
///               &amp;lt;/object&amp;gt;
///             &amp;lt;/child&amp;gt;
///           &amp;lt;/object&amp;gt;
///         &amp;lt;/child&amp;gt;
///       &amp;lt;/object&amp;gt;
///     &amp;lt;/child&amp;gt;
///   &amp;lt;/object&amp;gt;
/// &amp;lt;/interface&amp;gt;
/// </code>
/// <para>
/// Beyond this general structure, several object classes define their
/// own XML DTD fragments for filling in the ANY placeholders in the DTD
/// above. Note that a custom element in a `&amp;lt;child&amp;gt;` element gets parsed by
/// the custom tag handler of the parent object, while a custom element in
/// an `&amp;lt;object&amp;gt;` element gets parsed by the custom tag handler of the object.
/// </para>
/// <para>
/// These XML fragments are explained in the documentation of the
/// respective objects.
/// </para>
/// <para>
/// Additionally, since 3.10 a special `&amp;lt;template&amp;gt;` tag has been added
/// to the format allowing one to define a widget class’s components.
/// See the [GtkWidget documentation][composite-templates] for details.
/// </para>
/// </summary>

public class GtkBuilderHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new empty builder object.
/// </para>
/// <para>
/// This function is only useful if you intend to make multiple calls
/// to gtk_builder_add_from_file(), gtk_builder_add_from_resource()
/// or gtk_builder_add_from_string() in order to merge multiple UI
/// descriptions into a single builder.
/// </para>
/// <para>
/// Most users will probably want to use gtk_builder_new_from_file(),
/// gtk_builder_new_from_resource() or gtk_builder_new_from_string().
/// </para>
/// </summary>

/// <return>
/// a new (empty) #GtkBuilder object
/// </return>

	public static MentorLake.Gtk.GtkBuilderHandle New()
	{
		return GtkBuilderHandleExterns.gtk_builder_new();
	}

/// <summary>
/// <para>
/// Builds the [GtkBuilder UI definition][BUILDER-UI]
/// in the file @filename.
/// </para>
/// <para>
/// If there is an error opening the file or parsing the description then
/// the program will be aborted.  You should only ever attempt to parse
/// user interface descriptions that are shipped as part of your program.
/// </para>
/// </summary>

/// <param name="filename">
/// filename of user interface description file
/// </param>
/// <return>
/// a #GtkBuilder containing the described interface
/// </return>

	public static MentorLake.Gtk.GtkBuilderHandle NewFromFile(string filename)
	{
		return GtkBuilderHandleExterns.gtk_builder_new_from_file(filename);
	}

/// <summary>
/// <para>
/// Builds the [GtkBuilder UI definition][BUILDER-UI]
/// at @resource_path.
/// </para>
/// <para>
/// If there is an error locating the resource or parsing the
/// description, then the program will be aborted.
/// </para>
/// </summary>

/// <param name="resource_path">
/// a #GResource resource path
/// </param>
/// <return>
/// a #GtkBuilder containing the described interface
/// </return>

	public static MentorLake.Gtk.GtkBuilderHandle NewFromResource(string resource_path)
	{
		return GtkBuilderHandleExterns.gtk_builder_new_from_resource(resource_path);
	}

/// <summary>
/// <para>
/// Builds the user interface described by @string (in the
/// [GtkBuilder UI definition][BUILDER-UI] format).
/// </para>
/// <para>
/// If @string is %NULL-terminated, then @length should be -1.
/// If @length is not -1, then it is the length of @string.
/// </para>
/// <para>
/// If there is an error parsing @string then the program will be
/// aborted. You should not attempt to parse user interface description
/// from untrusted sources.
/// </para>
/// </summary>

/// <param name="@string">
/// a user interface (XML) description
/// </param>
/// <param name="length">
/// the length of @string, or -1
/// </param>
/// <return>
/// a #GtkBuilder containing the interface described by @string
/// </return>

	public static MentorLake.Gtk.GtkBuilderHandle NewFromString(string @string, UIntPtr length)
	{
		return GtkBuilderHandleExterns.gtk_builder_new_from_string(@string, length);
	}

}

public static class GtkBuilderHandleExtensions
{
/// <summary>
/// <para>
/// Adds the @callback_symbol to the scope of @builder under the given @callback_name.
/// </para>
/// <para>
/// Using this function overrides the behavior of gtk_builder_connect_signals()
/// for any callback symbols that are added. Using this method allows for better
/// encapsulation as it does not require that callback symbols be declared in
/// the global namespace.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="callback_name">
/// The name of the callback, as expected in the XML
/// </param>
/// <param name="callback_symbol">
/// The callback pointer
/// </param>

	public static T AddCallbackSymbol<T>(this T builder, string callback_name, MentorLake.GObject.GCallback callback_symbol) where T : GtkBuilderHandle
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		GtkBuilderHandleExterns.gtk_builder_add_callback_symbol(builder, callback_name, callback_symbol);
		return builder;
	}

/// <summary>
/// <para>
/// A convenience function to add many callbacks instead of calling
/// gtk_builder_add_callback_symbol() for each symbol.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="first_callback_name">
/// The name of the callback, as expected in the XML
/// </param>
/// <param name="first_callback_symbol">
/// The callback pointer
/// </param>
/// <param name="@__arglist">
/// A list of callback name and callback symbol pairs terminated with %NULL
/// </param>

	public static T AddCallbackSymbols<T>(this T builder, string first_callback_name, MentorLake.GObject.GCallback first_callback_symbol, IntPtr @__arglist) where T : GtkBuilderHandle
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		GtkBuilderHandleExterns.gtk_builder_add_callback_symbols(builder, first_callback_name, first_callback_symbol, @__arglist);
		return builder;
	}

/// <summary>
/// <para>
/// Parses a file containing a [GtkBuilder UI definition][BUILDER-UI]
/// and merges it with the current contents of @builder.
/// </para>
/// <para>
/// Most users will probably want to use gtk_builder_new_from_file().
/// </para>
/// <para>
/// If an error occurs, 0 will be returned and @error will be assigned a
/// #GError from the #GTK_BUILDER_ERROR, #G_MARKUP_ERROR or #G_FILE_ERROR
/// domain.
/// </para>
/// <para>
/// It’s not really reasonable to attempt to handle failures of this
/// call. You should not use this function with untrusted files (ie:
/// files that are not part of your application). Broken #GtkBuilder
/// files can easily crash your program, and it’s possible that memory
/// was leaked leading up to the reported failure. The only reasonable
/// thing to do when an error is detected is to call g_error().
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="filename">
/// the name of the file to parse
/// </param>
/// <return>
/// A positive value on success, 0 if an error occurred
/// </return>

	public static uint AddFromFile(this MentorLake.Gtk.GtkBuilderHandle builder, string filename)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_from_file(builder, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses a resource file containing a [GtkBuilder UI definition][BUILDER-UI]
/// and merges it with the current contents of @builder.
/// </para>
/// <para>
/// Most users will probably want to use gtk_builder_new_from_resource().
/// </para>
/// <para>
/// If an error occurs, 0 will be returned and @error will be assigned a
/// #GError from the #GTK_BUILDER_ERROR, #G_MARKUP_ERROR or #G_RESOURCE_ERROR
/// domain.
/// </para>
/// <para>
/// It’s not really reasonable to attempt to handle failures of this
/// call.  The only reasonable thing to do when an error is detected is
/// to call g_error().
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="resource_path">
/// the path of the resource file to parse
/// </param>
/// <return>
/// A positive value on success, 0 if an error occurred
/// </return>

	public static uint AddFromResource(this MentorLake.Gtk.GtkBuilderHandle builder, string resource_path)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_from_resource(builder, resource_path, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses a string containing a [GtkBuilder UI definition][BUILDER-UI]
/// and merges it with the current contents of @builder.
/// </para>
/// <para>
/// Most users will probably want to use gtk_builder_new_from_string().
/// </para>
/// <para>
/// Upon errors 0 will be returned and @error will be assigned a
/// #GError from the #GTK_BUILDER_ERROR, #G_MARKUP_ERROR or
/// #G_VARIANT_PARSE_ERROR domain.
/// </para>
/// <para>
/// It’s not really reasonable to attempt to handle failures of this
/// call.  The only reasonable thing to do when an error is detected is
/// to call g_error().
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="buffer">
/// the string to parse
/// </param>
/// <param name="length">
/// the length of @buffer (may be -1 if @buffer is nul-terminated)
/// </param>
/// <return>
/// A positive value on success, 0 if an error occurred
/// </return>

	public static uint AddFromString(this MentorLake.Gtk.GtkBuilderHandle builder, string buffer, UIntPtr length)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_from_string(builder, buffer, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses a file containing a [GtkBuilder UI definition][BUILDER-UI]
/// building only the requested objects and merges
/// them with the current contents of @builder.
/// </para>
/// <para>
/// Upon errors 0 will be returned and @error will be assigned a
/// #GError from the #GTK_BUILDER_ERROR, #G_MARKUP_ERROR or #G_FILE_ERROR
/// domain.
/// </para>
/// <para>
/// If you are adding an object that depends on an object that is not
/// its child (for instance a #GtkTreeView that depends on its
/// #GtkTreeModel), you have to explicitly list all of them in @object_ids.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="filename">
/// the name of the file to parse
/// </param>
/// <param name="object_ids">
/// nul-terminated array of objects to build
/// </param>
/// <return>
/// A positive value on success, 0 if an error occurred
/// </return>

	public static uint AddObjectsFromFile(this MentorLake.Gtk.GtkBuilderHandle builder, string filename, string[] object_ids)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_objects_from_file(builder, filename, object_ids, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses a resource file containing a [GtkBuilder UI definition][BUILDER-UI]
/// building only the requested objects and merges
/// them with the current contents of @builder.
/// </para>
/// <para>
/// Upon errors 0 will be returned and @error will be assigned a
/// #GError from the #GTK_BUILDER_ERROR, #G_MARKUP_ERROR or #G_RESOURCE_ERROR
/// domain.
/// </para>
/// <para>
/// If you are adding an object that depends on an object that is not
/// its child (for instance a #GtkTreeView that depends on its
/// #GtkTreeModel), you have to explicitly list all of them in @object_ids.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="resource_path">
/// the path of the resource file to parse
/// </param>
/// <param name="object_ids">
/// nul-terminated array of objects to build
/// </param>
/// <return>
/// A positive value on success, 0 if an error occurred
/// </return>

	public static uint AddObjectsFromResource(this MentorLake.Gtk.GtkBuilderHandle builder, string resource_path, string[] object_ids)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_objects_from_resource(builder, resource_path, object_ids, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses a string containing a [GtkBuilder UI definition][BUILDER-UI]
/// building only the requested objects and merges
/// them with the current contents of @builder.
/// </para>
/// <para>
/// Upon errors 0 will be returned and @error will be assigned a
/// #GError from the #GTK_BUILDER_ERROR or #G_MARKUP_ERROR domain.
/// </para>
/// <para>
/// If you are adding an object that depends on an object that is not
/// its child (for instance a #GtkTreeView that depends on its
/// #GtkTreeModel), you have to explicitly list all of them in @object_ids.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="buffer">
/// the string to parse
/// </param>
/// <param name="length">
/// the length of @buffer (may be -1 if @buffer is nul-terminated)
/// </param>
/// <param name="object_ids">
/// nul-terminated array of objects to build
/// </param>
/// <return>
/// A positive value on success, 0 if an error occurred
/// </return>

	public static uint AddObjectsFromString(this MentorLake.Gtk.GtkBuilderHandle builder, string buffer, UIntPtr length, string[] object_ids)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_add_objects_from_string(builder, buffer, length, object_ids, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This method is a simpler variation of gtk_builder_connect_signals_full().
/// It uses symbols explicitly added to @builder with prior calls to
/// gtk_builder_add_callback_symbol(). In the case that symbols are not
/// explicitly added; it uses #GModule’s introspective features (by opening the module %NULL)
/// to look at the application’s symbol table. From here it tries to match
/// the signal handler names given in the interface description with
/// symbols in the application and connects the signals. Note that this
/// function can only be called once, subsequent calls will do nothing.
/// </para>
/// <para>
/// Note that unless gtk_builder_add_callback_symbol() is called for
/// all signal callbacks which are referenced by the loaded XML, this
/// function will require that #GModule be supported on the platform.
/// </para>
/// <para>
/// If you rely on #GModule support to lookup callbacks in the symbol table,
/// the following details should be noted:
/// </para>
/// <para>
/// When compiling applications for Windows, you must declare signal callbacks
/// with #G_MODULE_EXPORT, or they will not be put in the symbol table.
/// On Linux and Unices, this is not necessary; applications should instead
/// be compiled with the -Wl,--export-dynamic CFLAGS, and linked against
/// gmodule-export-2.0.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="user_data">
/// user data to pass back with all signals
/// </param>

	public static T ConnectSignals<T>(this T builder, IntPtr user_data) where T : GtkBuilderHandle
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		GtkBuilderHandleExterns.gtk_builder_connect_signals(builder, user_data);
		return builder;
	}

/// <summary>
/// <para>
/// This function can be thought of the interpreted language binding
/// version of gtk_builder_connect_signals(), except that it does not
/// require GModule to function correctly.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="func">
/// the function used to connect the signals
/// </param>
/// <param name="user_data">
/// arbitrary data that will be passed to the connection function
/// </param>

	public static T ConnectSignalsFull<T>(this T builder, MentorLake.Gtk.GtkBuilderConnectFunc func, IntPtr user_data) where T : GtkBuilderHandle
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		GtkBuilderHandleExterns.gtk_builder_connect_signals_full(builder, func, user_data);
		return builder;
	}

/// <summary>
/// <para>
/// Add @object to the @builder object pool so it can be referenced just like any
/// other object built by builder.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="name">
/// the name of the object exposed to the builder
/// </param>
/// <param name="@object">
/// the object to expose
/// </param>

	public static T ExposeObject<T>(this T builder, string name, MentorLake.GObject.GObjectHandle @object) where T : GtkBuilderHandle
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		GtkBuilderHandleExterns.gtk_builder_expose_object(builder, name, @object);
		return builder;
	}

/// <summary>
/// <para>
/// Main private entry point for building composite container
/// components from template XML.
/// </para>
/// <para>
/// This is exported purely to let gtk-builder-tool validate
/// templates, applications have no need to call this function.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="widget">
/// the widget that is being extended
/// </param>
/// <param name="template_type">
/// the type that the template is for
/// </param>
/// <param name="buffer">
/// the string to parse
/// </param>
/// <param name="length">
/// the length of @buffer (may be -1 if @buffer is nul-terminated)
/// </param>
/// <return>
/// A positive value on success, 0 if an error occurred
/// </return>

	public static uint ExtendWithTemplate(this MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType template_type, string buffer, UIntPtr length)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_extend_with_template(builder, widget, template_type, buffer, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the #GtkApplication associated with the builder.
/// </para>
/// <para>
/// The #GtkApplication is used for creating action proxies as requested
/// from XML that the builder is loading.
/// </para>
/// <para>
/// By default, the builder uses the default application: the one from
/// g_application_get_default(). If you want to use another application
/// for constructing proxies, use gtk_builder_set_application().
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <return>
/// the application being used by the builder,
///     or %NULL
/// </return>

	public static MentorLake.Gtk.GtkApplicationHandle GetApplication(this MentorLake.Gtk.GtkBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		return GtkBuilderHandleExterns.gtk_builder_get_application(builder);
	}

/// <summary>
/// <para>
/// Gets the object named @name. Note that this function does not
/// increment the reference count of the returned object.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="name">
/// name of object to get
/// </param>
/// <return>
/// the object named @name or %NULL if
///    it could not be found in the object tree.
/// </return>

	public static MentorLake.GObject.GObjectHandle GetObject(this MentorLake.Gtk.GtkBuilderHandle builder, string name)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		return GtkBuilderHandleExterns.gtk_builder_get_object(builder, name);
	}

/// <summary>
/// <para>
/// Gets all objects that have been constructed by @builder. Note that
/// this function does not increment the reference counts of the returned
/// objects.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <return>
/// a newly-allocated #GSList containing all the objects
///   constructed by the #GtkBuilder instance. It should be freed by
///   g_slist_free()
/// </return>

	public static MentorLake.GLib.GSListHandle GetObjects(this MentorLake.Gtk.GtkBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		return GtkBuilderHandleExterns.gtk_builder_get_objects(builder);
	}

/// <summary>
/// <para>
/// Gets the translation domain of @builder.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <return>
/// the translation domain. This string is owned
/// by the builder object and must not be modified or freed.
/// </return>

	public static string GetTranslationDomain(this MentorLake.Gtk.GtkBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		return GtkBuilderHandleExterns.gtk_builder_get_translation_domain(builder);
	}

/// <summary>
/// <para>
/// Looks up a type by name, using the virtual function that
/// #GtkBuilder has for that purpose. This is mainly used when
/// implementing the #GtkBuildable interface on a type.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="type_name">
/// type name to lookup
/// </param>
/// <return>
/// the #GType found for @type_name or #G_TYPE_INVALID
///   if no type was found
/// </return>

	public static MentorLake.GObject.GType GetTypeFromName(this MentorLake.Gtk.GtkBuilderHandle builder, string type_name)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		return GtkBuilderHandleExterns.gtk_builder_get_type_from_name(builder, type_name);
	}

/// <summary>
/// <para>
/// Fetches a symbol previously added to @builder
/// with gtk_builder_add_callback_symbols()
/// </para>
/// <para>
/// This function is intended for possible use in language bindings
/// or for any case that one might be cusomizing signal connections
/// using gtk_builder_connect_signals_full()
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="callback_name">
/// The name of the callback
/// </param>
/// <return>
/// The callback symbol in @builder for @callback_name, or %NULL
/// </return>

	public static MentorLake.GObject.GCallback LookupCallbackSymbol(this MentorLake.Gtk.GtkBuilderHandle builder, string callback_name)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		return GtkBuilderHandleExterns.gtk_builder_lookup_callback_symbol(builder, callback_name);
	}

/// <summary>
/// <para>
/// Sets the application associated with @builder.
/// </para>
/// <para>
/// You only need this function if there is more than one #GApplication
/// in your process. @application cannot be %NULL.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="application">
/// a #GtkApplication
/// </param>

	public static T SetApplication<T>(this T builder, MentorLake.Gtk.GtkApplicationHandle application) where T : GtkBuilderHandle
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		GtkBuilderHandleExterns.gtk_builder_set_application(builder, application);
		return builder;
	}

/// <summary>
/// <para>
/// Sets the translation domain of @builder.
/// See #GtkBuilder:translation-domain.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="domain">
/// the translation domain or %NULL
/// </param>

	public static T SetTranslationDomain<T>(this T builder, string domain) where T : GtkBuilderHandle
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		GtkBuilderHandleExterns.gtk_builder_set_translation_domain(builder, domain);
		return builder;
	}

/// <summary>
/// <para>
/// This function demarshals a value from a string. This function
/// calls g_value_init() on the @value argument, so it need not be
/// initialised beforehand.
/// </para>
/// <para>
/// This function can handle char, uchar, boolean, int, uint, long,
/// ulong, enum, flags, float, double, string, #GdkColor, #GdkRGBA and
/// #GtkAdjustment type values. Support for #GtkWidget type values is
/// still to come.
/// </para>
/// <para>
/// Upon errors %FALSE will be returned and @error will be assigned a
/// #GError from the #GTK_BUILDER_ERROR domain.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="pspec">
/// the #GParamSpec for the property
/// </param>
/// <param name="@string">
/// the string representation of the value
/// </param>
/// <param name="value">
/// the #GValue to store the result in
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool ValueFromString(this MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GParamSpecHandle pspec, string @string, out MentorLake.GObject.GValue value)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_value_from_string(builder, pspec, @string, out value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Like gtk_builder_value_from_string(), this function demarshals
/// a value from a string, but takes a #GType instead of #GParamSpec.
/// This function calls g_value_init() on the @value argument, so it
/// need not be initialised beforehand.
/// </para>
/// <para>
/// Upon errors %FALSE will be returned and @error will be assigned a
/// #GError from the #GTK_BUILDER_ERROR domain.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GtkBuilder
/// </param>
/// <param name="type">
/// the #GType of the value
/// </param>
/// <param name="@string">
/// the string representation of the value
/// </param>
/// <param name="value">
/// the #GValue to store the result in
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool ValueFromStringType(this MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GType type, string @string, out MentorLake.GObject.GValue value)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GtkBuilderHandle)");
		var externCallResult = GtkBuilderHandleExterns.gtk_builder_value_from_string_type(builder, type, @string, out value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GtkBuilderHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))]
	internal static extern MentorLake.Gtk.GtkBuilderHandle gtk_builder_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))]
	internal static extern MentorLake.Gtk.GtkBuilderHandle gtk_builder_new_from_file(string filename);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))]
	internal static extern MentorLake.Gtk.GtkBuilderHandle gtk_builder_new_from_resource(string resource_path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))]
	internal static extern MentorLake.Gtk.GtkBuilderHandle gtk_builder_new_from_string(string @string, UIntPtr length);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_add_callback_symbol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string callback_name, MentorLake.GObject.GCallback callback_symbol);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_add_callback_symbols([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string first_callback_name, MentorLake.GObject.GCallback first_callback_symbol, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_from_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string resource_path, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string buffer, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_objects_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string filename, string[] object_ids, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_objects_from_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string resource_path, string[] object_ids, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_add_objects_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string buffer, UIntPtr length, string[] object_ids, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_connect_signals([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_connect_signals_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.Gtk.GtkBuilderConnectFunc func, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_expose_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_builder_extend_with_template([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType template_type, string buffer, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))]
	internal static extern MentorLake.Gtk.GtkApplicationHandle gtk_builder_get_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle gtk_builder_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_builder_get_objects([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_builder_get_translation_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType gtk_builder_get_type_from_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string type_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GCallback gtk_builder_lookup_callback_symbol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string callback_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_set_application([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkApplicationHandle>))] MentorLake.Gtk.GtkApplicationHandle application);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_builder_set_translation_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, string domain);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_builder_value_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, string @string, out MentorLake.GObject.GValue value, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_builder_value_from_string_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBuilderHandle>))] MentorLake.Gtk.GtkBuilderHandle builder, MentorLake.GObject.GType type, string @string, out MentorLake.GObject.GValue value, out MentorLake.GLib.GErrorHandle error);

}
