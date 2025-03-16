namespace MentorLake.Vulkan;

public class VkPresentRegionsKHRHandle : BaseSafeHandle
{
}


public static class VkPresentRegionsKHRExtensions
{

	public static VkPresentRegionsKHR Dereference(this VkPresentRegionsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentRegionsKHR>(x.DangerousGetHandle());
}
internal class VkPresentRegionsKHRExterns
{
}

public struct VkPresentRegionsKHR
{
}
