namespace MentorLake.Vulkan;


public class VkPhysicalDeviceTilePropertiesFeaturesQCOMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceTilePropertiesFeaturesQCOMExtensions
{

	public static VkPhysicalDeviceTilePropertiesFeaturesQCOM Dereference(this VkPhysicalDeviceTilePropertiesFeaturesQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceTilePropertiesFeaturesQCOM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceTilePropertiesFeaturesQCOMExterns
{
}


public struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
{
}
