namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMutableDescriptorTypeFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMutableDescriptorTypeFeaturesEXTExtensions
{

	public static VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT Dereference(this VkPhysicalDeviceMutableDescriptorTypeFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMutableDescriptorTypeFeaturesEXTExterns
{
}

public struct VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT
{
}
