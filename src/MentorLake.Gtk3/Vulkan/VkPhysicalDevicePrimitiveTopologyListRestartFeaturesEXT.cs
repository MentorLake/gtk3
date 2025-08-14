namespace MentorLake.Vulkan;


public class VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXTExtensions
{

	public static VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT Dereference(this VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXTExterns
{
}


public struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
{
}
