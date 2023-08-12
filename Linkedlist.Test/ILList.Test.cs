using linkedlist;
namespace Linkedlist.Test;

public class ILListTest
{

    [Fact]
    public void CreateLList_HeadAndTailShouldHaveNull()
    {
        ILList<int> list = new LList<int>();
        var head = list.GetHead();
        var tail = list.GetTail();
        Assert.Null(head);
        Assert.Null(tail);
    }

    [Fact]
    public void CreateLList_AddFirst10_HeadShouldHave10()
    {
        ILList<int> list = new LList<int>();
        list.AddFirst(10);
        var head = list.GetHead();
        Assert.Equal(10, head?.Data);
    }

    [Fact]
    public void CreateLList_AddFirst10_TailShouldHave10()
    {
        ILList<int> list = new LList<int>();
        list.AddFirst(10);
        var tail = list.GetTail();
        Assert.Equal(10, tail?.Data);
    }

    [Fact]
    public void CreateLList_AddFirst10AddFirst20_HeadShouldHave20()
    {
        ILList<int> list = new LList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        var head = list.GetHead();
        Assert.Equal(20, head?.Data);
    }

    [Fact]
    public void CreateLList_AddFirst10AddFirst20_TailShouldHave10()
    {
        ILList<int> list = new LList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        var tail = list.GetTail();
        Assert.Equal(10, tail?.Data);
    }

    [Fact]
    public void CreateLList_AddLast10_TailShouldHave10()
    {
        ILList<int> list = new LList<int>();
        list.AddLast(10);
        var tail = list.GetTail();
        Assert.Equal(10, tail?.Data);
    }

    [Fact]
    public void CreateLList_AddLast10AddLast20_TailShouldHave20()
    {
        ILList<int> list = new LList<int>();
        list.AddLast(10);
        list.AddLast(20);
        var tail = list.GetTail();
        Assert.Equal(20, tail?.Data);
    }

    [Fact]
    public void CreateLList_AddFirstHeartAddFirstSAddLast_HeadShouldHaveSTailShouldHaveA()
    {
        ILList<string> list = new LList<string>();
        list.AddFirst("❤️");
        list.AddFirst("S");
        list.AddLast("A");
        var head = list.GetHead();
        Assert.Equal("S", head?.Data);
        var tail = list.GetTail();
        Assert.Equal("A", tail?.Data);
    }

    [Fact]
    public void RemoveFirst_AddFirst10AddFirst20RemoveFirst_RemovedShouldBe20()
    {
        ILList<int> list = new LList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        var removedNode = list.RemoveFirst();
        Assert.Equal(20, removedNode);
    }

    [Fact]
    public void RemoveFirst_RemoveFirst_ShouldThrowListEmptyException()
    {
        ILList<int> list = new LList<int>();
        Assert.ThrowsAny<ListEmptyException>(() => list.RemoveFirst());
    }

    [Fact]
    public void RemoveLast_RemoveLast_ShouldThrowListEmptyException()
    {
        ILList<int> list = new LList<int>();
        Assert.ThrowsAny<ListEmptyException>(() => list.RemoveLast());
    }


    [Fact]
    public void RemoveLast_AddFirst10AddFirst20RemoveLast_RemovedShouldBe10()
    {
        ILList<int> list = new LList<int>();
        list.AddFirst(10);
        list.AddFirst(20);
        var removedNode = list.RemoveLast();
        Assert.Equal(10, removedNode);
    }

}
