namespace MentorLake.Vulkan;


public class VkPhysicalDeviceColorWriteEnableFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceColorWriteEnableFeaturesEXTExtensions
{

	public static VkPhysicalDeviceColorWriteEnableFeaturesEXT Dereference(this VkPhysicalDeviceColorWriteEnableFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceColorWriteEnableFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceColorWriteEnableFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
{
}
