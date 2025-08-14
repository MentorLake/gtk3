namespace MentorLake.Vulkan;


public class VkDynamicStateHandle : BaseSafeHandle
{
}


public static class VkDynamicStateExtensions
{

	public static VkDynamicState Dereference(this VkDynamicStateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDynamicState>(x.DangerousGetHandle());
}
internal class VkDynamicStateExterns
{
}


public struct VkDynamicState
{
}
