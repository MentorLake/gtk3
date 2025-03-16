namespace MentorLake.Vulkan;

public class VkVideoSessionParametersCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoSessionParametersCreateInfoKHRExtensions
{

	public static VkVideoSessionParametersCreateInfoKHR Dereference(this VkVideoSessionParametersCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoSessionParametersCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoSessionParametersCreateInfoKHRExterns
{
}

public struct VkVideoSessionParametersCreateInfoKHR
{
}
