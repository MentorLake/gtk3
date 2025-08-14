namespace MentorLake.Vulkan;


public class VkLogicOpHandle : BaseSafeHandle
{
}


public static class VkLogicOpExtensions
{

	public static VkLogicOp Dereference(this VkLogicOpHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkLogicOp>(x.DangerousGetHandle());
}
internal class VkLogicOpExterns
{
}


public struct VkLogicOp
{
}
