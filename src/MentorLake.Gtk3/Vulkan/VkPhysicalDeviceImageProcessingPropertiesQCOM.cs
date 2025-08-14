namespace MentorLake.Vulkan;


public class VkPhysicalDeviceImageProcessingPropertiesQCOMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceImageProcessingPropertiesQCOMExtensions
{

	public static VkPhysicalDeviceImageProcessingPropertiesQCOM Dereference(this VkPhysicalDeviceImageProcessingPropertiesQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceImageProcessingPropertiesQCOM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceImageProcessingPropertiesQCOMExterns
{
}


public struct VkPhysicalDeviceImageProcessingPropertiesQCOM
{
}
