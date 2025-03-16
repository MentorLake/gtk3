namespace MentorLake.Vulkan;

public class VkPresentInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPresentInfoKHRExtensions
{

	public static VkPresentInfoKHR Dereference(this VkPresentInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentInfoKHR>(x.DangerousGetHandle());
}
internal class VkPresentInfoKHRExterns
{
}

public struct VkPresentInfoKHR
{
}
