namespace MentorLake.Vulkan;

public class VkDrawIndirectCommandHandle : BaseSafeHandle
{
}


public static class VkDrawIndirectCommandExtensions
{

	public static VkDrawIndirectCommand Dereference(this VkDrawIndirectCommandHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDrawIndirectCommand>(x.DangerousGetHandle());
}
internal class VkDrawIndirectCommandExterns
{
}

public struct VkDrawIndirectCommand
{
}
