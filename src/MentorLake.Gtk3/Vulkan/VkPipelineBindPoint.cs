namespace MentorLake.Vulkan;


public class VkPipelineBindPointHandle : BaseSafeHandle
{
}


public static class VkPipelineBindPointExtensions
{

	public static VkPipelineBindPoint Dereference(this VkPipelineBindPointHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineBindPoint>(x.DangerousGetHandle());
}
internal class VkPipelineBindPointExterns
{
}


public struct VkPipelineBindPoint
{
}
