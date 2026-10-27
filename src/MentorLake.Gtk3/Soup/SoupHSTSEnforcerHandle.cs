namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Automatic HTTP Strict Transport Security enforcing for [class@Session].
/// </para>
/// <para>
/// A [class@HSTSEnforcer] stores HSTS policies and enforces them when
/// required. [class@HSTSEnforcer] implements [iface@SessionFeature], so you
/// can add an HSTS enforcer to a session with
/// [method@Session.add_feature] or [method@Session.add_feature_by_type].
/// </para>
/// <para>
/// [class@HSTSEnforcer] keeps track of all the HTTPS destinations that,
/// when connected to, return the Strict-Transport-Security header with
/// valid values. [class@HSTSEnforcer] will forget those destinations
/// upon expiry or when the server requests it.
/// </para>
/// <para>
/// When the [class@Session] the [class@HSTSEnforcer] is attached to queues or
/// restarts a message, the [class@HSTSEnforcer] will rewrite the URI to HTTPS if
/// the destination is a known HSTS host and is contacted over an insecure
/// transport protocol (HTTP). Users of [class@HSTSEnforcer] are advised to listen
/// to changes in the [property@Message:uri] property in order to be aware of
/// changes in the message URI.
/// </para>
/// <para>
/// Note that [class@HSTSEnforcer] does not support any form of long-term
/// HSTS policy persistence. See [class@HSTSEnforcerDB] for a persistent
/// enforcer.
/// </para>
/// </summary>

public class SoupHSTSEnforcerHandle : GObjectHandle, SoupSessionFeatureHandle
{
/// <summary>
/// <para>
/// Creates a new [class@HSTSEnforcer].
/// </para>
/// <para>
/// The base [class@HSTSEnforcer] class does not support persistent storage of HSTS
/// policies, see [class@HSTSEnforcerDB] for that.
/// </para>
/// </summary>

/// <return>
/// a new #SoupHSTSEnforcer
/// </return>

	public static MentorLake.Soup.SoupHSTSEnforcerHandle New()
	{
		return SoupHSTSEnforcerHandleExterns.soup_hsts_enforcer_new();
	}

}
public static class SoupHSTSEnforcerHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when @hsts_enforcer changes.
/// </para>
/// <para>
/// If a policy has been added,
/// @new_policy will contain the newly-added policy and
/// @old_policy will be %NULL. If a policy has been deleted,
/// @old_policy will contain the to-be-deleted policy and
/// @new_policy will be %NULL. If a policy has been changed,
/// @old_policy will contain its old value, and @new_policy its
/// new value.
/// </para>
/// <para>
/// Note that you shouldn&apos;t modify the policies from a callback to
/// this signal.
/// </para>
/// </summary>

	public static IObservable<SoupHSTSEnforcerHandleSignalStructs.ChangedSignal> Signal_Changed(this SoupHSTSEnforcerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<SoupHSTSEnforcerHandleSignalStructs.ChangedSignal> obs) =>
		{
			SoupHSTSEnforcerHandleSignalDelegates.changed handler = ( MentorLake.Soup.SoupHSTSEnforcerHandle self,  MentorLake.Soup.SoupHSTSPolicyHandle old_policy,  MentorLake.Soup.SoupHSTSPolicyHandle new_policy,  IntPtr user_data) =>
			{
				

				var signalStruct = new SoupHSTSEnforcerHandleSignalStructs.ChangedSignal()
				{
					Self = self, OldPolicy = old_policy, NewPolicy = new_policy, UserData = user_data
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
}

public static class SoupHSTSEnforcerHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Soup.SoupHSTSEnforcerHandle Self;
/// <summary>
/// <para>
/// the old #SoupHSTSPolicy value
/// </para>
/// </summary>

	public MentorLake.Soup.SoupHSTSPolicyHandle OldPolicy;
/// <summary>
/// <para>
/// the new #SoupHSTSPolicy value
/// </para>
/// </summary>

	public MentorLake.Soup.SoupHSTSPolicyHandle NewPolicy;

	public IntPtr UserData;
}
}

public static class SoupHSTSEnforcerHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when @hsts_enforcer changes.
/// </para>
/// <para>
/// If a policy has been added,
/// @new_policy will contain the newly-added policy and
/// @old_policy will be %NULL. If a policy has been deleted,
/// @old_policy will contain the to-be-deleted policy and
/// @new_policy will be %NULL. If a policy has been changed,
/// @old_policy will contain its old value, and @new_policy its
/// new value.
/// </para>
/// <para>
/// Note that you shouldn&apos;t modify the policies from a callback to
/// this signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="old_policy">
/// the old #SoupHSTSPolicy value
/// </param>
/// <param name="new_policy">
/// the new #SoupHSTSPolicy value
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSEnforcerHandle>))] MentorLake.Soup.SoupHSTSEnforcerHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle old_policy, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle new_policy, IntPtr user_data);

}


public static class SoupHSTSEnforcerHandleExtensions
{
/// <summary>
/// <para>
/// Gets a list of domains for which there are policies in @enforcer.
/// </para>
/// </summary>

/// <param name="hsts_enforcer">
/// a #SoupHSTSEnforcer
/// </param>
/// <param name="session_policies">
/// whether to include session policies
/// </param>
/// <return>
/// a newly allocated
///   list of domains. Use [func@GLib.List.free_full] and [func@GLib.free] to free the
///   list.
/// </return>

	public static MentorLake.GLib.GListHandle GetDomains(this MentorLake.Soup.SoupHSTSEnforcerHandle hsts_enforcer, bool session_policies)
	{
		if (hsts_enforcer.IsInvalid) throw new Exception("Invalid handle (SoupHSTSEnforcerHandle)");
		return SoupHSTSEnforcerHandleExterns.soup_hsts_enforcer_get_domains(hsts_enforcer, session_policies);
	}

/// <summary>
/// <para>
/// Gets a list with the policies in @enforcer.
/// </para>
/// </summary>

/// <param name="hsts_enforcer">
/// a #SoupHSTSEnforcer
/// </param>
/// <param name="session_policies">
/// whether to include session policies
/// </param>
/// <return>
/// a newly
///   allocated list of policies. Use [func@GLib.List.free_full] and
///   [method@HSTSPolicy.free] to free the list.
/// </return>

	public static MentorLake.GLib.GListHandle GetPolicies(this MentorLake.Soup.SoupHSTSEnforcerHandle hsts_enforcer, bool session_policies)
	{
		if (hsts_enforcer.IsInvalid) throw new Exception("Invalid handle (SoupHSTSEnforcerHandle)");
		return SoupHSTSEnforcerHandleExterns.soup_hsts_enforcer_get_policies(hsts_enforcer, session_policies);
	}

/// <summary>
/// <para>
/// Gets whether @hsts_enforcer has a currently valid policy for @domain.
/// </para>
/// </summary>

/// <param name="hsts_enforcer">
/// a #SoupHSTSEnforcer
/// </param>
/// <param name="domain">
/// a domain.
/// </param>
/// <return>
/// %TRUE if access to @domain should happen over HTTPS, false
///   otherwise.
/// </return>

	public static bool HasValidPolicy(this MentorLake.Soup.SoupHSTSEnforcerHandle hsts_enforcer, string domain)
	{
		if (hsts_enforcer.IsInvalid) throw new Exception("Invalid handle (SoupHSTSEnforcerHandle)");
		return SoupHSTSEnforcerHandleExterns.soup_hsts_enforcer_has_valid_policy(hsts_enforcer, domain);
	}

/// <summary>
/// <para>
/// Gets whether @hsts_enforcer stores policies persistenly.
/// </para>
/// </summary>

/// <param name="hsts_enforcer">
/// a #SoupHSTSEnforcer
/// </param>
/// <return>
/// %TRUE if @hsts_enforcer storage is persistent or %FALSE otherwise.
/// </return>

