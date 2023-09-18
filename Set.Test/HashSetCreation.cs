using FluentAssertions;

namespace Set.Test;

public class HashSetCreation
{
    [Fact]
    public void HashSet_CreateHashSet_Integer()
    {
        HashSet<int> set = new HashSet<int>();
        set.Add(1);      // set = [1]
        set.Add(2);      // set = [1, 2]
        
        set.Contains(1).Should().BeTrue();
        set.Contains(2).Should().BeTrue();
        set.Contains(3).Should().BeFalse();

        set.Add(2);      // set = [1, 2]
        
        set.Contains(2).Should().BeTrue();
        
        set.Remove(2);   // set = [1]
        set.Add(3); // set = [1,3]
        
        set.Contains(2).Should().BeFalse();
        set.Contains(3).Should().BeTrue();
    }

    [Fact]
    public void HashSet_CreateHashSet_String()
    {
        var set = new HashSet<string>();
        set.Add("sameer");
        set.Add("aprajita");
        set.Contains("sameer").Should().BeTrue();
        set.Contains("aprajita").Should().BeTrue();
        set.Contains("Aprajita").Should().BeFalse();
        set.Contains("Mehul").Should().BeFalse();
    }
}