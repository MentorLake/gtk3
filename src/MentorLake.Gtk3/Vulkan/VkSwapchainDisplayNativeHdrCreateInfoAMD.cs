namespace MentorLake.Vulkan;


public class VkSwapchainDisplayNativeHdrCreateInfoAMDHandle : BaseSafeHandle
{
}


public static class VkSwapchainDisplayNativeHdrCreateInfoAMDExtensions
{

	public static VkSwapchainDisplayNativeHdrCreateInfoAMD Dereference(this VkSwapchainDisplayNativeHdrCreateInfoAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSwapchainDisplayNativeHdrCreateInfoAMD>(x.DangerousGetHandle());
}
internal class VkSwapchainDisplayNativeHdrCreateInfoAMDExterns
{
}


public struct VkSwapchainDisplayNativeHdrCreateInfoAMD
{
}
