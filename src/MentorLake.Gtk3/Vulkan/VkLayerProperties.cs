namespace MentorLake.Vulkan;

public class VkLayerPropertiesHandle : BaseSafeHandle
{
}


public static class VkLayerPropertiesExtensions
{

	public static VkLayerProperties Dereference(this VkLayerPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLayerProperties>(x.DangerousGetHandle());
}
internal class VkLayerPropertiesExterns
{
}

public struct VkLayerProperties
{
}