	public static bool IsPersistent(this MentorLake.Soup.SoupHSTSEnforcerHandle hsts_enforcer)
	{
		if (hsts_enforcer.IsInvalid) throw new Exception("Invalid handle (SoupHSTSEnforcerHandle)");
		return SoupHSTSEnforcerHandleExterns.soup_hsts_enforcer_is_persistent(hsts_enforcer);
	}

/// <summary>
/// <para>
/// Sets @policy to @hsts_enforcer.
/// </para>
/// <para>
/// If @policy is expired, any existing HSTS policy for its host will be removed
/// instead. If a policy existed for this host, it will be replaced. Otherwise,
/// the new policy will be inserted. If the policy is a session policy, that is,
/// one created with [ctor@HSTSPolicy.new_session_policy], the policy will not
/// expire and will be enforced during the lifetime of @hsts_enforcer&apos;s
/// [class@Session].
/// </para>
/// </summary>

/// <param name="hsts_enforcer">
/// a #SoupHSTSEnforcer
/// </param>
/// <param name="policy">
/// the policy of the HSTS host
/// </param>

	public static T SetPolicy<T>(this T hsts_enforcer, MentorLake.Soup.SoupHSTSPolicyHandle policy) where T : SoupHSTSEnforcerHandle
	{
		if (hsts_enforcer.IsInvalid) throw new Exception("Invalid handle (SoupHSTSEnforcerHandle)");
		SoupHSTSEnforcerHandleExterns.soup_hsts_enforcer_set_policy(hsts_enforcer, policy);
		return hsts_enforcer;
	}

/// <summary>
/// <para>
/// Sets a session policy for @domain.
/// </para>
/// <para>
/// A session policy is a policy that is permanent to the lifetime of
/// @hsts_enforcer&apos;s [class@Session] and doesn&apos;t expire.
/// </para>
/// </summary>

/// <param name="hsts_enforcer">
/// a #SoupHSTSEnforcer
/// </param>
/// <param name="domain">
/// policy domain or hostname
/// </param>
/// <param name="include_subdomains">
/// %TRUE if the policy applies on sub domains
/// </param>

	public static T SetSessionPolicy<T>(this T hsts_enforcer, string domain, bool include_subdomains) where T : SoupHSTSEnforcerHandle
	{
		if (hsts_enforcer.IsInvalid) throw new Exception("Invalid handle (SoupHSTSEnforcerHandle)");
		SoupHSTSEnforcerHandleExterns.soup_hsts_enforcer_set_session_policy(hsts_enforcer, domain, include_subdomains);
		return hsts_enforcer;
	}

}

internal class SoupHSTSEnforcerHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupHSTSEnforcerHandle>))]
	internal static extern MentorLake.Soup.SoupHSTSEnforcerHandle soup_hsts_enforcer_new();

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle soup_hsts_enforcer_get_domains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSEnforcerHandle>))] MentorLake.Soup.SoupHSTSEnforcerHandle hsts_enforcer, bool session_policies);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle soup_hsts_enforcer_get_policies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSEnforcerHandle>))] MentorLake.Soup.SoupHSTSEnforcerHandle hsts_enforcer, bool session_policies);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_hsts_enforcer_has_valid_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSEnforcerHandle>))] MentorLake.Soup.SoupHSTSEnforcerHandle hsts_enforcer, string domain);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_hsts_enforcer_is_persistent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSEnforcerHandle>))] MentorLake.Soup.SoupHSTSEnforcerHandle hsts_enforcer);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_hsts_enforcer_set_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSEnforcerHandle>))] MentorLake.Soup.SoupHSTSEnforcerHandle hsts_enforcer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSPolicyHandle>))] MentorLake.Soup.SoupHSTSPolicyHandle policy);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_hsts_enforcer_set_session_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupHSTSEnforcerHandle>))] MentorLake.Soup.SoupHSTSEnforcerHandle hsts_enforcer, string domain, bool include_subdomains);

}
