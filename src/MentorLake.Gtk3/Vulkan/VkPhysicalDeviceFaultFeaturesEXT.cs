namespace MentorLake.Vulkan;


public class VkPhysicalDeviceFaultFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceFaultFeaturesEXTExtensions
{

	public static VkPhysicalDeviceFaultFeaturesEXT Dereference(this VkPhysicalDeviceFaultFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceFaultFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceFaultFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceFaultFeaturesEXT
{
}
