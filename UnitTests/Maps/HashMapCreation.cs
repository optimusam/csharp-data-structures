using FluentAssertions;
using Maps;

namespace UnitTests.Maps;

public class HashMapCreation
{
    [Fact]
    public void HashMap_CreateHashMap_StringToInteger()
    {
        MyHashMap<string, int> scoreCard = new();
        scoreCard["aprajita"] = 100;
        scoreCard["sameer"] = 99;
        scoreCard["aprajita"].Should().Be(100);
        scoreCard["sameer"].Should().Be(99);
        scoreCard.ContainsKey("sameer").Should().BeTrue();
        scoreCard.ContainsKey("mehul").Should().BeFalse();
        var fetchUsingInvalidKey = () => scoreCard["mehul"];
        fetchUsingInvalidKey.Should().Throw<Exception>()
            .WithMessage(
            $"The Key mehul does not exist in the Map."
            );
        scoreCard["mehul"] = 90;
        scoreCard.Remove("mehul");
        scoreCard.ContainsKey("mehul").Should().BeFalse();
        scoreCard["sameer"] = 999;
        scoreCard["sameer"].Should().Be(999);
        var removeInvalidKey = () => scoreCard.Remove("Rahul");
        removeInvalidKey.Should().NotThrow<Exception>();
    }
    
    [Fact]
    public void HashMap_CreateHashMap_IntegerToString()
    {
        MyHashMap<int, string> scoreCard = new();
        scoreCard[1] = "A";
        scoreCard[2] = "B";
        scoreCard[1].Should().Be("A");
        scoreCard[2].Should().Be("B");
        scoreCard.ContainsKey(1).Should().BeTrue();
        scoreCard.ContainsKey(3).Should().BeFalse();
        var fetchUsingInvalidKey = () => scoreCard[100];
        fetchUsingInvalidKey.Should().Throw<Exception>()
            .WithMessage(
                $"The Key 100 does not exist in the Map."
            );
        scoreCard.Remove(2);
        scoreCard.ContainsKey(2).Should().BeFalse();
        scoreCard[1] = "Z";
        scoreCard[1].Should().Be("Z");
    }
}