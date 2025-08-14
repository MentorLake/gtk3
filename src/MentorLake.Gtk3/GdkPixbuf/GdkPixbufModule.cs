namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// A `GdkPixbufModule` contains the necessary functions to load and save
/// images in a certain file format.
/// </para>
/// <para>
/// If `GdkPixbuf` has been compiled with `GModule` support, it can be extended
/// by modules which can load (and perhaps also save) new image and animation
/// formats.
/// </para>
/// <para>
/// ## Implementing modules
/// </para>
/// <para>
/// The `GdkPixbuf` interfaces needed for implementing modules are contained in
/// `gdk-pixbuf-io.h` (and `gdk-pixbuf-animation.h` if the module supports
/// animations). They are not covered by the same stability guarantees as the
/// regular GdkPixbuf API. To underline this fact, they are protected by the
/// `GDK_PIXBUF_ENABLE_BACKEND` pre-processor symbol.
/// </para>
/// <para>
/// Each loadable module must contain a `GdkPixbufModuleFillVtableFunc` function
/// named `fill_vtable`, which will get called when the module
/// is loaded and must set the function pointers of the `GdkPixbufModule`.
/// </para>
/// <para>
/// In order to make format-checking work before actually loading the modules
/// (which may require calling `dlopen` to load image libraries), modules export
/// their signatures (and other information) via the `fill_info` function. An
/// external utility, `gdk-pixbuf-query-loaders`, uses this to create a text
/// file containing a list of all available loaders and  their signatures.
/// This file is then read at runtime by `GdkPixbuf` to obtain the list of
/// available loaders and their signatures.
/// </para>
/// <para>
/// Modules may only implement a subset of the functionality available via
/// `GdkPixbufModule`. If a particular functionality is not implemented, the
/// `fill_vtable` function will simply not set the corresponding
/// function pointers of the `GdkPixbufModule` structure. If a module supports
/// incremental loading (i.e. provides `begin_load`, `stop_load` and
/// `load_increment`), it doesn't have to implement `load`, since `GdkPixbuf`
/// can supply a generic `load` implementation wrapping the incremental loading.
/// </para>
/// <para>
/// ## Installing modules
/// </para>
/// <para>
/// Installing a module is a two-step process:
/// </para>
/// <para>
///  - copy the module file(s) to the loader directory (normally
///    `$libdir/gdk-pixbuf-2.0/$version/loaders`, unless overridden by the
///    environment variable `GDK_PIXBUF_MODULEDIR`)
///  - call `gdk-pixbuf-query-loaders` to update the module file (normally
///    `$libdir/gdk-pixbuf-2.0/$version/loaders.cache`, unless overridden
///    by the environment variable `GDK_PIXBUF_MODULE_FILE`)
/// </para>
/// </summary>

public class GdkPixbufModuleHandle : BaseSafeHandle
{
}


public static class GdkPixbufModuleExtensions
{

