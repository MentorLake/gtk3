namespace MentorLake.Vulkan;


public class VkBlitImageCubicWeightsInfoQCOMHandle : BaseSafeHandle
{
}


public static class VkBlitImageCubicWeightsInfoQCOMExtensions
{

	public static VkBlitImageCubicWeightsInfoQCOM Dereference(this VkBlitImageCubicWeightsInfoQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBlitImageCubicWeightsInfoQCOM>(x.DangerousGetHandle());
}
internal class VkBlitImageCubicWeightsInfoQCOMExterns
{
}


public struct VkBlitImageCubicWeightsInfoQCOM
{
}
