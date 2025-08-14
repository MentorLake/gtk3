namespace MentorLake.Vulkan;


public class VkPresentRegionKHRHandle : BaseSafeHandle
{
}


public static class VkPresentRegionKHRExtensions
{

	public static VkPresentRegionKHR Dereference(this VkPresentRegionKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPresentRegionKHR>(x.DangerousGetHandle());
}
internal class VkPresentRegionKHRExterns
{
}


public struct VkPresentRegionKHR
{
}
