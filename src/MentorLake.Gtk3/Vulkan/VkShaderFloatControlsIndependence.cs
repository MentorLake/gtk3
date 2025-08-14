namespace MentorLake.Vulkan;


public class VkShaderFloatControlsIndependenceHandle : BaseSafeHandle
{
}


public static class VkShaderFloatControlsIndependenceExtensions
{

	public static VkShaderFloatControlsIndependence Dereference(this VkShaderFloatControlsIndependenceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderFloatControlsIndependence>(x.DangerousGetHandle());
}
internal class VkShaderFloatControlsIndependenceExterns
{
}


public struct VkShaderFloatControlsIndependence
{
}
