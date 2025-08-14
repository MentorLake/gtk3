namespace MentorLake.Vulkan;


public class VkPhysicalDeviceVertexInputDynamicStateFeaturesEXTHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceVertexInputDynamicStateFeaturesEXTExtensions
{

	public static VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT Dereference(this VkPhysicalDeviceVertexInputDynamicStateFeaturesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceVertexInputDynamicStateFeaturesEXTExterns
{
}


public struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
{
}
