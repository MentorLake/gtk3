namespace MentorLake.Vulkan;

public class VkSamplerCubicWeightsCreateInfoQCOMHandle : BaseSafeHandle
{
}


public static class VkSamplerCubicWeightsCreateInfoQCOMExtensions
{

	public static VkSamplerCubicWeightsCreateInfoQCOM Dereference(this VkSamplerCubicWeightsCreateInfoQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerCubicWeightsCreateInfoQCOM>(x.DangerousGetHandle());
}
internal class VkSamplerCubicWeightsCreateInfoQCOMExterns
{
}

public struct VkSamplerCubicWeightsCreateInfoQCOM
{
}
