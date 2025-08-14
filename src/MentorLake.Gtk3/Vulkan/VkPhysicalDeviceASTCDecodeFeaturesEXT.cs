namespace MentorLake.Vulkan;


public class VkPhysicalDeviceASTCDecodeFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceASTCDecodeFeaturesEXTExtensions
{

	public static VkPhysicalDeviceASTCDecodeFeaturesEXT Dereference(this VkPhysicalDeviceASTCDecodeFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceASTCDecodeFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceASTCDecodeFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceASTCDecodeFeaturesEXT
{
}
