namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Carries details to be shown in user-facing dialogs.
/// </para>
/// </summary>

public class WebKitScriptDialogHandle : BaseSafeHandle
{
}


public static class WebKitScriptDialogExtensions
{
/// <summary>
/// <para>
/// Close @dialog.
/// </para>
/// <para>
/// When handling a #WebKitScriptDialog asynchronously (webkit_script_dialog_ref()
/// was called in #WebKitWebView::script-dialog callback), this function needs to be called to notify
/// that we are done with the script dialog. The dialog will be closed on destruction if this function
/// hasn&apos;t been called before.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #WebKitScriptDialog
/// </param>

	public static void Close(this MentorLake.WebKit2.WebKitScriptDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (WebKitScriptDialog)");
		WebKitScriptDialogExterns.webkit_script_dialog_close(dialog);
	}

/// <summary>
/// <para>
/// Set whether the user confirmed the dialog.
/// </para>
/// <para>
/// This method is used for %WEBKIT_SCRIPT_DIALOG_CONFIRM and %WEBKIT_SCRIPT_DIALOG_BEFORE_UNLOAD_CONFIRM dialogs when
/// #WebKitWebView::script-dialog signal is emitted to set whether the user
/// confirmed the dialog or not. The default implementation of #WebKitWebView::script-dialog
/// signal sets %TRUE when the OK or Stay buttons are clicked and %FALSE otherwise.
/// It&apos;s an error to use this method with a #WebKitScriptDialog that is not of type
/// %WEBKIT_SCRIPT_DIALOG_CONFIRM or %WEBKIT_SCRIPT_DIALOG_BEFORE_UNLOAD_CONFIRM
/// </para>
/// </summary>

/// <param name="dialog">
/// a #WebKitScriptDialog
/// </param>
/// <param name="confirmed">
/// whether user confirmed the dialog
/// </param>

	public static void ConfirmSetConfirmed(this MentorLake.WebKit2.WebKitScriptDialogHandle dialog, bool confirmed)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (WebKitScriptDialog)");
		WebKitScriptDialogExterns.webkit_script_dialog_confirm_set_confirmed(dialog, confirmed);
	}

/// <summary>
/// <para>
/// Get the dialog type of a #WebKitScriptDialog.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #WebKitScriptDialog
/// </param>
/// <return>
/// the #WebKitScriptDialogType of @dialog
/// </return>

	public static MentorLake.WebKit2.WebKitScriptDialogType GetDialogType(this MentorLake.WebKit2.WebKitScriptDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (WebKitScriptDialog)");
		return WebKitScriptDialogExterns.webkit_script_dialog_get_dialog_type(dialog);
	}

/// <summary>
/// <para>
/// Get the message of a #WebKitScriptDialog.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #WebKitScriptDialog
/// </param>
/// <return>
/// the message of @dialog.
/// </return>

	public static string GetMessage(this MentorLake.WebKit2.WebKitScriptDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (WebKitScriptDialog)");
		return WebKitScriptDialogExterns.webkit_script_dialog_get_message(dialog);
	}

/// <summary>
/// <para>
/// Get the default text of a #WebKitScriptDialog of type %WEBKIT_SCRIPT_DIALOG_PROMPT.
/// </para>
/// <para>
/// It&apos;s an error to use this method with a #WebKitScriptDialog that is not of type
/// %WEBKIT_SCRIPT_DIALOG_PROMPT.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #WebKitScriptDialog
/// </param>
/// <return>
/// the default text of @dialog
/// </return>

	public static string PromptGetDefaultText(this MentorLake.WebKit2.WebKitScriptDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (WebKitScriptDialog)");
		return WebKitScriptDialogExterns.webkit_script_dialog_prompt_get_default_text(dialog);
	}

/// <summary>
/// <para>
/// Set the text entered by the user in the dialog.
/// </para>
/// <para>
/// This method is used for %WEBKIT_SCRIPT_DIALOG_PROMPT dialogs when
/// #WebKitWebView::script-dialog signal is emitted to set the text
/// entered by the user. The default implementation of #WebKitWebView::script-dialog
/// signal sets the text of the entry form when OK button is clicked, otherwise %NULL is set.
/// It&apos;s an error to use this method with a #WebKitScriptDialog that is not of type
/// %WEBKIT_SCRIPT_DIALOG_PROMPT.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #WebKitScriptDialog
/// </param>
/// <param name="text">
/// the text to set
/// </param>

	public static void PromptSetText(this MentorLake.WebKit2.WebKitScriptDialogHandle dialog, string text)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (WebKitScriptDialog)");
		WebKitScriptDialogExterns.webkit_script_dialog_prompt_set_text(dialog, text);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @dialog by one.
/// </para>
/// <para>
/// This
/// function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #WebKitScriptDialog
/// </param>
/// <return>
/// The passed in #WebKitScriptDialog
/// </return>

	public static MentorLake.WebKit2.WebKitScriptDialogHandle Ref(this MentorLake.WebKit2.WebKitScriptDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (WebKitScriptDialog)");
		return WebKitScriptDialogExterns.webkit_script_dialog_ref(dialog);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @dialog by one.
/// </para>
/// <para>
/// If the
/// reference count drops to 0, all memory allocated by the #WebKitScriptdialog is
/// released. This function is MT-safe and may be called from any
/// thread.
/// </para>
/// </summary>

/// <param name="dialog">
/// a #WebKitScriptDialog
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitScriptDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (WebKitScriptDialog)");
		WebKitScriptDialogExterns.webkit_script_dialog_unref(dialog);
	}


	public static WebKitScriptDialog Dereference(this WebKitScriptDialogHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitScriptDialog>(x.DangerousGetHandle());
}
internal class WebKitScriptDialogExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_script_dialog_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptDialogHandle>))] MentorLake.WebKit2.WebKitScriptDialogHandle dialog);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_script_dialog_confirm_set_confirmed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptDialogHandle>))] MentorLake.WebKit2.WebKitScriptDialogHandle dialog, bool confirmed);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitScriptDialogType webkit_script_dialog_get_dialog_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptDialogHandle>))] MentorLake.WebKit2.WebKitScriptDialogHandle dialog);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_script_dialog_get_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptDialogHandle>))] MentorLake.WebKit2.WebKitScriptDialogHandle dialog);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_script_dialog_prompt_get_default_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptDialogHandle>))] MentorLake.WebKit2.WebKitScriptDialogHandle dialog);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_script_dialog_prompt_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptDialogHandle>))] MentorLake.WebKit2.WebKitScriptDialogHandle dialog, string text);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptDialogHandle>))]
	internal static extern MentorLake.WebKit2.WebKitScriptDialogHandle webkit_script_dialog_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptDialogHandle>))] MentorLake.WebKit2.WebKitScriptDialogHandle dialog);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_script_dialog_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitScriptDialogHandle>))] MentorLake.WebKit2.WebKitScriptDialogHandle dialog);

}

/// <summary>
/// <para>
/// Carries details to be shown in user-facing dialogs.
/// </para>
/// </summary>

public struct WebKitScriptDialog
{
}
