namespace MentorLake.Vulkan;


public class VkReleaseSwapchainImagesInfoEXTHandle : BaseSafeHandle
{
}


public static class VkReleaseSwapchainImagesInfoEXTExtensions
{

	public static VkReleaseSwapchainImagesInfoEXT Dereference(this VkReleaseSwapchainImagesInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkReleaseSwapchainImagesInfoEXT>(x.DangerousGetHandle());
}
internal class VkReleaseSwapchainImagesInfoEXTExterns
{
}


public struct VkReleaseSwapchainImagesInfoEXT
{
}