	public static GdkPixbufModule Dereference(this GdkPixbufModuleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixbufModule>(x.DangerousGetHandle());
}
internal class GdkPixbufModuleExterns
{
}

/// <summary>
/// <para>
/// A `GdkPixbufModule` contains the necessary functions to load and save
/// images in a certain file format.
/// </para>
/// <para>
/// If `GdkPixbuf` has been compiled with `GModule` support, it can be extended
/// by modules which can load (and perhaps also save) new image and animation
/// formats.
/// </para>
/// <para>
/// ## Implementing modules
/// </para>
/// <para>
/// The `GdkPixbuf` interfaces needed for implementing modules are contained in
/// `gdk-pixbuf-io.h` (and `gdk-pixbuf-animation.h` if the module supports
/// animations). They are not covered by the same stability guarantees as the
/// regular GdkPixbuf API. To underline this fact, they are protected by the
/// `GDK_PIXBUF_ENABLE_BACKEND` pre-processor symbol.
/// </para>
/// <para>
/// Each loadable module must contain a `GdkPixbufModuleFillVtableFunc` function
/// named `fill_vtable`, which will get called when the module
/// is loaded and must set the function pointers of the `GdkPixbufModule`.
/// </para>
/// <para>
/// In order to make format-checking work before actually loading the modules
/// (which may require calling `dlopen` to load image libraries), modules export
/// their signatures (and other information) via the `fill_info` function. An
/// external utility, `gdk-pixbuf-query-loaders`, uses this to create a text
/// file containing a list of all available loaders and  their signatures.
/// This file is then read at runtime by `GdkPixbuf` to obtain the list of
/// available loaders and their signatures.
/// </para>
/// <para>
/// Modules may only implement a subset of the functionality available via
/// `GdkPixbufModule`. If a particular functionality is not implemented, the
/// `fill_vtable` function will simply not set the corresponding
/// function pointers of the `GdkPixbufModule` structure. If a module supports
/// incremental loading (i.e. provides `begin_load`, `stop_load` and
/// `load_increment`), it doesn't have to implement `load`, since `GdkPixbuf`
/// can supply a generic `load` implementation wrapping the incremental loading.
/// </para>
/// <para>
/// ## Installing modules
/// </para>
/// <para>
/// Installing a module is a two-step process:
/// </para>
/// <para>
///  - copy the module file(s) to the loader directory (normally
///    `$libdir/gdk-pixbuf-2.0/$version/loaders`, unless overridden by the
///    environment variable `GDK_PIXBUF_MODULEDIR`)
///  - call `gdk-pixbuf-query-loaders` to update the module file (normally
///    `$libdir/gdk-pixbuf-2.0/$version/loaders.cache`, unless overridden
///    by the environment variable `GDK_PIXBUF_MODULE_FILE`)
/// </para>
/// </summary>

public struct GdkPixbufModule
{
	/// <summary>
/// <para>
/// the name of the module, usually the same as the
///  usual file extension for images of this type, eg. "xpm", "jpeg" or "png".
/// </para>
/// </summary>

public string module_name;
	/// <summary>
/// <para>
/// the path from which the module is loaded.
/// </para>
/// </summary>

public string module_path;
	/// <summary>
/// <para>
/// the loaded `GModule`.
/// </para>
/// </summary>

public IntPtr module;
	/// <summary>
/// <para>
/// a `GdkPixbufFormat` holding information about the module.
/// </para>
/// </summary>

public IntPtr info;
	/// <summary>
/// <para>
/// loads an image from a file.
/// </para>
/// </summary>

public GdkPixbufModuleLoadFunc load;
	/// <summary>
/// <para>
/// loads an image from data in memory.
/// </para>
/// </summary>

public GdkPixbufModuleLoadXpmDataFunc load_xpm_data;
	/// <summary>
/// <para>
/// begins an incremental load.
/// </para>
/// </summary>

public GdkPixbufModuleBeginLoadFunc begin_load;
	/// <summary>
/// <para>
/// stops an incremental load.
/// </para>
/// </summary>

public GdkPixbufModuleStopLoadFunc stop_load;
	/// <summary>
/// <para>
/// continues an incremental load.
/// </para>
/// </summary>

public GdkPixbufModuleIncrementLoadFunc load_increment;
	/// <summary>
/// <para>
/// loads an animation from a file.
/// </para>
/// </summary>

public GdkPixbufModuleLoadAnimationFunc load_animation;
	/// <summary>
/// <para>
/// saves a `GdkPixbuf` to a file.
/// </para>
/// </summary>

public GdkPixbufModuleSaveFunc save;
	/// <summary>
/// <para>
/// saves a `GdkPixbuf` by calling the given `GdkPixbufSaveFunc`.
/// </para>
/// </summary>

public GdkPixbufModuleSaveCallbackFunc save_to_callback;
	/// <summary>
/// <para>
/// returns whether a save option key is supported by the module
/// </para>
/// </summary>

public GdkPixbufModuleSaveOptionSupportedFunc is_save_option_supported;
	
public IntPtr _reserved1;
	
public IntPtr _reserved2;
	
public IntPtr _reserved3;
	
public IntPtr _reserved4;
}
