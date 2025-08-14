namespace MentorLake.Vulkan;


public class VkPhysicalDeviceLayeredDriverPropertiesMSFTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceLayeredDriverPropertiesMSFTExtensions
{

	public static VkPhysicalDeviceLayeredDriverPropertiesMSFT Dereference(this VkPhysicalDeviceLayeredDriverPropertiesMSFTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceLayeredDriverPropertiesMSFT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceLayeredDriverPropertiesMSFTExterns
{
}


public struct VkPhysicalDeviceLayeredDriverPropertiesMSFT
{
}
