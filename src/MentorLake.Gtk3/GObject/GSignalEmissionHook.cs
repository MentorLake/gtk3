namespace MentorLake.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSignalEmissionHook([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalInvocationHintHandle>))] MentorLake.GObject.GSignalInvocationHintHandle ihint, uint n_param_values, MentorLake.GObject.GValue[] param_values, IntPtr data);
