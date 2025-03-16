namespace MentorLake.Vulkan;

public class VkVideoSessionParametersCreateFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoSessionParametersCreateFlagsKHRExtensions
{

	public static VkVideoSessionParametersCreateFlagsKHR Dereference(this VkVideoSessionParametersCreateFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoSessionParametersCreateFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoSessionParametersCreateFlagsKHRExterns
{
}

public struct VkVideoSessionParametersCreateFlagsKHR
{
}
